using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class HourlyEvaluation
    {
        public int HEvalId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<double> BloodPresure { get; set; }
        public string SideEffect { get; set; }
        public string MedicalAction { get; set; }
        public string EvaluationTime { get; set; }

        public virtual DialysisSession DialysisSession { get; set; }
        public virtual EvaluationNurse EvaluationNurse { get; set; }
    }
}