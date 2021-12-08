using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameBaseSite.Models;
using GameBaseSite.Models.Quiz;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameBaseSite.Controllers
{
    public class GameLibraryController : Controller
    {
        private LibraryContext Context { get; set; }

        public GameLibraryController(LibraryContext ctx)
        {
            Context = ctx;
        }

  

        [HttpGet]
        public IActionResult LibraryIndex()
        {
            ViewBag.games = Context.Games.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult LibraryIndex(GameModel model)
        {
            if (String.IsNullOrEmpty(model.GameId))
            {
                Context.Games.Update(model);
                Context.SaveChanges();
            }
            else
            {
                Context.Games.Add(model);
                Context.SaveChanges();
            }

            ViewBag.games = Context.Games.ToList();
            return View(new GameModel());
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            GameModel game;
            if (String.IsNullOrEmpty(id))
            {
                game = Context.Games.Find(id);
                ViewBag.button = "Save";
                return View(game);
            }
            else
            {
                game = Context.Games.Find(id);
                ViewBag.button = "Save";
                return View(game);
            }
       
        }

        [HttpGet]
        public IActionResult Remove(string id)
        {
            GameModel game = Context.Games.Find(id);
            Context.Games.Remove(game);
            Context.SaveChanges();

            ViewBag.games = Context.Games.ToList();
            return View("LibraryIndex");
        }

        [HttpPost]
        public IActionResult Search(GameModel model)
        {
            ViewBag.games = Context.Games.Where(g => g.Title.Contains(model.Title)).ToList();
            return View();
        }


    

    }
}

