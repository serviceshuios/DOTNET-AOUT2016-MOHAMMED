using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class AbonnementClient
    {
        [Key, Column(Order = 0)]
        public int AbonnementId { get; set; }
        [Key, Column(Order = 1)]
        public int UtilisateurId { get; set; }
        public DateTime DateDebut { get; set; }
       
        public DateTime DateFin { get; set; }
        public virtual Abonnement abonnement { get; set; }
        public virtual Client client { get; set; }
    }
}