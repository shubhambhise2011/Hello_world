@echo off
setlocal enabledelayedexpansion

cd /d "C:\Users\Admin\Documents\agent_code"

REM Delete duplicate files
echo Removing duplicate files...
del /q HelloWorld.cs 2>nul
rmdir /s /q bin 2>nul
rmdir /s /q obj 2>nul

echo Building project...
"C:\Program Files\dotnet\dotnet.exe" build -c Release

if errorlevel 1 (
    echo Build failed!
    pause
    exit /b 1
)

echo.
echo SUCCESS! Your HelloWorldCs.exe is ready at:
echo C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe
echo.
"C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe"
