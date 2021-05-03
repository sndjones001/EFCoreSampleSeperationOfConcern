using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestEFCoreDataAccess.DataAccess;

namespace TestEFCoreEFToolProvisionConsole
{
    /// <summary>
    /// This class is the most important class if you want to support EF Core tools
    /// in a console app during design time.
    /// </summary>
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PeopleContext>
    {
        public PeopleContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<PeopleContext>();

            var connectionString = configuration.GetConnectionString("Default");
            builder.UseMySQL(connectionString);

            return new PeopleContext(builder.Options);
        }
    }
}
