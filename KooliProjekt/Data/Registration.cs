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
        public int CustomerId { get; set; }
        [Required]
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}
