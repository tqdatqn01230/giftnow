using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Gift
    {
        public Gift()
        {
            Orders = new HashSet<Order>();
        }

        public int GiftId { get; set; }
        public string GiftName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public int FilterId { get; set; }
        public int? SizeH { get; set; }
        public int? SizeW { get; set; }
        public int? SizeD { get; set; }
        public int? Weight { get; set; }

        public virtual Filter Filter { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
