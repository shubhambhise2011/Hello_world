@echo off
setlocal enabledelayedexpansion

cd /d "C:\Users\Admin\Documents\agent_code"
"C:\Program Files\dotnet\dotnet.exe" build -c Release
echo.
echo Build finished! Executable at:
echo C:\Users\Admin\Documents\agent_code\bin\Release\net6.0-windows\HelloWorldCs.exe
