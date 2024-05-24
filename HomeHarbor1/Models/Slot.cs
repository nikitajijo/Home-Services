using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Slot
    {
        [Key]
        public int Slot_Id { get; set; }

        [Required]
        public string Time { get; set; }
    }
}
