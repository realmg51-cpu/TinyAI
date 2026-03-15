# Dockerfile cho TinyAI với cấu trúc src/Main/
# Sử dụng build arguments để linh hoạt hơn
ARG DOTNET_VERSION=6.0
ARG RUNTIME_VERSION=6.0
ARG CONFIGURATION=Release

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:${DOTNET_VERSION} AS build
ARG CONFIGURATION
ARG PROJECT_NAME=TinyAI

WORKDIR /src

# Copy csproj và restore dependencies riêng để tận dụng Docker cache
COPY src/Main/*.csproj ./Main/
RUN dotnet restore ./Main/${PROJECT_NAME}.csproj

# Copy toàn bộ source code
COPY src/Main/ ./Main/

# Build và publish với các tối ưu
WORKDIR /src/Main
RUN dotnet publish -c ${CONFIGURATION} \
    -o /app/publish \
    --no-restore \
    -p:DebugType=none \
    -p:DebugSymbols=false \
    -p:TrimMode=link \
    -p:EnableTrimAnalyzer=true

# Test stage (optional) - chạy unit tests trong container
FROM build AS test
RUN dotnet test --no-restore --verbosity normal

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:${RUNTIME_VERSION} AS runtime
ARG PROJECT_NAME=TinyAI

# Cài đặt các dependencies cần thiết
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
    ca-certificates \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /app

# Copy từ build stage
COPY --from=build --chown=1000:1000 /app/publish .

# Tạo user non-root với security tốt hơn
RUN addgroup --gid 1000 --system tinyai && \
    adduser --uid 1000 --system --ingroup tinyai tinyai && \
    chown -R tinyai:tinyai /app

# Security: không chạy với root
USER tinyai

# Health check
HEALTHCHECK --interval=30s --timeout=3s --start-period=5s --retries=3 \
    CMD dotnet ${PROJECT_NAME}.dll --health-check || exit 1

# Metadata
LABEL maintainer="your-email@example.com" \
      version="${VERSION:-latest}" \
      description="TinyAI Application"

# Environment variables
ENV ASPNETCORE_ENVIRONMENT=Production \
    DOTNET_RUNNING_IN_CONTAINER=true \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Expose port (nếu là web app)
# EXPOSE 8080

# Run app
ENTRYPOINT ["dotnet", "TinyAI.dll"]
