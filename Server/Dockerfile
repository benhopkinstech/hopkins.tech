FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Server/hopkins.tech.Server.csproj", "Server/"]
COPY ["Client/hopkins.tech.Client.csproj", "Client/"]
COPY ["Shared/hopkins.tech.Shared.csproj", "Shared/"]
RUN dotnet restore "Server/hopkins.tech.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "hopkins.tech.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hopkins.tech.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "hopkins.tech.Server.dll"]