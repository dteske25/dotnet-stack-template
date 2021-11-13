# dotnet stack

A standard n-tier web stack based off a traditional .NET server and React frontend

## Web

Front-end and slim controllers to communicate with the backend



## Managers


## Engines


## Handlers





# Clients
DotnetStack.Api
Communication point to the backend
- Fluent validation

DotnetStack.App
- React w/ typescript

DotnetStack.BackgroundProcesses
- Hangfire implemented to run scheduled processes
- Topshelf

# Business Logic
DotnetStack.Engines
Used for smaller, reusable chunks of business logic

DotnetStack.Managers
Used for larger, higher level workflows

# Data Access
DotnetStack.Handlers

Used for data access

- RestSharp is implemented for 3rd party api calls
- EntityFramework is implemented for data storage

# Core
DotnetStack.Core
Base types that will be used throughout the platform


DotnetStack.Utilities
Pure, global functions that don't belong in any other layer
