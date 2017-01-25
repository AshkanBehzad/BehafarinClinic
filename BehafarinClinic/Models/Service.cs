using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ServiceItem = new HashSet<ServiceItem>();
        }

        public int ServiceId { get; set; }
        public string SeviceTitle { get; set; }
        public Nullable<int> Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceItem> ServiceItem { get; set; }
    }
}