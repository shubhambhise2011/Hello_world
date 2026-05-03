@echo off
setlocal enabledelayedexpansion

REM Add dotnet to PATH permanently
echo Adding C:\Program Files\dotnet to PATH...
setx PATH "C:\Program Files\dotnet;%PATH%"

if errorlevel 1 (
    echo Warning: Could not update PATH. You may need to run as Administrator.
)

echo.
echo PATH updated! Please close this window and open a NEW command prompt.
echo Then navigate to C:\Users\Admin\Documents\agent_code and run: dotnet build -c Release
pause
