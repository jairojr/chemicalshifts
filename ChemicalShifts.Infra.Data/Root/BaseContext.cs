using ChemicalShifts.Domain.Entities;
using ChemicalShifts.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemicalShifts.Infra.Data.Root
{
    public class BaseContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public BaseContext() : base()
        {
            Database.EnsureCreated();
        }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserConfig().Configure);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(c => c.Entity.GetType().GetProperty("Created") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = DateTime.Now;
                }
                else
                {
                    entry.Property("Created").IsModified = false;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Altered").CurrentValue = DateTime.Now;
                }
                else
                {
                    entry.Property("Altered").IsModified = false;
                }
            }

            return base.SaveChanges();
        }


    }
}
