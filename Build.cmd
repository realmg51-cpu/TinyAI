@echo off
echo ========================================
echo    Building TinyAI - Windows
echo ========================================
echo.

where dotnet >nul 2>nul
if %errorlevel% neq 0 (
    echo [ERROR] Dotnet SDK not found!
    echo Please install .NET SDK from: https://dotnet.microsoft.com/download
    pause
    exit /b 1
)

echo [1/4] Cleaning previous build...
if exist "bin\" rmdir /s /q bin
if exist "obj\" rmdir /s /q obj
echo Done.
echo.

echo [2/4] Restoring dependencies...
dotnet restore
if %errorlevel% neq 0 (
    echo [ERROR] Failed to restore dependencies!
    pause
    exit /b 1
)
echo Done.
echo.

echo [3/4] Building TinyAI...
dotnet build -c Release --no-restore
if %errorlevel% neq 0 (
    echo [ERROR] Build failed!
    pause
    exit /b 1
)
echo Done.
echo.

echo [4/4] Creating output directory...
if not exist "output\" mkdir output
copy /y "bin\Release\*.exe" "output\" >nul
copy /y "bin\Release\*.dll" "output\" >nul
echo Done.
echo.

echo ========================================
echo    Build Successful!
echo    Output files are in 'output' folder
echo ========================================
echo.
pause
