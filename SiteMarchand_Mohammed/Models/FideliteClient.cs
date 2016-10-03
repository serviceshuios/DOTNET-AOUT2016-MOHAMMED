using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class FideliteClient
    {
        [Key, Column(Order = 0)]
        public int FideliteId { get; set; }
        [Key, Column(Order = 1)]
        public int UtilisateurId { get; set; }

        public virtual Fidelite fidelite { get; set; }
        public virtual Client client { get; set; }
    }
}