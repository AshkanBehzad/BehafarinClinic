using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class DialysisPatient
    {
        public int PatientId { get; set; }
        public string RecepPesrsonnelCode { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        [Display()]
        public string FirstName { get; set; }
        [Display()]
        public string LastName { get; set; }
        [Display()]
        public string FatherName { get; set; }
        [Display()]
        public Nullable<System.DateTime> BirthDate { get; set; }
        [Display()]
        public string Gender { get; set; }
        [Display()]
        public Nullable<System.DateTime> AdmissionDate { get; set; }
        [Display()]
        public Nullable<bool> MaritalStatus { get; set; }
        [Display()]
        public string Occupation { get; set; }
        [Display()]
        public string Education { get; set; }
        [Display()]
        public string Address { get; set; }
        [Display()]
        [StringLength(10,ErrorMessage ="")]
        public string Tel { get; set; }
        [Display()]
        public string AttendingPhysician { get; set; }
        [Display()]
        public string GeneralCondition { get; set; }
        [Display()]
        public string MentalCondition { get; set; }
        [Display()]
        public string SmokingRecords { get; set; }
        [Display()]
        public string ESRD { get; set; }
        [Display()]
        public string ClinicalRecords { get; set; }
        [Display()]
        public string VascularAccessDetails { get; set; }
        [Display()]
        public string ViralMarkers { get; set; }
        [Display()]
        public string Description { get; set; }

        public virtual InsuranceOrganization InsuranceOrganization { get; set; }
        public virtual Personal Personal { get; set; }

        public virtual ICollection<DialysisSession> DialysisSession { get; set; }
    }
}