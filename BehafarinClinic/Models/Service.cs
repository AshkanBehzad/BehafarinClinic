using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
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
}