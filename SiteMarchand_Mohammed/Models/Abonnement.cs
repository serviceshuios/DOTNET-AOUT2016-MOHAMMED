using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class Abonnement
    {
        public int AbonnementId { get; set; }
        public string Nom { get; set; }
        public int Duree { get; set; }
        [Column("Prix", TypeName = "money")]
        public decimal Prix { get; set; }

        public virtual ICollection<AbonnementClient> abonnementClients { get; set; }
    }
}