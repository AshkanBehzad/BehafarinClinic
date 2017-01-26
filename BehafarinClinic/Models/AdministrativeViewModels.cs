using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MentalHealthClinic.Models
{
    public class AddUserViewModel
    {
        public string FirstName { get; set; }


        public string LastName { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار گذرواژه")]
        [Compare("Password", ErrorMessage = "گذرواژه و تکرار گذرواژه یکسان نیستند.")]
        public string ConfirmPassword { get; set; }
    }
}