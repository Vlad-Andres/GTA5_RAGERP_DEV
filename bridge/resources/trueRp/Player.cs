using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp{
    [Table("Player")]
    public class Player{

        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string status { get; set; }
    }
}