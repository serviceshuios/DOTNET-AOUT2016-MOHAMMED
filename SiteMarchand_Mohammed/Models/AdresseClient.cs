using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class AdresseClient
    {
        [Key, Column(Order = 0)]
        public int AdresseId { get; set; }
        [Key, Column(Order = 1)]
        public int UtilisateurId { get; set; }

        public virtual Adresse adresse { get; set; }
        public virtual Client client { get; set; }
    }
}