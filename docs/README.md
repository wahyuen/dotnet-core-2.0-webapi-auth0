# ASP.NET Core 2.0 WebAPI integrated with Auth0

This seed project has been created to assist in setting up a new ASP .Net Core 2.0 WebAPI project. The following features have been implemented as part of this guide:

- initial project structure created from dotnet cli webapi template
- integration to accept authentication from Auth0 using JWT tokens
- integration to a SQL database using Entity Framework Core 2.0
- example of anonymous and authorized endpoints
- setup of Mediatr library
- guide to setup VSTS build/deploy pipeline with DB Migrations

The following sections describe 'how' this solution was created. If you intend on using it, simply clone the repo, updating your namespace and insert your Auth0 credentials and off you go!

## Initial Setup

* This can be performed using the dotnet-cli commands, however, it was simply easier given I have the Visual Studio template which has the added bonus of setting up the Solution file too!

  ![](createproject.PNG)
  
  ![](createprojectwebapi.PNG)

* Add the following NuGet packages
 - MediatR
 - MediatR.Extensions.Microsoft.DependencyInjection
 - Microsoft.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.SqlServer
 - Microsoft.EntityFrameworkCore.Tools.DotNet
  
## Setting up EntityFramework and Database

### Setting up Database Migrations

## Setting up MediatR

## Setting up Auth0 and JWT Authentication
