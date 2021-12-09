using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameBaseSite.Models;
using GameBaseSite.Models.Database;



namespace GameBaseSite.Controllers
{
    public class CompareController : Controller
    {
        private LibraryContext Context;
        public CompareController(LibraryContext ctx)
        {
            Context = ctx;
        }
        [HttpGet]
        public IActionResult CompareIndex()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult CompareResult(Search s)
        {
            List<string> results = new List<string>();
            List<string> results2 = new List<string>();
            List<string> common = new List<string>();

            var users = Context.User.Where(u => u.UserId == s.Query).ToList();
            foreach(UserModel u in users)
            {
                //results.Add(u.UserId);
            }

            var usrGames = from u in Context.User
                           join uG in Context.UsrGames on u.UserId equals uG.UserId
                           where u.UserId.Equals(s.Query)
                           select uG.Title;
            foreach(string x in usrGames)
            {
                results.Add(x);
            }

            var users2 = Context.User.Where(u2 => u2.UserId == s.Query2).ToList();
            foreach (UserModel u2 in users)
            {
                //results2.Add(u2.UserId);
            }

            var usrGames2 = from u2 in Context.User
                           join uG2 in Context.UsrGames on u2.UserId equals uG2.UserId
                            where u2.UserId.Equals(s.Query2)
                            select uG2.Title;
            foreach (string x in usrGames2)
            {
                results2.Add(x);
            }

            foreach(var game in results)
            {
                if (results2.Contains(game))
                    common.Add(game);
            }

            if (common.Count() == 0)
            {
                string msg = "You don't share any games :(";
                common.Add(msg);
            }

            ViewBag.results = results;
            ViewBag.results2 = results2;
            ViewBag.common = common;
            return View();
        }
    }
}
