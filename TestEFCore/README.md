# Introduction

This sample project describes how to setup a basic ASP.NET Core EF Project.

## Description

Create a ASP.NET Core project without any EF support. For Seperation of Concern (SoC) we will seperate the EF logic, libraries setup from the web UI project.
Since EF tools execution is a design level concept.

Now Create a seperate Class library with .NET Standard for Data Access.
Add nuget package Microsoft.EntityFrameworkCore
[We have used the 3.1.* version in the project with .NET Core 3. Curently the MySQL.MicrosoftEntityFrameworkCore nuget does not
work with .NET Core 5. This is a known bug.]
Add the Model classes which represents your tables in the database as per EF standard.
Add a DbContext class to create the database.

Now create a seperate console application .NET Core.
Add nuget package MySQL.MicrosoftEntityFrameworkCore.
Add a class derived from IDesignTimeDbContextFactory (This is the main point of how EF can be used in a project by seperating the UI logic from the direct DB access.)

Now in the parent Solution folder use the following command line to create migration:

dotnet ef --project TestEFCoreDataAccess --startup-project TestEFCoreEFToolProvisionConsole migrations add InitializeDBCreation
