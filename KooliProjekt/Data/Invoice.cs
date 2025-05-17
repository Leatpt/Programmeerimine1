using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Invoice
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]
        public string InvoiceNo { get; set; }
        [Required]
        public DateTime? InvoiceDate { get; set; }
        [Required]
        public decimal SubTotal { get; set; }
        [Required]
        public decimal GrandTotal { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [DisplayName("Customer")]
        public int CustomerId { get; set; }
        [Required]
        public Event Event { get; set; }
        [DisplayName("Event")]
        public int EventId { get; set; }
        public IList<InvoiceLine> Lines { get; set; }

        public Invoice()
        {
            Lines = new List<InvoiceLine>();
        }

    }
}
