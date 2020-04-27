using System;
using GTANetworkAPI;
using System.Data.SQLite;

namespace trueRp
{
    public class Class1 : Script
    {
       public Class1()
        {
            string conString = "DataSource=test.db";

            using var con = new SQLiteConnection(conString);

            con.Open();
            Console.WriteLine("Hello Success!");
        }
    }
}
