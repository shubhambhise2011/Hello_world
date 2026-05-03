@echo off
setlocal enabledelayedexpansion

REM Use full path to dotnet
set DOTNET="C:\Program Files\dotnet\dotnet.exe"

REM Verify dotnet exists
if not exist %DOTNET% (
    echo Error: dotnet.exe not found at C:\Program Files\dotnet
    pause
    exit /b 1
)

REM Navigate to project directory
cd /d "C:\Users\Admin\Documents\agent_code"

REM Build the project
echo Building project...
%DOTNET% build -c Release

if errorlevel 1 (
    echo Build failed!
    pause
    exit /b 1
)

echo.
echo ============================================
echo Build completed successfully!
echo ============================================
echo.
echo Executable location:
echo C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe
echo.
echo You can now run it directly!
pause
