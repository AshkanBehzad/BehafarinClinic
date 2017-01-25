using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class HourlyEvaluation
    {
        [Key]
        public int HEvalId { get; set; }
        public Nullable<int> SessionId { get; set; }
        [Range(0, 9999, ErrorMessage = "")]
        [Display()]
        public Nullable<double> BloodPresure { get; set; }
        [Display()]
        public string SideEffect { get; set; }
        [Display()]
        public string MedicalAction { get; set; }
        [Display()]
        public string EvaluationTime { get; set; }

        public virtual DialysisSession DialysisSession { get; set; }
        public virtual EvaluationNurse EvaluationNurse { get; set; }
    }
}