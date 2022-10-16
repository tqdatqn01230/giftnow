using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            Orders = new HashSet<Order>();
        }

        public int DeliveryId { get; set; }
        public decimal Price { get; set; }
        public string Method { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
