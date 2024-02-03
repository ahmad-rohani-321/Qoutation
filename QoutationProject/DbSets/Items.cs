using System.ComponentModel.DataAnnotations;

namespace QoutationProject.DbSets
{
    internal class Items
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; } = default!;
        public decimal PurchasePrice { get; set; }
        public decimal ProfitPercentage { get; set; }
        public decimal FinalPrice { get; set; }
        public decimal DollarPrice { get; set; }
        public decimal AfghaniPrice { get; set; }
        public decimal KaldarPrice { get; set; }
    }
}