@echo off
setlocal enabledelayedexpansion

REM Download and install .NET 6.0 SDK
echo Downloading .NET 6.0 SDK installer...
powershell -NoProfile -ExecutionPolicy Bypass -Command ^
  "Invoke-WebRequest -Uri 'https://dot.net/v1/dotnet-install.ps1' -OutFile '$env:TEMP\dotnet-install.ps1'; ^
   & '$env:TEMP\dotnet-install.ps1' -Version latest -InstallDir 'C:\Program Files\dotnet' -NoPath"

if errorlevel 1 (
    echo Failed to download/install .NET SDK
    echo Please visit: https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

echo.
echo .NET SDK installed successfully!
echo Adding to PATH...

REM Add .NET to PATH
setx PATH "C:\Program Files\dotnet;!PATH!"

echo.
echo Please restart your terminal and run: dotnet build -c Release
pause
