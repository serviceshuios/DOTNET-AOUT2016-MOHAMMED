namespace SiteMarchand_ME.Models
{
    public class MoyenPaiement
    {
        public int MoyenPaiementId { get; set; }
        public enum TypePaiement { Cheque, CarteBancaire, Facture, Virement };
        public TypePaiement typePaiement { get; set; }

        public int UtilisateurId { get; set; }
        public virtual Client client { get; set; }
    }
}