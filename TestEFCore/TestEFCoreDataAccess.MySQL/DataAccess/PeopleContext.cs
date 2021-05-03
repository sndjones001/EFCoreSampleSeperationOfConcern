using System;
using Microsoft.EntityFrameworkCore;
using TestEFCoreDataAccessBase.Models;

namespace TestEFCoreDataAccess.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // My Database is MySQL which is created by default with
            // Charset: utf8mb4
            // Collation: utf8mb4_0900_ai_ci
            // So the data type of text column is default 'varchar' and not 'nvarchar'
            // Hence the below chnage will not have any affect on migration.
            modelBuilder.Entity<Address>()
                .Property(a => a.ZipCode).HasColumnType("varchar(10)");
        }
        #endregion
    }
}
