# ---------- Build stage ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Restore first (better layer caching): copy only project files
COPY global.json ./
COPY Form.Ambulancias247/Form.Ambulancias247.csproj              Form.Ambulancias247/
COPY Form.Ambulancias247.Core/Form.Ambulancias247.Core.csproj    Form.Ambulancias247.Core/
COPY Form.Ambulancias247.Domain/Form.Ambulancias247.Domain.csproj Form.Ambulancias247.Domain/
RUN dotnet restore Form.Ambulancias247/Form.Ambulancias247.csproj

# Copy the rest of the source and publish
COPY . .
RUN dotnet publish Form.Ambulancias247/Form.Ambulancias247.csproj \
    -c Release -o /app/publish /p:UseAppHost=false

# ---------- Runtime stage ----------
# Official Playwright .NET image: ships Chromium + all system libraries,
# matched to the Microsoft.Playwright 1.57.0 NuGet package used by the app.
FROM mcr.microsoft.com/playwright/dotnet:v1.57.0-noble AS runtime
WORKDIR /app
COPY --from=build /app/publish ./

ENV ASPNETCORE_ENVIRONMENT=Production
# Fly.io routes to internal_port (8080); default to 8080 for local `docker run`.
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080

# Bind to $PORT if the platform provides one, otherwise 8080.
ENTRYPOINT ["sh", "-c", "ASPNETCORE_URLS=http://0.0.0.0:${PORT:-8080} dotnet Form.Ambulancias247.dll"]
