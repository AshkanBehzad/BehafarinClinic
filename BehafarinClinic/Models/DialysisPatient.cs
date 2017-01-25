using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class DialysisPatient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DialysisPatient()
        {
            this.DialysisSession = new HashSet<DialysisSession>();
        }

        public int PatientId { get; set; }
        public string RecepPesrsonnelCode { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        public Nullable<bool> MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string Education { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string AttendingPhysician { get; set; }
        public string GeneralCondition { get; set; }
        public string MentalCondition { get; set; }
        public string SmokingRecords { get; set; }
        public string ESRD { get; set; }
        public string ClinicalRecords { get; set; }
        public string VascularAccessDetails { get; set; }
        public string ViralMarkers { get; set; }
        public string Description { get; set; }

        public virtual InsuranceOrganization InsuranceOrganization { get; set; }
        public virtual Personal Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DialysisSession> DialysisSession { get; set; }
    }
}