FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebProject.API/WebProject.API.csproj", "WebProject.API/"]
RUN dotnet restore "WebProject.API/WebProject.API.csproj"
COPY . .
WORKDIR "/src/WebProject.API"
RUN dotnet build "WebProject.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebProject.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebProject.API.dll"]
