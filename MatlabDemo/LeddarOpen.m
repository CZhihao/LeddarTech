%**************************************************************************
%   FUNCTION:    LeddarOpen.m
%
%   DESCRIPTION: Opens a new connection to a Leddar sensor.
%
%   INPUT:
%       - iPath: Either a path to a recorded Leddar log or a USB sensor
%                name to connect to.
%       - iMode: Either 'file' to request a file opening or 'live' for a
%                USB connection.
%
%   OUTPUT:
%       - res: Bool result. True on success, false otherwise.
%       - dev: Opened Leddar device. Used in LeddarGetData & LeddarClose.
%              Empty on error.
%       - lis: Handle to the listener for DataReceived event. Required by
%              LeddarClose for the unregistration. Empty on error.
%
%   DATE:   2013-11-13
%
% Copyright ©2013 LeddarTech Inc. All rights reserved. Information
% contained herein is or may be confidential and proprietary to LeddarTech
% inc. Prior to using any part of the software development kit accompanying
% this notice, you must accept and agree to be bound to the terms of the
% LeddarTech Inc. license agreement accompanying this file.
%**************************************************************************
function [res dev lis] = LeddarOpen( iPath, iMode)
global deviceDATA
res = false;
dev = [];
lis = [];

dllName = 'LeddarNET2.dll';

% Load the LeddarNET assembly into Matlab by reading the environment
% variable created during install
p = getenv('LEDDARTECH_LIBS');
if isempty(p)
    fprintf('Error: Could not load the LEDDARTECH environment variable. You have to locate %s yourself.\n', dllName);
    p = uigetdir('',['Locate ' dllName]);
    if numel(p)==1 && p == 0
        return;
    end
end

NET.addAssembly( fullfile(p,dllName) );

% Device constructor
dev = LeddarNET.Device;

% Call the proper device opening function depending on connection mode
if strcmpi(iMode,'live')
    res = dev.Connect(iPath);
    if res == 0
        res = false;
        fprintf('Error opening device "%s"\n', iPath);
    end
elseif strcmpi(iMode,'file')
    if exist(iPath,'file')
        try
            dev.LoadRecord(iPath);
            res = true;
        catch
            fprintf('Error opening file: %s\n', iPath);
        end
    else
        fprintf('File not found: %s\n', iPath);
    end
end

if ~res
    dev.Dispose();
    dev = [];
    lis = [];
    return;
end

% Prepare the data structure for temporary data storage
tmpDATA.new = false;
tmpDATA.det = [];
tmpDATA.time = clock;
tmpDATA.dev = dev;
if isempty(deviceDATA)
    deviceDATA = tmpDATA;
else
    deviceDATA = [deviceDATA, tmpDATA];
end

% Listen to the DataReceived event and start the communication
lis = addlistener( dev, 'DataReceived', @DataReceived_CB);
flags = LeddarNET.DataLevels.Detections;
dev.StartDataTransfer(flags);


%**************************************************************************
%   FUNCTION:    DataReceived_CB
%   DESCRIPTION: Callback for the .NET DataReceived event.
%
%   INPUT:
%       - src: Event source (Device object)
%       - evt: Event data.
%
%   OUTPUT: None.
%
%   DATE:   2013-11-13
%**************************************************************************
function DataReceived_CB( src, evt)
global deviceDATA
i = 1;

%Get timestamp
time = clock;

while i <= size(deviceDATA,2)
    if deviceDATA(i).dev == src
        break;
    end
    i = i+1;
end
    

if i > size(deviceDATA,2)
    fprintf('DataReceived: unknown device');
else
    deviceDATA(i).time = time;
    deviceDATA(i).det  = src.Detections();
    deviceDATA(i).new  = true;
end

