using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class EvaluationNurse
    {
        public int HEvaId { get; set; }
        public string PersonnelCode { get; set; }

        public virtual HourlyEvaluation HourlyEvaluation { get; set; }
        public virtual Personal Personal { get; set; }
    }
}