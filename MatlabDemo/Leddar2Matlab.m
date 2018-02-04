%**************************************************************************
%   FUNCTION:    Leddar2Matlab.m
%
%   DESCRIPTION: Example integration of the LeddarTech .NET SDK into a
%                simple Matlab user interface. Supports multiple devices
%                at the same time.
%
%   INPUT: None.
%
%   OUTPUT: None.
%
%   AUTHORS: Jean-François Bernier & Pier-Olivier Hamel
%   DATE:   2013-11-13
%   VERSION: 1.1
%
% Copyright ©2013 LeddarTech Inc. All rights reserved. Information
% contained herein is or may be confidential and proprietary to LeddarTech
% inc. Prior to using any part of the software development kit accompanying
% this notice, you must accept and agree to be bound to the terms of the
% LeddarTech Inc. license agreement accompanying this file.
%**************************************************************************

function Leddar2Matlab()

% Main GUI data structure. Stores UI controls & DataReceived event data
global DATA
persistent qtyGUI


% Increment gui counter each time a new gui is created
if (isempty(qtyGUI))
    qtyGUI = 1;
    DATA= [];

else
    qtyGUI = qtyGUI+1;
end

scrn = get(0,'ScreenSize');

% Create the figure centered in screen X-Y, fixed pixel shape
% We can also use the figure's outer position instead of position
w = 1150;     % Figure width (pixel)
h = 550;      % Figure height (pixel)
if w > scrn(3)
    w = scrn(3);
end
if h > scrn(4)
    h = scrn(4);
end

x   = (scrn(3)-w) / 2;
y   = (scrn(4)-h) / 2;
fig = figure('Name','LeddarViewer','NumberTitle','off','Toolbar','figure', 'position', [x y w h]);

% Create the main axes system to plot the detections in relative coord
gap = .05;
x   = .5;
y   = gap;
ax  = axes( 'parent', fig, 'position', [x y 1-x-gap 1-y-gap]);
hold( ax, 'on');

% The pause forces a redraw and allows Matlab to position the objects
% correctly before setting normalized units to fix the UI shape. Calling
% drawnow doesnt seem to be enough sometimes.
% Required in the figure is in 'docked' WindowStyle.
% drawnow;
% pause(.01);

fontTit = 24; % Title font size
fontCtl = 12; % General font size

unit = 'pixel';
handles = [];   % List of UI handles to be converted to normalized units

if strcmp(unit,'pixel')
    % GUI spacing configuration in pixel units:
    gap  = 10;  % generic gap
    btnW = 85;  % button width
    btnH = 45;  % button height
    txtW = 500; % text width
    txtH = 25;  % text height
    titH = 100; % title text height
    p = get(fig,'position');
    winTop = p(4); % Figure window max Y coord
elseif strcmp(unit,'normalized')
    % GUI spacing configuration in normalized units:
    gap  = .01;
    btnW = .06;
    btnH = .06;
    txtW = .33;
    txtH = .06;
    titH = .14;
    winTop = 1;
else
    return;
end

y = winTop - titH - gap;
x = gap;

tmp = uicontrol( fig, 'Units', unit, 'style', 'text', 'position', [x y txtW titH], 'String', sprintf('Leddar To Matlab\nDevice Control Center'), 'FontSize', fontTit);
handles(end+1) = tmp;
DATA(qtyGUI).lblTitle = tmp;
p = Fit2Txt( tmp, true, false, true);
y    = p(2);
titH = p(4);

y = y - txtH - gap;
tmp = uicontrol( fig, 'Units', unit, 'style', 'text', 'position', [x y txtW txtH], 'String', 'File Path or USB Device Name', 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).lblPath = tmp;
p = Fit2Txt( tmp, true, false, true);
y    = p(2);
txtH = p(4);

y = y - txtH;
tmp = uicontrol( fig, 'Units', unit, 'style', 'edit', 'position', [x y txtW txtH], 'FontSize', fontCtl, 'BackgroundColor', [1 1 1], 'String', 'Enter the name or path here');
handles(end+1) = tmp;
DATA(qtyGUI).txtPath = tmp;
p = Fit2Txt( tmp, true, false, true);
y = p(2);

x = x + txtW;
tmp = uicontrol( fig, 'Units', unit, 'style', 'pushbutton', 'position', [x y txtH txtH], 'String', '...', 'Fontsize', 17, 'FontWeight', 'bold', 'Callback', {@BtnBrowse_CB,qtyGUI});
handles(end+1) = tmp;
DATA(qtyGUI).btnPath = tmp;


info = {'radFile' 'Record File'
        'radLive' 'USB Device'};

nRad = size(info,1);

if strcmp(unit,'pixel')
    radW = btnW * 1.5;  % Width of radio buttons
    radH = btnH/2;      % Height of radio buttons

    offset = 2*gap;
    w = radW + 2*gap;   % Width of the button group
    h = nRad*(radH+gap) + offset; % Height of group
    x = gap;
    
    radX = gap;               % X coord of radios
    radY = h - offset - radH; % Y coord of radios
    radG = gap;               % Gap between radios
else
    offset = 4*gap;
    radW = .8;
    radH = (1-offset)/nRad * .7;
    radG = (1-offset)/nRad * .3;
    radX = .1;
    radY = 1 - offset - radH;
    w    = .1;
    h    = .1;
    x    = gap;
end

y = y - h - gap;
tmp = uibuttongroup( 'parent', fig, 'Units', unit, 'position', [x y w h], 'Title', 'Connection Type', 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).grpMode = tmp;
p = get( tmp,'position');

for a = 1:nRad
    tmp = uicontrol( DATA(qtyGUI).grpMode, 'Units', unit, 'style', 'radiobutton', 'position', [radX radY radW radH], 'String', info{a,2}, 'FontSize', fontCtl);
    handles(end+1) = tmp; %#ok<AGROW>
    DATA(qtyGUI).(info{a,1}) = tmp;
    radY = radY - radH - radG;
end

x = 2*gap + w;
y = y + h - btnH;
tmp = uicontrol( fig, 'Units', unit, 'style', 'togglebutton', 'position', [x y btnW btnH], 'String', 'START', 'Callback', {@BtnStart_CB,qtyGUI}, 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).btnStart = tmp;
DATA(qtyGUI).baseCol  = get( tmp, 'BackgroundColor');

y = y - btnH - gap;
tmp = uicontrol( fig, 'Units', unit, 'style', 'togglebutton', 'position', [x y btnW btnH], 'String', 'STOP', 'Callback', {@BtnStop_CB,qtyGUI}, 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).btnStop = tmp;

x = x + btnW + gap;
y = p(2) + h - btnH;
tmp = uicontrol( fig, 'Units', unit, 'style', 'togglebutton', 'position', [x y btnW btnH], 'String', 'AUTO-FIT', 'Callback', {@BtnFit_CB,qtyGUI}, 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).btnFit = tmp;

y = y - btnH - gap;
tmp = uicontrol( fig, 'Units', unit, 'style', 'pushbutton', 'position', [x y btnW btnH], 'String', 'RESET', 'Callback', {@BtnRstView_CB,qtyGUI}, 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).btnRstView = tmp;

x = gap;
y = p(2) - h - gap;
tmp = uicontrol( fig, 'Units', unit, 'style', 'text', 'position', [x y w h], 'String', sprintf('Freq: 0.00 Hz\nFrame #0 / 0000'), 'HorizontalAlignment', 'Left', 'FontSize', fontCtl);
handles(end+1) = tmp;
DATA(qtyGUI).txtTime = tmp;
p = Fit2Txt( tmp, true, false, true);

%set( handles, 'Units', 'normalized');

nSeg = 16;
pan  = 45;
PlotFan( ax, nSeg, pan);

ang = linspace(-pan/2,pan/2,nSeg+1)';
ang = ang(1:nSeg) + pan/nSeg/2;

DATA(qtyGUI).ang = [sind(ang) cosd(ang)];
DATA(qtyGUI).ax  = ax;
DATA(qtyGUI).new = false;
DATA(qtyGUI).det = [];
DATA(qtyGUI).timer = tic;

%**************************************************************************
%   FUNCTION:    PlotFan
%   DESCRIPTION: Helper function displaying segment lines on a graph.
%
%   INPUT:
%       - ax  : Target axes handle on which to draw
%       - nSeg: Number of segments to plot, usually 16
%       - pan : Pan angle of the device, usually 45 (degree)
%
%   OUTPUT:
%       - h: Handle vector to the lines.
%
%   DATE:   2013-07-12
%**************************************************************************
function h = PlotFan( ax, nSeg, pan)

ang = linspace( -pan/2, pan/2, nSeg+1)';
x = zeros(2,nSeg+1);
y = zeros(2,nSeg+1);
x(2,:) = sind(ang) * 75;
y(2,:) = cosd(ang) * 75;

h = line( x, y, 'color', [0 0 1], 'parent', ax, 'handleVisibility', 'off');


%**************************************************************************
%   FUNCTION:    BtnBrowse_CB
%   DESCRIPTION: Callback for the browse button.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   DATE:   2013-11-13
%**************************************************************************
function BtnBrowse_CB( src, evt, index)

global DATA
[f p] = uigetfile('*.ltl','Choose a Leddar Record File');

if isempty(f) || numel(f) == 1
    return;
end

set( DATA(index).txtPath, 'String', fullfile(p,f));


%**************************************************************************
%   FUNCTION:    BtnStart_CB
%   DESCRIPTION: Callback for the start button.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   DATE:   2013-11-13
%**************************************************************************
function BtnStart_CB( src, evt, index)

global DATA
str = get(DATA(index).txtPath,'String');
sel = get(DATA(index).grpMode, 'SelectedObject');

switch sel
    case DATA(index).radFile
        mode = 'file';
    case DATA(index).radLive
        mode = 'live';
    otherwise
        msgbox(sprintf('Error: Unknown connection type: "%s".',get(sel,'String')));
        return;
end

[res dev lis] = LeddarOpen( str, mode);
if ~res
    msgbox('Error: Could not open chosen connection.');
    return;
end

set( src, 'BackgroundColor', [0 1 0], 'Enable', 'off');

DATA(index).ind  = 0;

% Set the maximum index condition in the case of a file
if strcmpi(mode,'file')
    DATA(index).maxInd = dev.RecordSize;
else
    DATA(index).maxInd = Inf;
end

%Note time, save variables and start timer thread
DATA(index).lis = lis;
DATA(index).dev = dev;
DATA(index).mode = mode;
DATA(index).time = clock;
DATA(index).timer = timer('ExecutionMode', 'fixedSpacing','Period', 0.01, 'TimerFcn', {@RefreshGraph_CB,index});
start(DATA(index).timer);

%**************************************************************************
%   FUNCTION:    RefreshGraph_CB
%   DESCRIPTION: Callback function for the timers that will periodicallty
%                get the new data and refresh the plot graph.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   AUTHOR: Pier-Olivier Hamel
%   DATE:   2013-11-13
%**************************************************************************
function RefreshGraph_CB (obj, event, index)
global DATA

try
    stopState = get(DATA(index).btnStop,'Value');
    if (~stopState && DATA(index).ind < DATA(index).maxInd)
        prevTime = DATA(index).time;
        [new det time] = LeddarGetData(DATA(index).dev,DATA(index).ind,DATA(index).mode);
        if new
            FanGraph( DATA(index).ax, det, DATA(index).ang, get(DATA(index).btnFit,'Value'));
            period = etime(time,prevTime);
            if period == 0
                period = 0.01;
            end

            if ~isinf(DATA(index).maxInd)
                str = sprintf('Freq: %.2f Hz\nFrame #%d / %d', 1/period, DATA(index).ind+1, DATA(index).maxInd);
            else
                str = sprintf('Freq: %.2f Hz\nFrame #%d', 1/period, DATA(index).ind+1);
            end

            set( DATA(index).txtTime, 'String', str);
            DATA(index).ind  = DATA(index).ind + 1;
            DATA(index).time = time;
            drawnow;
            return;
        end
    end
catch

end


LeddarClose( DATA(index).dev, DATA(index).lis);
stop(obj);
delete(obj);
DATA(index).timer = [];

set( DATA(index).btnStart, 'BackgroundColor', DATA(index).baseCol, 'Enable', 'on', 'Value', false);
set( DATA(index).btnStop,  'BackgroundColor', DATA(index).baseCol, 'Value', false);



%**************************************************************************
%   FUNCTION:    FanGraph
%   DESCRIPTION: Helper function displaying the detections in a fan graph.
%
%   INPUT:
%       - ax  : Target axes handle on which to draw
%       - det : Array of detections (.NET objects)
%       - ang : [nSeg x 2] Sines and cosines associated to each segments
%               required to convert in X-Y.
%       - auto: Bool asking to zoom on the detections in the axes
%
%   OUTPUT:
%       - h: Handle to the plotted detections
%
%   DATE:   2013-07-12
%**************************************************************************
function h = FanGraph( ax, det, ang, auto)

nb  = det.Length;
x   = zeros(nb,1);
y   = zeros(nb,1);
ind = 0;
maxSeg = size(ang,1);

for a = 1:nb
    seg = det(a).Segment + 1;
    dst = det(a).Distance;
    if seg < 1 || seg > maxSeg
        continue;
    end
    
    ind = ind + 1;
    x(ind) = dst * ang(seg,1);
    y(ind) = dst * ang(seg,2);
end

x(ind+1:end) = [];
y(ind+1:end) = [];

cla(ax);
h = plot( ax, x, y, '*');

% Adjusts the axes to zoom only on the detections
if nb > 1 && auto
    x = [x;0];
    y = [y;0];
    minX = min(x);
    maxX = max(x);
    minY = min(y);
    maxY = max(y);
    set( ax, 'xlim', [minX-.5 maxX+.5]);
    set( ax, 'ylim', [minY maxY+.5]);
end


%**************************************************************************
%   FUNCTION:    BtnStop_CB
%   DESCRIPTION: Callback for the stop button. Toggles color to red.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   DATE:   2013-11-13
%**************************************************************************
function BtnStop_CB( src, evt, index)
global DATA

if get(src,'Value') ~= 0
    set(src,'BackgroundColor',[1 0 0]);
else
    set(src,'BackgroundColor',DATA(index).baseCol);
end


%**************************************************************************
%   FUNCTION:    BtnFit_CB
%   DESCRIPTION: Callback for the auto-fit button. Toggles color to yellow.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   DATE:   2013-11-13
%**************************************************************************
function BtnFit_CB( src, evt, index)
global DATA

if get(src,'Value') ~= 0
    set(src,'BackgroundColor',[1 1 0]);
else
    set(src,'BackgroundColor',DATA(index).baseCol);
end


%**************************************************************************
%   FUNCTION:    BtnRstView_CB
%   DESCRIPTION: Callback for the reset view button.
%                Resets the axes to automatic X & Y limits.
%
%   INPUT: - Standard Matlab callback inputs: source handle and eventdata.
%          - index: index of associated GUI window
%
%   DATE:   2013-11-13
%**************************************************************************
function BtnRstView_CB( src, evt, index)
global DATA
set( DATA(index).ax, 'xLimMode', 'auto', 'yLimMode', 'auto');


%**************************************************************************
%   FUNCTION:    Fit2Txt
%   DESCRIPTION: Helper function resizing a UI object to fit to its text
%                extent. Useful especially for plain text labels.
%
%   INPUT:
%       - h :   [1x1] Handle to UI object to be resized
%       - vt:   [1x1] Bool asking to resize vertically
%       - hz:   [1x1] Bool asking to resize horizontally
%       - move: [1x1] Bool asking to move the object, keeping same visual position
%
%   OUTPUT:
%       - p: [1x4] Final position vector of h following resize
%
%   NOTES:
%       When used on other objects than simple texts, the horizontal
%       resizing may not be sufficient. For example, when used on a radio
%       button, Matlab doesnt seem to consider the area of the round
%       selector, making the final extent rectangle too small in width.
%
%   DATE:   2013-07-17
%**************************************************************************
function p = Fit2Txt( h, vt, hz, move)

if nargin < 2
    vt = true;
    hz = true;
end

e = get( h, 'Extent');
p = get( h, 'Position');

if vt
    if move
        delta = e(4) - p(4);
        p(2) = p(2) - delta;
    end
    p(4) = e(4);
end

if hz
    if move
        delta = e(3) - p(3);
        p(1) = p(1) - delta;
    end
    p(3) = e(3);
end

set( h, 'position', p);

