using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Inventory")]
    public class Inventory{
        [Key]
        public int InventoryID { get; set; }
        public int PlayerID { get; set; }
        public int ItemCode { get; set; }
        public int Amount { get; set; }

        [ForeignKey("PlayerID")]
        public Player Player { get; set; }
    
    }
}