# ---------- Stage 1: Build ----------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy each project file into its own folder, then restore.
# (There is no .csproj at the repo root — they live in subfolders.)
COPY global.json ./
COPY Form.Ambulancias247/Form.Ambulancias247.csproj              Form.Ambulancias247/
COPY Form.Ambulancias247.Core/Form.Ambulancias247.Core.csproj    Form.Ambulancias247.Core/
COPY Form.Ambulancias247.Domain/Form.Ambulancias247.Domain.csproj Form.Ambulancias247.Domain/
RUN dotnet restore Form.Ambulancias247/Form.Ambulancias247.csproj

# Copy the rest of the source and publish ONLY the web project.
COPY . .
RUN dotnet publish Form.Ambulancias247/Form.Ambulancias247.csproj \
    -c Release -o /app/publish --no-restore /p:UseAppHost=false

# ---------- Stage 2: Runtime ----------
# Must be the Playwright image, NOT plain aspnet:8.0 — it bundles Chromium
# and every system library the PDF generator needs. Tag is pinned to the
# Microsoft.Playwright 1.57.0 NuGet version used by the app.
FROM mcr.microsoft.com/playwright/dotnet:v1.57.0-noble AS runtime
WORKDIR /app

# Copy the published app from the build stage.
COPY --from=build /app/publish .

# Listen on 8080 (matches internal_port in fly.toml).
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 8080

# .NET 8 performance tuning.
ENV DOTNET_EnableDiagnostics=0
ENV DOTNET_gcServer=1

# Run the web app (NOT the .Core class library).
ENTRYPOINT ["dotnet", "Form.Ambulancias247.dll"]
