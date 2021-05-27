using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Models
{
    public class MoviesCatalog
    {
        [DisplayName("Movie Id")]
        public int MovieId { get; set; }



        [DisplayName("Movie Name")]
        public String MovieName { get; set; }



        [DisplayName("Movie Description")]
        public String MovieDescription { get; set; }



        [DisplayName("Movie Buget")]
        public int MovieBuget { get; set; }



        [DisplayName("Movie Year")]
        public int MovieYear { get; set; }
    }
}
