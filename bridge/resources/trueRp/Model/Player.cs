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

        public Player(string Username, string Password, string Email) : this(){
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Balance = 2000;
        }

        [Key]
        public int PlayerID { get; set; }
        
        public int InventoryID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Types.PlayerStatus Status { get; set; }
        public double Balance { get; set; }
        public int JobId { get; set; }

       
        [ForeignKey("InventoryID")]
        public Inventory Inventory { get; set; }
        
        [ForeignKey("JobId")]
        public Job Job { get; set; }
    }
}