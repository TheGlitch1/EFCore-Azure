# EFCore-Azure
Handled data by CRUD operations on SQL Azure with EnrityFrameworkCore
## Prerequisites
  - [.NET Core SDK](https://www.microsoft.com/net/download/core) installed in your environnement
  - VS studio 2019
  - Azure account
  - Cmder, is optional, instead, you can use the Package Manager Console `Vs studio: Tools > NuGet Package Manager > Package  Manager Console`
## Create your console project
  Some commands are:
  ```
  dotnet new console -o EFCoreTuto
  cd EFCoreTuto
  ```
  after this commands your console application will be created succeeded

## Install EntityFramework Core
  To Install EF Core, you install the package for the EF Core database provider you want to target. This tutorial use SqlServer.

  `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
  - You can indicate a specific version in the `dotnet add package` command, using the -v modifier. 
## Add your model and config the DbContext object. 
  See
  - [EFCoreTuto/Models/Tag.cs](./Models/Tag.cs)
  - [EFCoreTuto/Models/Attributes.cs](./Models/Attributes.cs)
 ## Get server connection information
  Get the connection information you need to connect to the database in Azure SQL Database you will need the server name, 
  [how create a SQL Server in Azure](https://docs.microsoft.com/en-us/azure/azure-sql/database/single-database-manage).
 
  - **Get ADO.NET connection information from sql Azure:** Once you log in to your azure account, navigate to the database you want to use, under **Setting**, select **Connection strings**. Copy the **ADO.NET (authentification SQL)** connection string
  - **Config your DbContext:** Override a virtual method `OnConfiguring()` from DbContext see [EFCoreTuto/EFCoreContext.cs](./EFCoreContext.cs).
        Check if your database is availabe and can be connected to, use `dotnet run` command to start your console. Befor you need to add same test in your class program.
		you need to allow access your client address IP to open connection, in overview database azure page, **set server firewall**, **Add client IP**.
    
  ## Migrations
	
  The migrations features in EF Core provide a way to incrementally update the database schema to keep it in sync with the application data model while preserving existing data in the database.
	Migration inclides command-line tools, see bellow same commande-line to generate your first migration.
	
  > If using EF Core 3.x you must be installed `dotnet ef` commande-line as a global or local tool. Most developers will install `dotnet ef` as a global
	
		`dotnet tool install --global dotnet-ef`
		`dotnet add package Microsoft.EntityFrameworkCore.Design`
		`dotnet ef migrations add InitialCreate`
		`dotnet ef database update`
		
		
		
	
	


  
  
  
  
  
 
  
  
 
 
 
