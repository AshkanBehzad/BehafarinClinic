using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class DialysisSession
    {
        [Key]
        public int SessionId { get; set; }
        public Nullable<int> PatientId { get; set; }
        [Display()]
        public Nullable<System.DateTime> SessionDate { get; set; }
        public string Doc_PersonalCode { get; set; }
        public string Rec_PersonalCode { get; set; }
        [Display()]
        public string Diagnosis { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> WeightBD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> BloodPresureBD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> TempratureBD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> PulseRateBD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> BreathingRateBD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> WeightAD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> BloodPresureAD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> TempratureAD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> PulseRateAD { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> BreathingRateAD { get; set; }
        [Display()]
        public string VascularAccessDetainls { get; set; }
        [Display()]
        public string DialysisMachineDetails { get; set; }
        [Display()]
        public string DialyzerType { get; set; }
        [Display()]
        [Range(0,9999,ErrorMessage = "")]
        public Nullable<double> DryWeight { get; set; }
        [Display()]
        public Nullable<double> BloodFlow { get; set; }
        [Display()]
        public string DialysateFlow { get; set; }
        [Display()]
        public string BufferType { get; set; }
        [Display()]
        public string TMP { get; set; }
        [Display()]
        public Nullable<double> DialysateTeperature { get; set; }
        [Display()]
        public string ViralMarkers { get; set; }
        [Display()]
        public Nullable<double> SodiumCon { get; set; }
        [Display()]
        public Nullable<double> ArterialPressure { get; set; }
        [Display()]
        public Nullable<double> VenousPressure { get; set; }
        [Display()]
        public string Profile { get; set; }
        [Display()]
        public string DoctorNotes { get; set; }
        [Display()]
        public string NurseObservation { get; set; }

        public virtual DialysisPatient DialysisPatient { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Personal Personal1 { get; set; }

        public virtual ICollection<ConsummedGoodsItem> ConsummedGoodsItem { get; set; }
        public virtual ICollection<HourlyEvaluation> HourlyEvaluation { get; set; }
    }
}