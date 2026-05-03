@echo off
setlocal enabledelayedexpansion

REM Set the working directory
cd /d "C:\Users\Admin\Documents\agent_code"

REM Check if dotnet is available
"C:\Program Files\dotnet\dotnet.exe" --version >nul 2>&1
if errorlevel 1 (
    echo Error: dotnet not found
    pause
    exit /b 1
)

echo Building HelloWorldCs project...
echo.

REM Build the project
"C:\Program Files\dotnet\dotnet.exe" build -c Release

if errorlevel 1 (
    echo.
    echo Build failed!
    pause
    exit /b 1
)

echo.
echo =========================================
echo Build successful!
echo =========================================
echo.
echo Your executable is ready at:
echo C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe
echo.
echo Double-click the .exe to run it!
pause
