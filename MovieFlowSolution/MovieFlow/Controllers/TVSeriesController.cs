using Microsoft.AspNetCore.Mvc;
using MovieFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class TVSeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /* Aici am creeat o lista de tip TvSeries dupa modelul TvSeriesCatalog*/
        List<TVSeriesCatalog> tvSeriesCatalogTable = new List<TVSeriesCatalog>() {



new TVSeriesCatalog()
{
TvSerieId = 100,
TvSerieName = "Gossip Girl",
TvSerieDescription = " Gossip Girl, a ruthless and mysterious blogger reveals secrets about teens in upper east side New York." +
"With roller coaster romances and piles of secrets hiding away for Gossip Girl to find," +
"this show is sure to bring the upper east side and its drama into our lives.",
TvSerieBeginYear = 2007,
TvSerieBuget = 438000000,
TvSerieEndYear = 2012,
TvSerieEpisodsNumber = 121,
TvSerieSeasons = 6
},
new TVSeriesCatalog()
{
TvSerieId = 412,
TvSerieName = "The Vampires Diaries",
TvSerieDescription = "The Vampires Diaries,t he series is set in the fictional town of Mystic Falls," +
"Virginia, a town charged with supernatural history." +
"It follows the life of Elena Gilbert(Nina Dobrev), a teenage girl who has just lost both parents in a car accident" +
" , as she falls in love with a 162 - year - old vampire named Stefan Salvatore(Paul Wesley). ",
TvSerieBeginYear = 2009,
TvSerieBuget = 489000000,
TvSerieEndYear = 2017,
TvSerieEpisodsNumber = 171,
TvSerieSeasons = 8
},
new TVSeriesCatalog()
{
TvSerieId = 138,
TvSerieName = "Pretty Little Liars",
TvSerieDescription = " Pretty Little Liars is an American teen drama mystery thriller television series developed by I." +
"Marlene King and is loosely based on the novel series of the same name written by Sara Shepard.The series follows the lives of four high school girls whose clique falls apart after the disappearance of their leader.",
TvSerieBeginYear = 2010,
TvSerieBuget = 125000000,
TvSerieEndYear = 2017,
TvSerieEpisodsNumber = 160,
TvSerieSeasons = 7
},
new TVSeriesCatalog()
{
TvSerieId = 9,
TvSerieName = "New Amsterdam",
TvSerieDescription = "New Amsterdam follows Dr. Max Goodwin as he becomes the medical director of one " +
"the United States' oldest public hospitals, aiming to reform the neglected facility" +
"by tearing up its bureaucracy to provide exceptional care to patients.",
TvSerieBeginYear = 2018,
TvSerieBuget = 35000000,
TvSerieSeasons = 3
},
new TVSeriesCatalog()
{
TvSerieId = 327,
TvSerieName = "Teen Wolf",
TvSerieDescription = "Teen Wolf revolves around Scott McCall, a high school student living in the fictional" +
"California town of Beacon Hills.Scott becomes the eponymous teenage werewolf of the series" +
"after he is bitten by an alpha werewolf the night before his second year of high school," +
"drastically changing his once - ordinary life...p",
TvSerieBeginYear = 2011,
TvSerieBuget = 120000000,
TvSerieEndYear = 2017,
TvSerieEpisodsNumber = 100,
TvSerieSeasons = 6
},
new TVSeriesCatalog()
{
TvSerieId = 250,
TvSerieName = "Sherlock Holmes",
TvSerieDescription = "depicts, consulting detective, Sherlock Holmes (Benedict Cumberbatch) solving various" +
" mysteries in modern - day London.Holmes is assisted by his flatmate and friend," +
" Dr.John Watson(Martin Freeman), who has returned from military service in Afghanistan with the Royal Army Medical Corps",
TvSerieBeginYear = 2010,
TvSerieBuget = 53000000,
TvSerieEndYear = 2017,
TvSerieEpisodsNumber = 4,
TvSerieSeasons = 13
},
new TVSeriesCatalog()
{
TvSerieId = 525,
TvSerieName = "Supernatural",
TvSerieDescription = "Supernatural is an American television series created by Eric Kripke. ..." +
"Starring Jared Padalecki as Sam Winchester and Jensen Ackles as Dean Winchester," +
"the series follows the two brothers as they hunt demons, ghosts, monsters,and other supernatural beings.",
TvSerieBeginYear = 2005,
TvSerieBuget = 50000000,
TvSerieEndYear = 2020,
TvSerieEpisodsNumber = 327,
TvSerieSeasons = 15
},
new TVSeriesCatalog()
{
TvSerieId = 996,
TvSerieName = "Hannibal",
TvSerieDescription = "was an American psychological thriller-horror television series, currently in production at NBC," +
"that is based on the series of novels by Thomas Harris and focuses on the budding relationship between FBI criminal profiler Will Graham and Dr." +
"Hannibal Lecter, a forensic psychiatrist destined to become Graham's most cunning enemy.",
TvSerieBeginYear = 2013,
TvSerieEndYear = 2015,
TvSerieBuget = 12000000,
TvSerieEpisodsNumber = 39 ,
TvSerieSeasons = 3
},
};
        public IActionResult TvSeriesCatalogListView()
        {
            ViewBag.Title = "TvSeries for you";
            ViewBag.Description = "Now you can watch the TvSeries that you want with your friends. For a better experience, " +
            "click on the TvSerie picture to see the trailer. Detalis like the budget of the TvSerie, " +
            "the years of making,the number of episodes and seasons are also available for you.";



            ViewData["tvSeriesCatalog"] = tvSeriesCatalogTable;
            ViewBag.TotalTvSeries = tvSeriesCatalogTable.Count();



            return View();
        }
    }
}
