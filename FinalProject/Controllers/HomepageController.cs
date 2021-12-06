using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomepageController : Controller
    {
        private GameContext context {get; set;}

        public HomepageController(GameContext ctx) {
            context = ctx;
        }

        public IActionResult Index()
        {
            var games = context.Games.OrderBy(vg => vg.Name).ToList();
            foreach(Game vg in games)
            {
                v.Genre = context.Genres.Find(v.GenreId);
            }
            return View(games);
        }


    }
}
