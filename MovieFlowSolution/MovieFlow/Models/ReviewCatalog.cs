using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Models
{
    public class ReviewCatalog
    {
        [DisplayName("Review Name")]
        public String ReviewName { get; set; }

        [DisplayName("Review Description")]
        public String ReviewDescription
        {
            get; set;
        }
    }
}
