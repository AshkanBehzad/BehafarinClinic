using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{

    #region  ConsumableGoods
    public partial class ConsumableGoods
    {
        [Key]
        public int GoodsId { get; set; }
        [Display()]
        public string Name { get; set; }
        [Display()]
        public string VendorOrProvider { get; set; }
        [Display()]
        public Nullable<int> Price { get; set; }
        [Display()]
        [Range(0, 9999)]
        public Nullable<int> AvalableQuantity { get; set; }
        [Display()]
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        [Display()]
        public string Description { get; set; }

        public virtual ICollection<ConsummedGoodsItem> ConsummedGoodsItem { get; set; }
    }
    #endregion

    #region  DialysisPatient
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
        [StringLength(10, ErrorMessage = "")]
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
    #endregion

    #region  DialysisSession
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
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> WeightBD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> BloodPresureBD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> TempratureBD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> PulseRateBD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> BreathingRateBD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> WeightAD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> BloodPresureAD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> TempratureAD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> PulseRateAD { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<double> BreathingRateAD { get; set; }
        [Display()]
        public string VascularAccessDetainls { get; set; }
        [Display()]
        public string DialysisMachineDetails { get; set; }
        [Display()]
        public string DialyzerType { get; set; }
        [Display()]
        [Range(0, 9999, ErrorMessage = "")]
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
    #endregion

    #region  ConsummedGoodsItem
    public partial class ConsummedGoodsItem
    {
        [Key]
        public int CGItemId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<int> GoodsId { get; set; }
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<int> Quantity { get; set; }
        [Display()]
        public Nullable<double> Cost { get; set; }

        public virtual ConsumableGoods ConsumableGoods { get; set; }
        public virtual DialysisSession DialysisSession { get; set; }
    }
    #endregion

    #region  EvaluationNurse
    public partial class EvaluationNurse
    {
        [Key]
        public int HEvaId { get; set; }
        [StringLength(15, ErrorMessage = "")]
        public string PersonnelCode { get; set; }

        public virtual HourlyEvaluation HourlyEvaluation { get; set; }
        public virtual Personal Personal { get; set; }
    }
    #endregion

    #region  HourlyEvaluation
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
    #endregion

    #region  InfirmaryPersonnel
    public partial class InfirmaryPersonnel
    {
        [Key]
        public int IPersonnelId { get; set; }
        public string PersonnelCode { get; set; }
        [Display()]
        public string FirstName { get; set; }
        [Display()]
        public string LastName { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  InfirmaryReception
    public partial class InfirmaryReception
    {
        [Key]
        public int IReceptionId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        [Display()]
        public string PersonalCode { get; set; }
        [Display()]
        public Nullable<System.DateTime> DateTime { get; set; }
        [Display()]
        public string PatientName { get; set; }
        [Display()]
        public Nullable<int> PayableAmount { get; set; }
        [Display()]
        public string Desctiption { get; set; }

        public virtual Personal Personal { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  InsuranceOrganization
    public partial class InsuranceOrganization
    {
        [Key]
        public int IOrgId { get; set; }
        public string OrganizationCode { get; set; }
        [Display()]
        public string OrganizationName { get; set; }
        [Display()]
        [Range(0, 100, ErrorMessage = "")]
        public Nullable<int> Rate { get; set; }

        public virtual ICollection<DialysisPatient> DialysisPatient { get; set; }
    }
    #endregion

    #region  Personal
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
    #endregion

    #region  Role
    public partial class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Display()]
        public string RoleName { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
    #endregion

    #region  Service
    public partial class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Display()]
        public string SeviceTitle { get; set; }
        [Display()]
        public Nullable<int> Price { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  ServiceItem
    public partial class ServiceItem
    {
        [Key]
        public int ServiceItemId { get; set; }
        public Nullable<int> IReceptionId { get; set; }
        public Nullable<int> IPersonnelId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        [Display()]
        public Nullable<int> Cost { get; set; }
        [Display()]
        public string Description { get; set; }

        public virtual InfirmaryPersonnel InfirmaryPersonnel { get; set; }
        public virtual InfirmaryReception InfirmaryReception { get; set; }
        public virtual Service Service { get; set; }
    }
    #endregion

    #region  User
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        [Display()]
        public string Username { get; set; }
        [Display()]
        public string Password { get; set; }
        [Display()]
        public string Email { get; set; }
        [Display()]
        public string SecurityQuestion { get; set; }
        [Display()]
        public string SecurotyAnswer { get; set; }
        [Display()]
        public string PersonnelCode { get; set; }

        public virtual Personal Personal { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
    #endregion


    #region  UserRole
    public partial class UserRole
    {
        [Key]
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
    #endregion









































}