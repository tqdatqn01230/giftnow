using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int PackageId { get; set; }
        public int DeliveryId { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal PackagingPrice { get; set; }
        public decimal DeliveryPrice { get; set; }

        public virtual Delivery Delivery { get; set; }
        public virtual Package Package { get; set; }
        public virtual Gift Product { get; set; }
        public virtual User User { get; set; }
    }
}
