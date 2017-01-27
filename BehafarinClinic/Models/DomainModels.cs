using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public enum Gender
    {
        آقای,
        خانم
    }
    #region  ConsumableGoods *needs view for admin*
    public class ConsumableGoods
    {
        [Key]
        public int ConsumableGoodsId { get; set; }
        [Display(Name ="نام")]
        public string Name { get; set; }
        [Display(Name ="تولید‌کننده/توزیع‌کننده")]
        public string VendorOrProvider { get; set; }
        [Display(Name ="قیمت")]
        public int? Price { get; set; }
        [Display(Name ="تعداد موجود")]
        [Range(0, 9999)]
        public int? AvailableQuantity { get; set; }
        [Display(Name ="تاریخ خرید")]
        public DateTime? PurchaseDate { get; set; }
        [Display(Name ="توضیحات")]
        public string Descriptions { get; set; }

        public virtual ICollection<ConsumedGoodsItem> ConsumedGoodsItems { get; set; }
    }
    #endregion

    #region  DialysisPatient *needs view*
    public class DialysisPatient
    {
        [Key]
        public int DialysisPatientId { get; set; }
        
        [Display(Name ="نام")]
        public string FirstName { get; set; }
        [Display(Name ="نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name ="نام پدر")]
        public string FatherName { get; set; }
        [Display(Name ="تاریخ تولد")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "جنسیت")]
        public bool? Gender { get; set; }
        [Display(Name ="تاریخ پذیرش")]
        public DateTime? AdmissionDate { get; set; }
        [Display(Name ="وضعیت تاهل")]
        public bool? MaritalStatus { get; set; }
        [Display(Name ="شغل")]
        public string Occupation { get; set; }
        [Display(Name ="تحصیلات")]
        public string Education { get; set; }
        [Display(Name ="نشانی")]
        public string Address { get; set; }
        [Display(Name ="تلفن")]
        [StringLength(10, ErrorMessage = "")]
        public string Tel { get; set; }
        [Display(Name ="پزشک معالج")]
        public string AttendingPhysician { get; set; }
        [Display(Name ="وضعیت عمومی")]
        public string GeneralCondition { get; set; }
        [Display(Name ="وضعیت روانی")]
        public string MentalCondition { get; set; }
        [Display(Name ="میزان مصرف دخانیات")]
        public string SmokingRecords { get; set; }
        [Display(Name ="علت ESRD")]
        public string ESRD { get; set; }
        [Display(Name ="سوابق بالینی")]
        public string ClinicalRecords { get; set; }
        [Display(Name ="نوع دسترسی عروقی")]
        public string VascularAccessDetails { get; set; }
        [Display(Name ="مارکر‌های ویروسی")]
        public string ViralMarkers { get; set; }
        [Display(Name ="جزئیات بیشتر")]
        public string Description { get; set; }
        [ForeignKey("InsuranceOrganizationId")]
        public virtual InsuranceOrganization InsuranceOrganization { get; set; }
        [ForeignKey("ReceptionistPerssonnelId")]
        public virtual Personnel Personnel { get; set; }
        public int ReceptionistPerssonnelId { get; set; }
        public int? InsuranceOrganizationId { get; set; }
        public virtual ICollection<DialysisSession> DialysisSessions { get; set; }
    }
    #endregion

    #region  DialysisSession *needs view*
    public class DialysisSession
    {
        [Key]
        public int DialysisSessionId { get; set; }
        public int? PatientId { get; set; }
        [Display(Name ="تاریخ جلسه")]
        public DateTime? SessionDate { get; set; }
        
        [Display(Name ="تشخیص")]
        public string Diagnosis { get; set; }
        [Display(Name ="وزن قبل از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? WeightBD { get; set; }
        [Display(Name = "فشار خون قبل از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? BloodPresureBD { get; set; }
        [Display(Name = "دمای بدن قبل از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? TempratureBD { get; set; }
        [Display(Name = "نبض قبل از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? PulseRateBD { get; set; }
        [Display(Name = "تعداد نفس قبل از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? BreathingRateBD { get; set; }
        [Display(Name ="وزن بعد از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? WeightAD { get; set; }
        [Display(Name = "فشار خون بعد از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? BloodPresureAD { get; set; }
        [Display(Name = "دمای بدن بعد از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? TempratureAD { get; set; }
        [Display(Name = "نبض بعد از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? PulseRateAD { get; set; }
        [Display(Name = "تعداد نفس بعد از دیالیز")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? BreathingRateAD { get; set; }
        [Display(Name ="نوع دسترسی به عروق")]
        public string VascularAccessDetails { get; set; }
        [Display(Name ="نوع و شماره ماشین دیالیز")]
        public string DialysisMachineDetails { get; set; }
        [Display(Name ="نوع صافی")]
        public string DialyzerType { get; set; }
        [Display(Name ="وزن خشک")]
        [Range(0, 9999, ErrorMessage = "")]
        public double? DryWeight { get; set; }
        [Display(Name ="جریان خون")]
        public double? BloodFlow { get; set; }
        [Display(Name ="جریان محلول")]
        public string DialysateFlow { get; set; }
        [Display(Name ="نوع بافر")]
        public string BufferType { get; set; }
        [Display(Name ="")]
        public string TMP { get; set; }
        [Display(Name ="TMP")]
        public double? DialysateTemperature { get; set; }
        [Display(Name ="مارکر‌های ویروسی")]
        public string ViralMarkers { get; set; }
        [Display(Name ="غلظت سدیم محلول")]
        public double? SodiumCon { get; set; }
        [Display(Name ="فشار شریانی")]
        public double? ArterialPressure { get; set; }
        [Display(Name ="فشار وریدی")]
        public double? VenousPressure { get; set; }
        [Display(Name ="پروفایل")]
        public string Profile { get; set; }
        [Display(Name ="ملاحظات پزشک")]
        public string DoctorNotes { get; set; }
        [Display(Name ="مشاهدات پرستاری")]
        public string NurseObservations { get; set; }

        public virtual DialysisPatient DialysisPatient { get; set; }
        [ForeignKey("ReceptionistPersonnelId")]
        public virtual Personnel Nurse { get; set; }
        [ForeignKey("DoctorPersonnelId")]
        public virtual Personnel Doctor { get; set; }
        
        public int ReceptionistPersonnelId { get; set; }
        public int DoctorPersonnelId { get; set; }
        public virtual ICollection<ConsumedGoodsItem> ConsumedGoodsItems { get; set; }
        public virtual ICollection<HourlyEvaluation> HourlyEvaluations { get; set; }

    }
    #endregion

    #region  ConsumedGoodsItem *needs view within Dialysis Session view*
    public class ConsumedGoodsItem
    {
        [Key]
        public int ConsumedGoodsItemId { get; set; }
        public int? SessionId { get; set; }
        public int? GoodsId { get; set; }
        [Range(0, 9999, ErrorMessage = "")]
        public int? Quantity { get; set; }
        [Display(Name ="")]
        public double? Cost { get; set; }

        public virtual ConsumableGoods ConsumableGoods { get; set; }
        public virtual DialysisSession DialysisSession { get; set; }
    }
    #endregion

    #region  EvaluationNurse
    //public class EvaluationNurse
    //{
    //    [Key]
    //    public int EvaluationNurseId { get; set; }
    //    //[StringLength(15, ErrorMessage = "")]
    //    public int PersonnelId { get; set; }

    //    public virtual HourlyEvaluation HourlyEvaluation { get; set; }
    //    public virtual Personnel Personnel { get; set; }
    //}
    #endregion

    #region  HourlyEvaluation *needs view within Dialysis Session view*
    public class HourlyEvaluation
    {
        [Key]
        public int HourlyEvaluationId { get; set; }
        public int? SessionId { get; set; }
        [Range(0, 9999, ErrorMessage = "")]
        [Display(Name ="فشار خون")]
        public double? BloodPressure { get; set; }
        [Display(Name ="عوارض احتمالی")]
        public string SideEffect { get; set; }
        [Display(Name ="اقدام درمانی ")]
        public string MedicalAction { get; set; }
        [Display(Name ="ساعت ازریابی")]
        public int EvaluationTime { get; set; }

        public virtual DialysisSession DialysisSession { get; set; }
        public virtual ICollection<Personnel> Nurses { get; set; }
    }
    #endregion

    #region  InfirmaryPersonnel *needs view for admin*
    public class InfirmaryPersonnel
    {
        [Key]
        public int InfirmaryPersonnelId { get; set; }
        public int PersonnelId { get; set; }
        [Display(Name ="نام")]
        public string FirstName { get; set; }
        [Display(Name ="نام خانوادگی")]
        public string LastName { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  InfirmaryReception *needs view*
    public class InfirmaryReception
    {
        [Key]
        public int InfirmaryReceptionId { get; set; }
        public int? OrganizationId { get; set; }
        [Display(Name ="مسئول پذیرش")]
        public int PersonnelId { get; set; }
        [Display(Name ="تاریخ و زمان پذیرش")]
        public DateTime? DateTime { get; set; }
        [Display(Name ="نام و نام خانوادگی بیمار")]
        public string PatientName { get; set; }
        [Display(Name ="مبلغ قابل پرداخت")]
        public int? PayableAmount { get; set; }
        [Display(Name ="توضیحات")]
        public string Descriptions { get; set; }

        public virtual Personnel ReceptionPersonnel { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  InsuranceOrganization *needs view for admin*
    public class InsuranceOrganization
    {
        [Key]
        public int InsuranceOrganizationId { get; set; }
        public string OrganizationCode { get; set; }
        [Display(Name ="")]
        public string OrganizationName { get; set; }
        [Display(Name ="")]
        [Range(0, 100, ErrorMessage = "")]
        public int? Rate { get; set; }

        public virtual ICollection<DialysisPatient> DialysisPatient { get; set; }
    }
    #endregion

    #region  Personnel
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }
        [Display(Name ="کد پرسنلی")]
        public string PersonnelCode { get; set; }
        [Display(Name ="نام")]
        public string FirstName { get; set; }
        [Display(Name ="نام خانوادگی")]
        public string LastName { get; set; }
        [Display(Name ="نوع")]
        public  PersonnelType Type { get; set; }

        public virtual ICollection<DialysisPatient> DialysisPatients { get; set; }
        public virtual ICollection<DialysisSession> InitiatedSessions { get; set; }//personnel as Dialysis Nurse OR Receptionist
        public virtual ICollection<DialysisSession> ObservedSessions { get; set; }//Personnel as Dialysis Doctor
        public virtual ICollection<HourlyEvaluation> Evaluations { get; set; }//Personnel as Dialysis Nurse
        public virtual ICollection<InfirmaryReception> InfirmaryReceptions { get; set; }//personnel as Receptionist
        public virtual ICollection<ApplicationUser> User { get; set; }
    }
    #endregion

    //#region  Role
    //public class Role
    //{
    //    [Key]
    //    public int RoleId { get; set; }
    //    [Display(Name ="")]
    //    public string RoleName { get; set; }

    //    public virtual ICollection<UserRole> UserRole { get; set; }
    //}
    //#endregion

    #region  Service
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Display(Name ="")]
        public string SeviceTitle { get; set; }
        [Display(Name ="")]
        public int? Price { get; set; }

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

    #region  ServiceItem
    public class ServiceItem
    {
        [Key]
        public int ServiceItemId { get; set; }
        public int? InfirmaryReceptionId { get; set; }
        public int? InfirmaryPersonnelId { get; set; }
        public int? ServiceId { get; set; }
        [Display(Name ="هزینه")]
        public int? Cost { get; set; }
        [Display(Name ="توضیحات")]
        public string Description { get; set; }

        public virtual InfirmaryPersonnel InfirmaryPersonnel { get; set; }
        public virtual InfirmaryReception InfirmaryReception { get; set; }
        public virtual Service Service { get; set; }
    }
    #endregion

    #region  public enum PersonnelType
    public enum PersonnelType
    {
        پزشک=1,
        پرستار,
        پذیرش
    }
    #endregion

    //#region  User
    //public class User
    //{
    //    [Key]
    //    public int UserId { get; set; }
    //    [Display(Name ="")]
    //    public string Username { get; set; }
    //    [Display(Name ="")]
    //    [DataType(DataType.Password)]
    //    public string Password { get; set; }
    //    [Display(Name ="")]
    //    [DataType(DataType.EmailAddress)]
    //    public string Email { get; set; }
    //    [Display(Name ="")]
    //    public string SecurityQuestion { get; set; }
    //    [Display(Name ="")]
    //    public string SecurotyAnswer { get; set; }
    //    [Display(Name ="")]
    //    public int PersonnelId { get; set; }

    //    public virtual Personnel Personnel { get; set; }

    //    public virtual ICollection<UserRole> UserRole { get; set; }
    //}
    //#endregion

    //#region  UserRole
    //public class UserRole
    //{
    //    [Key]
    //    public int UserRoleId { get; set; }
    //    public Nullable<int> RoleId { get; set; }
    //    public Nullable<int> UserId { get; set; }

    //    public virtual Role Role { get; set; }
    //    public virtual User User { get; set; }
    //}
    //#endregion


}