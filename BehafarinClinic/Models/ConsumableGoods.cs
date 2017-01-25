using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{

    public partial class ConsumableGoods
    {
        [Key]
        public int GoodsId { get; set; }
        [Display()]
        public string Name { get; set; }
        [Display()]
        public string VendorOrProvider { get; set; }
        [Display()]
        public Nullable<int> Price { get; set; }
        [Display()]
        [Range(0, 9999)]
        public Nullable<int> AvalableQuantity { get; set; }
        [Display()]
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        [Display()]
        public string Description { get; set; }

        public virtual ICollection<ConsummedGoodsItem> ConsummedGoodsItem { get; set; }
    }
}