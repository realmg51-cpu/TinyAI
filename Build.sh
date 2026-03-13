#!/bin/bash

RED='\033[0;31m'
GREEN='\033[0;32m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}========================================${NC}"
echo -e "${BLUE}   Building TinyAI - Linux/macOS${NC}"
echo -e "${BLUE}========================================${NC}\n"

if ! command -v dotnet &> /dev/null; then
    echo -e "${RED}[ERROR] Dotnet SDK not found!${NC}"
    echo "Please install .NET SDK from: https://dotnet.microsoft.com/download"
    exit 1
fi

echo -e "${GREEN}[1/4]${NC} Cleaning previous build..."
rm -rf bin/ obj/
echo "Done.\n"

echo -e "${GREEN}[2/4]${NC} Restoring dependencies..."
dotnet restore
if [ $? -ne 0 ]; then
    echo -e "${RED}[ERROR] Failed to restore dependencies!${NC}"
    exit 1
fi
echo "Done.\n"

echo -e "${GREEN}[3/4]${NC} Building TinyAI..."
dotnet build -c Release --no-restore
if [ $? -ne 0 ]; then
    echo -e "${RED}[ERROR] Build failed!${NC}"
    exit 1
fi
echo "Done.\n"

echo -e "${GREEN}[4/4]${NC} Creating output directory..."
mkdir -p output/
cp bin/Release/*.dll output/ 2>/dev/null
cp bin/Release/*.exe output/ 2>/dev/null
cp bin/Release/*.dll.config output/ 2>/dev/null
echo "Done.\n"

echo -e "${BLUE}========================================${NC}"
echo -e "${GREEN}   Build Successful!${NC}"
echo -e "${BLUE}   Output files are in 'output' folder${NC}"
echo -e "${BLUE}========================================${NC}"
