FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY Controllers ./
COPY Properties ./
COPY appsettings.json ./
COPY Program.cs ./

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0

ARG GIT_SHA
ENV GIT_SHA=${GIT_SHA}

WORKDIR /app

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "gitops-example-app.dll"]
