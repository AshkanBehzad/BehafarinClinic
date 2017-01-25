using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BehafarinClinic.Models
{
    public partial class ConsummedGoodsItem
    {
        public int CGItemId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<int> GoodsId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Cost { get; set; }

        public virtual ConsumableGoods ConsumableGoods { get; set; }
        public virtual DialysisSession DialysisSession { get; set; }
    }
}