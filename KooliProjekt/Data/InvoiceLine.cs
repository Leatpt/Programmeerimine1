using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class InvoiceLine
    {
        [Required]
        public int Id {  get; set; }
        [Required]
        [StringLength(255)]
        public string LineItem { get; set; }
        [Required]
        [StringLength(7)]
        public decimal Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public decimal VatRate { get; set; }
        public decimal Discount { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
