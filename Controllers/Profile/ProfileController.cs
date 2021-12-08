using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GameBaseSite.Models;
using System.Diagnostics;

namespace GameBaseSite.Controllers
{
    public class ProfileController : Controller
    {

        private LibraryContext Context { get; set; }

        public ProfileController(LibraryContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult ProfileIndex()
        {
           
            ViewBag.games = Context.ProfileGames.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Remove(string id)
        {
            ProfileGameModel game = Context.ProfileGames.Find(id);
            Context.ProfileGames.Remove(game);
            Context.SaveChanges();

            ViewBag.games = Context.Games.ToList();
            return View("LibraryIndex");
        }


        [HttpGet]
        public IActionResult Edit(string id)
        {
            ProfileGameModel game;
            if (String.IsNullOrEmpty(id))
            {
                game = Context.ProfileGames.Find(id);
                ViewBag.button = "Save";
                return View(game);
            }
            else
            {
                game = Context.ProfileGames.Find(id);
                ViewBag.button = "Save";
                return View(game);
            }

        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
