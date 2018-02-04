%**************************************************************************
%   FUNCTION:    LeddarGetData.m
%
%   DESCRIPTION: Main function to get new data from opened Leddar device.
%
%   INPUT:
%       - dev : Device opened by LeddarOpen
%       - ind : Frame index to go to in file mode (0-based)
%       - mode: Open mode. Either 'file' or 'live'.
%
%   OUTPUT:
%       - new: Bool indicating if new data is available. True on success,
%              false when no more data, if a timeout or an error occured.
%       - det: Detection array
%
%   DATE:    2013-11-13
%
% Copyright ©2013 LeddarTech Inc. All rights reserved. Information
% contained herein is or may be confidential and proprietary to LeddarTech
% inc. Prior to using any part of the software development kit accompanying
% this notice, you must accept and agree to be bound to the terms of the
% LeddarTech Inc. license agreement accompanying this file.
%**************************************************************************
function [new det time] = LeddarGetData( dev, ind, mode)
global deviceDATA
i = 0;
index = 1;

while (index <= size(deviceDATA,2) && i == 0)
    if (deviceDATA(index).dev == dev)
        i = index;
    end
    index = index+1;
end


if i > size(deviceDATA,2)
    fprintf('LeddarGetData: unknown device');
    return;
end


new = false;
det = [];

% Move frame index if requried
if strcmpi(mode,'file')
    if ind >= 0 && ind < dev.RecordSize
        dev.MoveRecordTo(ind);
    else
        fprintf('Out-of-range frame index #%d on a record size of %d.\n', ind, dev.RecordSize);
        return;
    end
    
    maxT = .05; % No need to wait in file
else
    maxT = 5;   % Wait longer if in live
end

t     = 0;
new   = deviceDATA(i).new;
timer = tic;

% Wait until new data ... or timeout
while ~new && t < maxT
    pause(.01);
    t = toc(timer);
    new = deviceDATA(i).new;
end

if t >= maxT
    fprintf('A timeout occured after %.2f seconds. \n', maxT);
end

det      = deviceDATA(i).det;
deviceDATA(i).new = false;
time = deviceDATA(i).time;
