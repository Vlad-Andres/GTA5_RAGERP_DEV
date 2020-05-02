using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Inventory")]
    public class Inventory{
        [Key]
        public int inventoryID { get; set; }
        public int playerID { get; set; }
        public int itemID { get; set; }
        public int count { get; set; }
    
    }
}