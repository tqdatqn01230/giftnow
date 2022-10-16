using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Category
    {
        public Category()
        {
            Filters = new HashSet<Filter>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Filter> Filters { get; set; }
    }
}
