using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameBaseSite.Models;

namespace GameBaseSite.Controllers
{
    public class UserLibraryController : Controller
    {
        private LibraryContext context { get; set; }

        public UserLibraryController(LibraryContext ctx)
        {
            context = ctx;
        }


        [HttpGet]
        public IActionResult UserLibraryIndex()
        {
            ViewBag.userGames = context.Games.ToList();
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }
    }
}
