using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS295NTermProject.Models;

namespace CS295NTermProject.Controllers
{
    public class GamesPlayedController : Controller
    {
        private GamesPlayedContext context { get; set; }

        public GamesPlayedController(GamesPlayedContext ctx)
        {
            context = ctx;
        }

        public IActionResult GamesPlayed()
        {
            ViewBag.gameList = context.GameInfo.ToList();
            return View();
        }
    }
}
