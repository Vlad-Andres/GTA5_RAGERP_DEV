using System; 
using System.Collections.Generic; 
using System.Reflection; 
using System.Text; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Design; 
using Microsoft.EntityFrameworkCore.Sqlite;

namespace trueRp
{
    public class DefaultDbContext : DbContext {

            // Connection string, more details below 
            private const string connectionString = @"Data Source=D:\GTA RP DEV\server\server-files\bridge\resources\trueRp\true-rp.db";

            // Initialize a new MySQL connection with the given connection parameters 
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite(connectionString);
            }

            public bool testMemoryCon(){
                
                return this.Database.CanConnect();
            }


            // Account model class created somewhere else 
            public DbSet<Player> Players { get; set; }
    }
}