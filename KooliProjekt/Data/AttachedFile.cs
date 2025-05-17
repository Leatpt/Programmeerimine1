using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class AttachedFile
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        [Required]
        [DisplayName("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
