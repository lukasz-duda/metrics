FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Sales.csproj", "./"]
RUN dotnet restore "Sales.csproj"
COPY . .
RUN dotnet build "Sales.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sales.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sales.dll"]