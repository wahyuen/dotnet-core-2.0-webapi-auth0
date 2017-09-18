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

* Add the following NuGet packages:
  - MediatR
  - MediatR.Extensions.Microsoft.DependencyInjection
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools.DotNet
  
## Setting up EntityFramework and Database

* Add a ConnectionString node to appsettings.json

![](createproject.PNG)

* Create an object to represent an Application User

```cs
using System.ComponentModel.DataAnnotations.Schema;

namespace auth0api.Users
{
    public class ApplicationUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ExternalId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
```

* Create a database context object

```cs
using auth0api.Users;
using Microsoft.EntityFrameworkCore;

namespace auth0api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}

```

* Update Startup.cs::ConfigureServices() method

```cs
services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
```

### Setting up Database Migrations

## Setting up MediatR

## Setting up Auth0 and JWT Authentication
