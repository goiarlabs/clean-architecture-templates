
# Clean Architecture Solution Templates

## Overview
This is set of templates for creating ASP.NET Core apis following a Clean Architecture structure.
Create a new project based on a chosen template between (basic, medium, advanced) by installing the associated command.

## Technologies 
- ASP.NET Core 5
- Swagger
- Moq
- XUnit

## Getting Started 

### Installing templates
 1. Install the latest  [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
 2. Run `dotnet new --install clean-architecture-templates/` 
 3. Run `dotnet new 'clean architecture' --list`. 

This will display all clean architecture templates available for you:
```bash 
These templates matched your input: 'clean architecture'.

Templates                  Short Name  Language  Tags   
-------------------------  ----------  --------  -------
Medium Clean Architecture  mca         [C#]      Web/Api
Basic Clean Architecture   bca         [C#]      Web/Api
```
4. Create a directory with the name of your project and cd into it or just add `-o MyOutputFolderName` in the next's commands below

### Basic template (bca)
1. Run `dotnet new bca -s MySolutionName -p MyProjectName`
2. Navigate to `src/MyProjectName` and run `dotnet run` to launch the project

The directory structure:

![alt text](https://github.com/goiarlabs/clean-architecture-templates/blob/main/media/01-basic-tree.png?raw=true)

### Medium template (mca)
1. Run `dotnet new mca -s MySolutionName -p MyProjectName`
2. Navigate to `src/MyProjectName.presentation` and run `dotnet run` to launch the project

The directory structure:

![alt text](https://github.com/goiarlabs/clean-architecture-templates/blob/main/media/02-medium-tree.png?raw=true)

