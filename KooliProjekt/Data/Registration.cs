using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Registration
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public bool IsPaidEvent { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [DisplayName("Customer")]
        public int CustomerId { get; set; }
        [Required]
        public Event Event { get; set; }
        [DisplayName("Event")]
        public int EventId { get; set; }
    }
}
