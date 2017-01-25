
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{

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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
}