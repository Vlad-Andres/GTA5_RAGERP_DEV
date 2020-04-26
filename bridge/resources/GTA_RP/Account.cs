

using System.ComponentModel.DataAnnotations;

namespace GTA_RP {
    public class Account {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}