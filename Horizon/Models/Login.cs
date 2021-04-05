﻿using System.ComponentModel.DataAnnotations;
namespace Horizon.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }







    }
}
