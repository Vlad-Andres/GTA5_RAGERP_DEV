using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Player")]
    public class Player{
        public Player(){
            this.Inventory = new Inventory();
            this.Job = new Job();
        }

        [Key]
        public int PlayerID { get; set; }
        
        public int InventoryID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public Types.PlayerStatus Status { get; set; }
        public double Balance { get; set; }
        public int JobId { get; set; }

       
        [ForeignKey("InventoryID")]
        public Inventory Inventory { get; set; }
        
        [ForeignKey("JobId")]
        public Job Job { get; set; }
    }
}