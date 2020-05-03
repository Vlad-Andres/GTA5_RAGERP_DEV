using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Property")]
    public class Property{
        public int PropertyID { get; set; }
        public int OwnerID { get; set; }
        public virtual Player Owner { get; set; }
        
    }
}