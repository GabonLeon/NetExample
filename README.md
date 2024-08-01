# Project NetExample

## .net 6 (login - register) + Swagger

## Step by step

### Install dotnet-ef (bila belum ada)

    dotnet tool install -g dotnet-ef --version 6.*

#### Install all packages (manual)

    dotnet clean
    dotnet restore

#### Info packages

    dotnet list package

#### Running

    dotnet run --project NetExample ( atau run Ctrl+F5 )

#### Swagger

    https://localhost:7488/swagger/index.html

##### json swagger OpenAPI specification

    https://localhost:7488/swagger/v1/swagger.json
