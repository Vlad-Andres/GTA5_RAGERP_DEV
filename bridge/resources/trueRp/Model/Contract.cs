using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace trueRp.Model{
    [Table("Contract")]
    public class Contract{
        [Key]
        public int contractID { get; set; }
        public enum typeContract{
            Buy,
            Sell
        }
        [Column(TypeName="Date")]
        public DateTime date { get; set; }
        public int playerID { get; set; }
        public int propertyID { get; set; }

        public Player player { get; set; }
        public Property property { get; set; }
        
    }
}