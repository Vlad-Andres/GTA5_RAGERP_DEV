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
            try{
                using (var dbContext = new DefaultDbContext())
                {
                    int count = dbContext.Players.Count();
                    //Console.WriteLine("Connection " + dbContext.testMemoryCon()); // WARN this closes the connection so err if uncoment
                    Console.WriteLine("Players count = " + count);
                    if (count > 0){
                        Model.Player player = dbContext.Players.OrderBy(p => p.PlayerID).First();
                        Console.WriteLine("First player: " + player.Username + " | " + player.Status);
                    }
                }
                //using var con = new SQLiteConnection(conString);
                //con.Open();
                
            }catch (BadImageFormatException ex){
                Console.WriteLine(ex.Message + " " + ex.Source);
            }
        }

        //Moved in Controller.Login.OnPlayerLoginAttempt

        // [RemoteEvent("OnPlayerLoginAttempt")] // triggered in Login/Main.js 
        // public void OnPlayerLoginAttempt(Client player, string username, string password){
        //     NAPI.Util.ConsoleOutput($"[Login Attempt] Username {username} | Password: {password}");

        //     if(username == "Vlad" && password == "123"){
        //             player.TriggerEvent("LoginResult", 1);
        //     }
        //     else player.TriggerEvent("LoginResult", 0);
        // }










        // [Command("login")]
        // public void Login(Client player){
        //     NAPI.ClientEvent.TriggerClientEvent(player, "showLoginBrowser");
        //     //player.call('showLoginBrowser', [player]);
        // }
    } 
}
