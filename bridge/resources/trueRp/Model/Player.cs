using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Player")]
    public class Player{
        public Player(){
            this.inventory = new Inventory();
        }

        [Key]
        public int playerID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public enum status{ 
            ordinary,
            admin
        }
        public double balance { get; set; }
        public int inventoryID { get; set; }
        
        public Inventory inventory { get; set; }
    }
}