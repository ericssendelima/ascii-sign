# Estágio de Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
# Copia o projeto e restaura
COPY ["AsciiSignBlazor.csproj", "./"]
RUN dotnet restore "AsciiSignBlazor.csproj"
# Copia todo o resto da pasta do exemplo
COPY . .
RUN dotnet publish "AsciiSignBlazor.csproj" -c Release -o /app/publish

# Estágio Final
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "AsciiSignBlazor.dll"]