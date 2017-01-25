using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class Personal
    {
        [Key]
        public string PersonalCode { get; set; }
        [Display()]
        public string FiratName { get; set; }
        [Display()]
        public string LastName { get; set; }
        [Display()]
        public string Type { get; set; }

        public virtual ICollection<DialysisPatient> DialysisPatient { get; set; }
        public virtual ICollection<DialysisSession> DialysisSession { get; set; }
        public virtual ICollection<DialysisSession> DialysisSession1 { get; set; }
        public virtual ICollection<EvaluationNurse> EvaluationNurse { get; set; }
        public virtual ICollection<InfirmaryReception> InfirmaryReception { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}