
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{

    public partial class InfirmaryReception
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InfirmaryReception()
        {
            this.ServiceItem = new HashSet<ServiceItem>();
        }

        public int IReceptionId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string PersonalCode { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> PayableAmount { get; set; }
        public string Desctiption { get; set; }

        public virtual Personal Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
}