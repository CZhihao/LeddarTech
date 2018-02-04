%**************************************************************************
%   FUNCTION:    LeddarClose.m
%
%   DESCRIPTION: Closes an opened Leddar device & cleans up everything.
%
%   INPUT:
%       - dev: Device opened by LeddarOpen
%       - lis: Registered function handle to be unregistered.
%
%   OUTPUT: None.
%
%   DATE:   2013-11-13
%
% Copyright ©2013 LeddarTech Inc. All rights reserved. Information
% contained herein is or may be confidential and proprietary to LeddarTech
% inc. Prior to using any part of the software development kit accompanying
% this notice, you must accept and agree to be bound to the terms of the
% LeddarTech Inc. license agreement accompanying this file.
%**************************************************************************
function LeddarClose(dev,lis)
global deviceDATA

delete(lis);

%Also delete entry in the temporary data table
i = 1;
while i <= size(deviceDATA,2)
    if deviceDATA(i).dev == dev
        break;
    end
    i = i+1;
end

if i <= size(deviceDATA,2)
    deviceDATA(i) = [];
end


dev.Disconnect();
dev.Dispose();
