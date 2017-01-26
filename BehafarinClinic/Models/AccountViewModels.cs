using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BehafarinClinic.Models
{
    
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "نام کاربری")]
        
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [Display(Name = "مرا به یاد داشته باش")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]

        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Required]

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Required]

        [Display(Name = "عنوان")]
        public Gender Gender { get; set; }
        [Required]
        
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

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
    public class CreateViewModel
    {
        [Required]

        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [Required]

        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Required]

        [Display(Name = "عنوان")]
        public Gender Gender { get; set; }
        [Required]

        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        //TODO: Role


    }

    public class ResetPasswordViewModel
    {
        [Required]
        
        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار گذرواژه")]
        [Compare("Password", ErrorMessage = "گذرواژه و تکرار گذرواژه یکسان نیستند.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

   
}
