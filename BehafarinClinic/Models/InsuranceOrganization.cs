using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class InsuranceOrganization
    {
        [Key]
        public int IOrgId { get; set; }
        public string OrganizationCode { get; set; }
        [Display()]
        public string OrganizationName { get; set; }
        [Display()]
        [Range(0,100,ErrorMessage = "")]
        public Nullable<int> Rate { get; set; }

        public virtual ICollection<DialysisPatient> DialysisPatient { get; set; }
    }
}