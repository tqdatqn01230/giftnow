using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Filter
    {
        public Filter()
        {
            Gifts = new HashSet<Gift>();
        }

        public int FilterId { get; set; }
        public string FilterName { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Gift> Gifts { get; set; }
    }
}
