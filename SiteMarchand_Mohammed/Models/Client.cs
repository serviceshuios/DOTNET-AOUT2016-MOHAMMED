using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiteMarchand_ME.Models
{
    public class Client : Utilisateur
    {
        [Display(Name = "Né(e) le"),
         Required(ErrorMessage = "Le champ « date de naissance » est obligatoire"),
         DataType(DataType.Date),
         DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateNaissance { get; set; }

        public bool Actif { get; set; }
        public int? NumeroCarteFidelite { get; set; }
        public int NombrePoints { get; set; }
        public bool CompteASupprimer { get; set; }

        public virtual ICollection<Commande> commandes { get; set; }

        public virtual ICollection<FideliteClient> clientFidelités { get; set; }
        public virtual ICollection<AvisClientProduit> avisClientProduit { get; set; }
        public virtual ICollection<AnniversaireClient> clientAnniversaires { get; set; }
        public virtual ICollection<AdresseClient> clientAdresses { get; set; }
        public virtual ICollection<AbonnementClient> clientAbonnements { get; set; }
        public virtual ICollection<MoyenPaiement> moyenPaiements { get; set; }
    }
}