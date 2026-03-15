# Dockerfile cho TinyAI với cấu trúc src/Main/
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy csproj từ thư mục src/Main/
COPY src/Main/*.csproj ./Main/

# Restore dependencies
RUN dotnet restore ./Main/TinyAI.csproj

# Copy toàn bộ source code
COPY src/Main/ ./Main/

# Build và publish
WORKDIR /src/Main
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime
WORKDIR /app

# Copy từ build stage
COPY --from=build /app/publish .

# Tạo user non-root
RUN useradd -m -u 1000 tinyai-user && chown -R tinyai-user /app
USER tinyai-user

# Run app
ENTRYPOINT ["dotnet", "TinyAI.dll"]
