using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class InfirmaryPersonnel
    {
        [Key]
        public int IPersonnelId { get; set; }
        public string PersonnelCode { get; set; }
        [Display()]
        public string FirstName { get; set; }
        [Display()]
        public string LastName { get; set; }
        
        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
}