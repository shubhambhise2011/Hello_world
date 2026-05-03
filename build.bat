@echo off
setlocal enabledelayedexpansion

REM Find dotnet.exe
for /f "delims=" %%A in ('where dotnet.exe 2^>nul') do set "DOTNET=%%A"

if not defined DOTNET (
    echo Error: dotnet CLI not found. Please install .NET SDK from https://dotnet.microsoft.com/download
    exit /b 1
)

REM Build the project
echo Building project...
"%DOTNET%" build -c Release

if errorlevel 1 (
    echo Build failed!
    exit /b 1
)

echo Build complete! 
echo Executable location: C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe
echo.
echo You can now run the executable directly from the command line or by double-clicking it.
pause
