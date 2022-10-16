using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Package
    {
        public Package()
        {
            Orders = new HashSet<Order>();
        }

        public int PackageId { get; set; }
        public int Price { get; set; }
        public string Method { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
