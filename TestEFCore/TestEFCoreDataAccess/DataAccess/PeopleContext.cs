using System;
using Microsoft.EntityFrameworkCore;
using TestEFCoreDataAccess.Models;

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
            modelBuilder.Entity<Address>()
                .Property(a => a.ZipCode).HasColumnType("varchar(10)");
        }
        #endregion
    }
}
