using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class AnniversaireClient
    {
        [Key, Column(Order = 0)]
        public int AnniversaireId { get; set; }
        [Key, Column(Order = 1)]
        public int UtilisateurId { get; set; }

        public virtual Anniversaire anniversaire { get; set; }
        public virtual Client client { get; set; }
    }
}