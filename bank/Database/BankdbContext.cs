using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bank.Entities;
using Microsoft.EntityFrameworkCore;
namespace bank.Database
{
    public class BankdbContext:DbContext
    {
        public DbSet<Branch> Branch { get; set; }
        public DbSet<admin> admin { get; set; }
        public DbSet<Customer> Customer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"my connection string");
        }
    }
}
