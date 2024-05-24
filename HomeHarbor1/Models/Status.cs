using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Status
    {
        [Key]
        public int Status_Id { get; set; }
        public int Booking_Id { get; set; }
        //[ForeignKey("Booking_Id")]
        //public Booking Booking { get; set; }


        [Required]
        public string Description { get; set; }
    }
}
