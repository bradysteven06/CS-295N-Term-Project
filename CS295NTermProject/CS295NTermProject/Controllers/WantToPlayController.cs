using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS295NTermProject.Models;

namespace CS295NTermProject.Controllers
{
    public class WantToPlayController : Controller
    {
        private WantToPlayContext context { get; set; }

        public WantToPlayController(WantToPlayContext ctx)
        {
            context = ctx;
        }

        public IActionResult WantToPlay()
        {
            ViewBag.gameList = context.GameInfo.ToList();
            return View();
        }
    }
}
