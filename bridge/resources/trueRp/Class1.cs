using System;
using GTANetworkAPI;
using System.Linq;
//using System.Data.SQLite;

namespace trueRp
{
    public class Class1 : Script
    {
       public Class1()
        {
            string conString = "Data Source=:memory:";
            try{
                using (var dbContext = new DefaultDbContext())
                {
                    //Console.WriteLine("Connection " + dbContext.testMemoryCon()); // WARN this closes the connection so err if uncoment
                    Console.WriteLine("Players count = " + dbContext.Players.Count());
                    Player player = dbContext.Players.OrderBy(p => p.ID).First();
                    Console.WriteLine("First player: " + player.username + " | " + player.status);
                }
                //using var con = new SQLiteConnection(conString);
                //con.Open();
                
            }catch (BadImageFormatException ex){
                Console.WriteLine(ex.Message + " " + ex.Source);
            }
           

            
        }
    }
}
