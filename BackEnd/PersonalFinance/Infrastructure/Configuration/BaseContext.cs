using Entities.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class BaseContext : IdentityDbContext<ApplicationUser>
    {
        public BaseContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<FinancialSystem> FinancialSystem { get; set; }
        public DbSet<FinancialSystemUser> FinancialSystemUser { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Expense> Expense { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer(ObterConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
           
            base.OnModelCreating(builder);
        }

        public string ObterConnectionString()
        {
            return "";
        }


    }
}
