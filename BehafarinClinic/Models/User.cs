using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [Display()]
        public string Username { get; set; }
        [Display()]
        public string Password { get; set; }
        [Display()]
        public string Email { get; set; }
        [Display()]
        public string SecurityQuestion { get; set; }
        [Display()]
        public string SecurotyAnswer { get; set; }
        [Display()]
        public string PersonnelCode { get; set; }

        public virtual Personal Personal { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}