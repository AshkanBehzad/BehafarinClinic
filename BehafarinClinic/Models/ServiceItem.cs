using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
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
}