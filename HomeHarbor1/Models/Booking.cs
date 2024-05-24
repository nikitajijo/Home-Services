﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }

        public int Service_Id { get; set; }
        //[ForeignKey("Service_Id")]
        //public Service Service { get; set; }


        public int Reg_Id { get; set; }
        //[ForeignKey("Reg_Id")]
        //public Registration Registration { get; set; }


        public int Slot_Id { get; set; }
        //[ForeignKey("Slot_Id")]
        //public Slot Slot { get; set; }


        [Required]
        public DateTime Booking_Date { get; set; }
        public DateTime Booked_Date { get; set; }
    }
}
