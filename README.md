# dotnet stack

## Clients

### DotnetStack.Api

Communication point to the backend

- Fluent validation

### DotnetStack.App

- React w/ typescript

### DotnetStack.BackgroundProcesses

- Hangfire implemented to run scheduled processes
- Topshelf

## Business Logic

### DotnetStack.Engines

Used for smaller, reusable chunks of business logic

### DotnetStack.Managers

Used for larger, higher level workflows

## Data Access

Used for data access

### DotnetStack.DataAccessHandlers

- RestSharp is implemented for 3rd party api calls

### DotnetStack.IntegrationHandlers

- EntityFramework is implemented for data storage

## Core

### DotnetStack.Core

Base types that will be used throughout the platform

### DotnetStack.Utilities

Pure, global functions that don't belong in any other layer

# Getting Started

## Naming

Find and replace all references of `DotnetStack` with the name of your project, including file names, project names, and any class names or variables.

## Setup Database & Run Migrations

First pull the SQL Server image

```bash
docker pull mcr.microsoft.com/mssql/server
```

Then startup the SQL Server

```bash
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Str0ngPa$$w0rd' -p 1433:1433 -d mcr.microsoft.com/mssql/server
```

You can verify it started up correctly by running

```bash
docker container ls
```

```
dotnet tool install --global dotnet-ef
```

```
dotnet ef database update --project .\DotnetStack.DataAccessHandlers\ --startup-project .\DotnetStack.Api\
```

> When using the `ef` tools, because of how DI was set up, you'll need to specify both a project and a startup project

## Adding Migrations

As you make changes to the DB, you can add additional migrations by running the following, specifying a `<MigrationName>`

```
dotnet ef migrations add <MigrationName> --project .\DotnetStack.DataAccessHandlers\ --startup-project .\DotnetStack.Api\
```
