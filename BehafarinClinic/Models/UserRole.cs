using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class UserRole
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}