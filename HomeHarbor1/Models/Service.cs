using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Service
    {
        [Key]
        public int Service_Id { get; set; }
        [Required]
        public string Service_Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
