# EFCore-Azure
Handled data by CRUD operations on SQL Azure with EnrityFrameworkCore
## Prerequisites
- [.NET Core SDK](https://www.microsoft.com/net/download/core) installed in your environnement
- VS studio 2019
- Cmder, is optional, instead, you can use the Package Manager Console `Vs studio: Tools > NuGet Package Manager > Package Manager Console`
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
