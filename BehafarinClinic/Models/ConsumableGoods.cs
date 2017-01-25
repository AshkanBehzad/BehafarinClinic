using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class ConsumableGoods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConsumableGoods()
        {
            this.ConsummedGoodsItem = new HashSet<ConsummedGoodsItem>();
        }

        public int GoodsId { get; set; }
        public string Name { get; set; }
        public string VendorOrProvider { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> AvalableQuantity { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsummedGoodsItem> ConsummedGoodsItem { get; set; }
    }
}