#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CursoDotNet2/CursoDotNet2.csproj", "CursoDotNet2/"]
RUN dotnet restore "CursoDotNet2/CursoDotNet2.csproj"
COPY . .
WORKDIR "/src/CursoDotNet2"
RUN dotnet build "CursoDotNet2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CursoDotNet2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CursoDotNet2.dll"]