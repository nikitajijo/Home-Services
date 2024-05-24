using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Feedback
    {
        [Key]
        public int Feedback_Id { get; set; }
        [Required]

        public int Service_Id { get; set; }
        //[ForeignKey("Service_Id")]
        //public Service Service { get; set; }


        public int Reg_Id { get; set; }
        //[ForeignKey("Reg_Id")]
        //public Registration? Registration { get; set; }

        [Required]
        public string Comment { get; set; }
        public string Rating { get; set; }
        public DateTime Commented_Date { get; set; }
    }
}
