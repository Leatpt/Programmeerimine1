using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Event
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public int MaxParticipants { get; set; }
        public decimal? Price { get; set; }
        [Required]
        [StringLength(1000)]
        public string Schedule {  get; set; }
        [StringLength(2000)]
        public string? Summary { get; set; }
        public List<AttachedFile>? AttachedFiles { get; set; } 
        public bool IsPaidEvent { get; set; }

    }
}
