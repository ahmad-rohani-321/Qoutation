using System.ComponentModel.DataAnnotations;

namespace QoutationProject.DbSets
{
    internal class CurrencyPrice
    {
        [Key]
        public int Id { get; set; }
        public decimal AghaniPrice { get; set; }
        public decimal KaldarPrice { get; set; }
        public DateOnly Date { get; set; }
    }
}