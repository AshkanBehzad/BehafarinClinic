using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    #region  InfirmaryReception *needs view*
    public class InfirmaryReceptionViewModel
    {
        
        public int InfirmaryReceptionId { get; set; }
        public int? OrganizationId { get; set; }      
        [Display(Name ="نام و نام خانوادگی بیمار")]
        public string PatientName { get; set; }
        [Display(Name ="توضیحات")]
        public string Descriptions { get; set; }

        

        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
    #endregion

  
 
}