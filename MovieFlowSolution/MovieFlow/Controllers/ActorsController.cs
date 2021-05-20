using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ActorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
