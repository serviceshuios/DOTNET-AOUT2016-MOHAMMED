using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteMarchand_ME.Models
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }

        public enum EnumCivilite { M, Mme, Mlle };
        [Required, Display(Name = "Civilité")]
        public EnumCivilite Civilite { get; set; }

        [Required(ErrorMessage = "Nom manquant"), Column("Name", TypeName = "varchar"), MinLength(2), MaxLength(50), Display(Name = "Nom")]//,StringLength(15)]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Prenom manquant"), Column("Firstname", TypeName = "varchar"), MinLength(2), MaxLength(50),Display(Name = "Prénom"),StringLength(20, MinimumLength = 5, ErrorMessage = "Le champ Prenom doit être compris entre 5 et 20 caractères")]
        public string Prenom { get; set; }

        [Required, Column("UserName", TypeName = "varchar"), MinLength(4), MaxLength(50), Display(Name = "Pseudo")]
        public string Pseudo { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Column("Password", TypeName = "varchar"), MinLength(6), MaxLength(50),Display(Name = "Mot de passe"),DataType(DataType.Password)]//ErrorMessage("Le mot de passe doit être composé de 6 caractères minimum")]
        public string Password { get; set; }

        [Display(Name = "Confirmez votre mot de passe")]
        [Compare("Password", ErrorMessage = "Le mot de passe n'est pas identique")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<HistoriqueUtilisateurProduit> historiquesUtilisateurProduit { get; set; }

        public int Role { get; set; }

        //public virtual Catalogue catalogue { get; set; }
    }
}