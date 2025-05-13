using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Payment
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        [StringLength(100)]
        public string Method { get; set; }
        public Invoice Invoice { get; set; }
    }
}
