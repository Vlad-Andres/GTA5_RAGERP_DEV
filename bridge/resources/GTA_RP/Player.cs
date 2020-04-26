using GTANetworkAPI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace GTA_RP {
    public class Player {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public Vector3 SpawnLocation { get; set; }
    }
}
