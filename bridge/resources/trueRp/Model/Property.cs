using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace trueRp.Model{
    [Table("Property")]
    public class Property{
        public int propertyID { get; set; }
        public int ownerID { get; set; }
        public virtual Player owner { get; set; }
        
    }
}