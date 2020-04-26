using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GTA_RP {
    public class DefaultDbContext : DbContext {

        private const string connectionString = "Server=localhost;Database=test;Uid=root;Pwd=";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(connectionString);
        }

        // Account model class created somewhere else 
        public DbSet<Account> Accounts { get; set; }
    }
}
