using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Model
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configura os ID como entities
            modelBuilder.Entity<Department>()
                .Property(s => s.Id)
                .UseIdentityByDefaultColumn();
            
            
            modelBuilder.Entity<Seller>()
                .Property(s => s.Id)
                .UseIdentityByDefaultColumn();
            
            
            modelBuilder.Entity<SalesRecord>()
                .Property(s => s.Id)
                .UseIdentityByDefaultColumn();
            
        }


    }
}
