namespace SiteMarchand_ME.Models
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public int Remise { get; set; }
        public int ProduitId { get; set; }
        public virtual Produit produit { get; set; }
    }
}