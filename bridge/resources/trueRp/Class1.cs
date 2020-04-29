using System;
using GTANetworkAPI;
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
                    Console.WriteLine("Hello Success!" + dbContext.testMemoryCon());
                }
                //using var con = new SQLiteConnection(conString);
                //con.Open();
                
            }catch (BadImageFormatException ex){
                Console.WriteLine(ex.Message + " " + ex.Source);
            }
           

            
        }
    }
}
