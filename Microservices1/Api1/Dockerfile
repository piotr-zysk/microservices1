FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /src

COPY . .
RUN dotnet restore "./Api1/Api1.csproj"
RUN dotnet publish "./Api1/Api1.csproj" -c Release -o out  --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /src/out .
EXPOSE 443
EXPOSE 80
ENTRYPOINT ["dotnet", "Api1.dll"]
