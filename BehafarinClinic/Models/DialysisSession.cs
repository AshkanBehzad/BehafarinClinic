using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class DialysisSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DialysisSession()
        {
            this.ConsummedGoodsItem = new HashSet<ConsummedGoodsItem>();
            this.HourlyEvaluation = new HashSet<HourlyEvaluation>();
        }

        public int SessionId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> SessionDate { get; set; }
        public string Doc_PersonalCode { get; set; }
        public string Rec_PersonalCode { get; set; }
        public string Diagnosis { get; set; }
        public Nullable<double> WeightBD { get; set; }
        public Nullable<double> BloodPresureBD { get; set; }
        public Nullable<double> TempratureBD { get; set; }
        public Nullable<double> PulseRateBD { get; set; }
        public Nullable<double> BreathingRateBD { get; set; }
        public Nullable<double> WeightAD { get; set; }
        public Nullable<double> BloodPresureAD { get; set; }
        public Nullable<double> TempratureAD { get; set; }
        public Nullable<double> PulseRateAD { get; set; }
        public Nullable<double> BreathingRateAD { get; set; }
        public string VascularAccessDetainls { get; set; }
        public string DialysisMachineDetails { get; set; }
        public string DialyzerType { get; set; }
        public Nullable<double> DryWeight { get; set; }
        public Nullable<double> BloodFlow { get; set; }
        public string DialysateFlow { get; set; }
        public string BufferType { get; set; }
        public string TMP { get; set; }
        public Nullable<double> DialysateTeperature { get; set; }
        public string ViralMarkers { get; set; }
        public Nullable<double> SodiumCon { get; set; }
        public Nullable<double> ArterialPressure { get; set; }
        public Nullable<double> VenousPressure { get; set; }
        public string Profile { get; set; }
        public string DoctorNotes { get; set; }
        public string NurseObservation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsummedGoodsItem> ConsummedGoodsItem { get; set; }
        public virtual DialysisPatient DialysisPatient { get; set; }
        public virtual Personal Personal { get; set; }
        public virtual Personal Personal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HourlyEvaluation> HourlyEvaluation { get; set; }
    }
}