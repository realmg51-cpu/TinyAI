# Stage 1: Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copy csproj và restore dependencies
COPY *.sln .
COPY TinyAI.csproj .
RUN dotnet restore

# Copy source code và build
COPY . .
RUN dotnet publish -c Release -o /app --no-restore

# Stage 2: Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

# Copy từ build stage sang runtime stage
COPY --from=build /app .

# Tạo user không có quyền root để chạy app (bảo mật hơn)
USER $APP_UID

# Entry point
ENTRYPOINT ["dotnet", "TinyAI.dll"]
