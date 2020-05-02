using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Item")]
    public class Item{
        [Key]
        public int itemID { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public enum typeItem{
            weapon,
            food,
            tool
        } 
    }
}