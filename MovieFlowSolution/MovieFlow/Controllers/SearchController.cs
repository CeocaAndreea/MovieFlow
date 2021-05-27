using Microsoft.AspNetCore.Mvc;
using MovieFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            ViewBag.Title = "What do you wish to search?";
            ViewBag.Description = "You have two options for searching. If you click the first button you will start then to swarch for movies " +
            ",but if you click the right button, you will start for a TvSerie.";
            return View();
        }
        public IActionResult SearchForMovies()
        {
            ViewBag.Title = "Movies";
            ViewBag.Description = "Now you can search the movies you wish to watch by writing in the search for name textbox" +
            "the name of the movie that you are interested in";
            ViewData["moviesCatalog"] = moviesCatalogTable;
            ViewBag.TotalMovies = moviesCatalogTable.Count();
            return View();
        }
        public IActionResult SearchForTVSeries(){
                ViewBag.Title = "TvSeries for you to search...";
                ViewBag.Description = "Now you can search the TvSeries you wish to watch by writing in the search for name textbox" +
                "the name of the TvSerie that you are interested in";
                ViewData["tvSeriesCatalog"] = tvSeriesCatalogTable;
                ViewBag.TotalTvSeries = tvSeriesCatalogTable.Count();
                return View(tvSeriesCatalogTable);
        }

        List<MoviesCatalog> moviesCatalogTable = new List<MoviesCatalog>()
{
new MoviesCatalog() {
MovieId = 10,
MovieName = "Fast & Furious",
MovieDescription = " The Fast and the Furious is a media franchise centered on a series of action films that are largely concerned " +
"with illegal street racing,heists,and spies.The franchise also includes short films," +
"a television series, live shows,video games,and theme park attractions.",
MovieYear = 2001,
MovieBuget = 38000000
},
new MoviesCatalog()
{
MovieId = 12,
MovieName = "Hunger Games",
MovieDescription = "Hunger Games are an annual televised event where the ruthless" +
"Capitol randomly selects one boy and one girl, each between the ages of 12 and 18" +
"from each of the twelve districts, pitting them against each other in a game of survival" +
"where they are forced to fight one another to the death. ",
MovieYear = 2012,
MovieBuget = 78000000
},
new MoviesCatalog()
{
MovieId = 15,
MovieName = "Harry Potter",
MovieDescription = " Throughout the series, Harry is described as having his father's perpetually untidy black hair," +
" his mother's bright green eyes, and a lightning bolt-shaped scar on his forehead.He is further described as small and skinny for his age" +
" with a thin face knobbly knees, and he wears Windsor glasses.",
MovieYear = 2001,
MovieBuget = 125000000
},
new MoviesCatalog()
{
MovieId = 9,
MovieName = "Divergent",
MovieDescription = "is a series about a society divided among assigned factions and and" +
"a girl who doesn't fit into any of them. The moral force of the books" +
"lies in the constant reminder that you should always under all circumstances,make decisions for yourself, rather than letting society" +
" dictate these decisions to you.",
MovieYear = 2014,
MovieBuget = 85000000
},
new MoviesCatalog()
{
MovieId = 7,
MovieName = "Endless Love",
MovieDescription = "Endless Loveis about a teenage boy who remembers, with full ferocity and grief and yearning,the great love of his life," +
"after it has been ended by fate and the adult world.The movie “Endless Love” is about a teenage boy and girl who are in love," +
"until fate and adults end their relationship",
MovieYear = 2014,
MovieBuget = 20000000
},
new MoviesCatalog()
{
MovieId = 20,
MovieName = "Crazy Stupid Love",
MovieDescription = " A middle-aged husband's life changes dramatically when his wife asks him for a divorce. He seeks to rediscover his manhood with the help of a newfound friend, Jacob, learning to pick up girls at bars. Cal (Steve Carell) and Emily (Julianne Moore) have the perfect life together living the American dream..",
MovieYear = 2011,
MovieBuget = 50000000
},
new MoviesCatalog()
{
MovieId = 25,
MovieName = "Crazy Rich Asians",
MovieDescription = "It follows a Chinese-American professor who travels to meet her boyfriend's family and is surprised to discover they are among the richest in Singapore. The film was announced in" +
" August 2013 after the rights to the book were purchased.",
MovieYear = 2018,
MovieBuget = 30000000
},
new MoviesCatalog()
{
MovieId = 16,
MovieName = "Mr. & Mrs. Smith",
MovieDescription = "The film stars Brad Pitt and Angelina Jolie as a bored upper " +
"middle class married couple surprised to learn that they are assassins belonging to competing agencies, and that they have been assigned to kill each other",
MovieYear = 2008,
MovieBuget = 125000000
},
new MoviesCatalog()
{
MovieId = 19,
MovieName = "Angel has fallen",
MovieDescription = "Angel has fallen is a 2019 American action thriller film directed by Ric Roman Waugh.It is the third installment in the Has Fallen film series" +
"following Olympus Has Fallen(2013) and London Has Fallen(2016).",
MovieYear = 2019,
MovieBuget = 80000000
},
new MoviesCatalog()
{
MovieId = 22,
MovieName = "A Simple Favor",
MovieDescription = "The film stars Anna Kendrick, Blake Lively, Henry Golding,Andrew Rannells,Linda Cardellini," +
"Rupert Friend, and Jean Smart and follows a small town vlogger who tries to solve the disappearance of her mysterious and elegant friend." +
"A Simple Favor was released in the United States on September 14 2018 by Lionsgate",
MovieYear = 2018,
MovieBuget = 20000000
},
new MoviesCatalog()
{
MovieId = 32,
MovieName = "Atomic Blonde",
MovieDescription = "Atomic Blonde is a 2017 American action thriller film" +
"based on the 2012 graphic novel The Coldest City, which revolves around a" +
"spy who has to find a list of double agents who are being smuggled into the West on" +
"the eve of the collapse of the Berlin Wall in 1989.MovieYear = 2018",
MovieBuget = 30000000,
MovieYear = 2017
},
new MoviesCatalog()
{
MovieId = 39,
MovieName = "Baby Driver",
MovieDescription = "Baby Driver is a 2017 action film written and directed" +
"by Edgar Wright.It stars Ansel Elgort as a getaway driver seeking freedom from a life of" +
"crime with his girlfriend Debora(Lily James).",
MovieBuget = 34000000,
MovieYear = 2017
},
};


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

    }
}
