using System.ComponentModel.DataAnnotations;

namespace Horizon.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Enter your Id!")]
        public int Id                { get; set; }

        [Required (ErrorMessage ="Enter your name!")]
        public string Name           { get; set; }

        [Required(ErrorMessage = "Enter your address!")]
        public string Address        { get; set; }

        [Required(ErrorMessage = "Enter your city!")]
        public string City           { get; set; }

        public string Region         { get; set; }

        [Required(ErrorMessage = "Enter your zip!")]
        public string Zip            { get; set; }

        [Required(ErrorMessage = "Enter your country!")]
        public string Country        { get; set; }

        [Required(ErrorMessage = "Enter your phone!")]
        public string Phone          { get; set; }

        [Required(ErrorMessage = "Enter your email!")]
        [EmailAddress]
        public string Email          { get; set; }

        [Required(ErrorMessage = "Enter your password!")]
        public string Password       { get; set; }
    }
}
