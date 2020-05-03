using Microsoft.EntityFrameworkCore; 
using System.Linq;
using GTANetworkAPI;

namespace trueRp.Controller
{
    public static class Login {

        public static Model.Player OnRegisterAttempt(string username, string password, string email){
            //TODO: process inputs
            return new Model.Player(username,password,email);
            //return false;
        }

        [RemoteEvent("OnPlayerLoginAttempt")]
        public static bool OnLoginAttempt(Client player, string username, string password, DbSet<Model.Player> players){
            return players.OrderBy(p => p.PlayerID)
                .Where(p => p.Password == password)
                .Count() >= 1 ? true : false; 
            
        }
    }
}