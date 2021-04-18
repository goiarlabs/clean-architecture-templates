# Clean Architecture Solution Templates

## Overview
This is set of templates for creating ASP.NET Core apis following a Clean Architecture structure.
Create a new project based on a chosen template between (basic, medium, advance) by installing the associated command.

## Technologies 
- ASP.NET Core 5
- Swagger
- XUnit

## Getting Started 

 1. Install the latest  [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
 2. Run `dotnet new --install clean-architecture-templates/01-basic`
 3. Create a directory with the name of your project and cd into it or just add `-o MyOutputFolderName` in the next command below
 4. Run `dotnet new bca -s MySolutionName -p MyDefaultProjectName`
 5. Navigate to `src/MyDefaultProjectName` and run `dotnet run` to launch the project

The result of 01-basic template will create the next directory structure:

    ├── MySolutionName.sln
    ├── src
    │   └── MyDefaultProjectName
    │       ├── appsettings.Development.json
    │       ├── appsettings.json
    │       ├── Controllers
    │       │   └── WeatherForecastController.cs
    │       ├── MyDefaultProjectName.csproj
    │       ├── Program.cs
    │       ├── Properties
    │       │   └── launchSettings.json
    │       ├── Startup.cs
    │       └── WeatherForecast.cs
    └── tests
        └── MyDefaultProjectName.tests
            ├── MyDefaultProjectName.tests.csproj
            └── UnitTest1.cs
    
    6 directories, 11 files



