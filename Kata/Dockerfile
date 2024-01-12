FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Kata/Kata.csproj", "Kata/"]
RUN dotnet restore "Kata/Kata.csproj"
COPY . .
WORKDIR "/src/Kata"
RUN dotnet build "Kata.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kata.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kata.dll"]
