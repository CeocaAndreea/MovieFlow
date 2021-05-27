using Microsoft.AspNetCore.Mvc;
using MovieFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        /* Aici mi-am creat o lista dupa Modelul MoviesCatalog*/

        List<MoviesCatalog> moviesCatalogTable = new List<MoviesCatalog>(){

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

        public IActionResult MoviesCatalogListView()
        {
            ViewBag.Title = "Movies";
            ViewBag.Description = "Now you can watch the Movies that you want with your friends. For a better experience, " +
            "click on the Movie picture to see the trailer. Detalis like the budget of the Movie, " +
            "the year of making, are also available for you.";

            ViewData["moviesCatalog"] = moviesCatalogTable;
            ViewBag.TotalMovies = moviesCatalogTable.Count();

            return View();
        }
    }
}
