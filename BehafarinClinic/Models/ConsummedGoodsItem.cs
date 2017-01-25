using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class ConsummedGoodsItem
    {
        [Key]
        public int CGItemId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<int> GoodsId { get; set; }
        [Range(0, 9999, ErrorMessage = "")]
        public Nullable<int> Quantity { get; set; }
        [Display()]
        public Nullable<double> Cost { get; set; }

        public virtual ConsumableGoods ConsumableGoods { get; set; }
        public virtual DialysisSession DialysisSession { get; set; }
    }
}