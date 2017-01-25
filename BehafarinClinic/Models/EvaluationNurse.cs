using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class EvaluationNurse
    {
        [Key]
        public int HEvaId { get; set; }
        [StringLength(15,ErrorMessage ="")]
        public string PersonnelCode { get; set; }

        public virtual HourlyEvaluation HourlyEvaluation { get; set; }
        public virtual Personal Personal { get; set; }
    }
}