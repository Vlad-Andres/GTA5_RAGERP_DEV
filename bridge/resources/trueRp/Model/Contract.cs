using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace trueRp.Model{
    [Table("Contract")]
    public class Contract{
        [Key]
        public int ContractID { get; set; }
        public Types.ContractTypes TypeContract { get; set; }
        [Column(TypeName="Date")]
        public DateTime Date { get; set; }
        public int PlayerID { get; set; }
        public int PropertyID { get; set; }

        public Player Player { get; set; }
        public Property Property { get; set; }
        
    }
}