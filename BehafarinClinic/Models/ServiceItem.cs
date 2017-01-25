using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class ServiceItem
    {
        public int ServiceItemId { get; set; }
        public Nullable<int> IReceptionId { get; set; }
        public Nullable<int> IPersonnelId { get; set; }
        public Nullable<int> ServiceId { get; set; }
        public Nullable<int> Cost { get; set; }
        public string Description { get; set; }

        public virtual InfirmaryPersonnel InfirmaryPersonnel { get; set; }
        public virtual InfirmaryReception InfirmaryReception { get; set; }
        public virtual Service Service { get; set; }
    }
}