using System.ComponentModel.DataAnnotations;

namespace HomeHarbor1.Models
{
    public class Registration
    {
        [Key]
        public int Reg_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email_Id { get; set; }


        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("Password", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //public string Password { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public long Phn_No { get; set; }
        public string Role { get; }
    }
}
