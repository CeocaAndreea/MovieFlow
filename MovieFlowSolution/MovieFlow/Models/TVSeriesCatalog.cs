using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Models
{
    public class TVSeriesCatalog
    {
        [DisplayName("TvSerie Id")]
        public int TvSerieId { get; set; }



        [DisplayName("TvSerie Name")]
        public String TvSerieName { get; set; }



        [DisplayName("TvSerie Description")]
        public String TvSerieDescription { get; set; }



        [DisplayName("TvSerie Buget")]
        public int TvSerieBuget { get; set; }



        [DisplayName("TvSerie BeginYear")]
        public int TvSerieBeginYear { get; set; }



        [DisplayName("TvSerie EndYear")]
        public int TvSerieEndYear { get; set; }



        [DisplayName("TvSerie Episod")]
        public int TvSerieEpisodsNumber { get; set; }



        [DisplayName("TvSerie Seasons")]
        public int TvSerieSeasons { get; set; }
    }
}
