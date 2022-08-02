FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Post.sln ./
COPY /BL/*.csproj ./BL/
COPY /DL/*.csproj ./DL/
COPY /Models/*.csproj ./Models/
COPY /Tests/*.csproj ./Tests/
COPY /WebAPI/*.csproj ./WebAPI/


RUN dotnet restore
COPY . .

WORKDIR /src/BL
RUN dotnet build -c release -o /app

WORKDIR /src/DL
RUN dotnet build -c release -o /app

WORKDIR /src/Models
RUN dotnet build -c release -o /app

WORKDIR /src/Tests
RUN dotnet build -c release -o /app

WORKDIR /src/WebAPI
RUN dotnet build -c release -o /app

WORKDIR /src
RUN dotnet publish -c release -o /app

COPY /WebAPI/appsettings.json /app

FROM final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "WebAPI.dll"]

EXPOSE 80