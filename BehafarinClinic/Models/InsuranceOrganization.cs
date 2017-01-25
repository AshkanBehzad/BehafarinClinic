using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class InsuranceOrganization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InsuranceOrganization()
        {
            this.DialysisPatient = new HashSet<DialysisPatient>();
        }

        public int IOrgId { get; set; }
        public string OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public Nullable<int> Rate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DialysisPatient> DialysisPatient { get; set; }
    }
}