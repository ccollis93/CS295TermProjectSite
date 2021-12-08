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

            var users = Context.User.Where(u => u.UserId.Contains(s.Query)).ToList();
            foreach(UserModel u in users)
            {
                //results.Add(u.UserId);
            }

            var usrGames = from u in Context.User
                           join uG in Context.UsrGames on u.UserId equals uG.UserId
                           where u.UserId.Contains(s.Query)
                           select uG.Title;
            foreach(string x in usrGames)
            {
                results.Add(x);
            }

            var users2 = Context.User.Where(u2 => u2.UserId.Contains(s.Query)).ToList();
            foreach (UserModel u2 in users)
            {
                //results2.Add(u2.UserId);
            }

            var usrGames2 = from u2 in Context.User
                           join uG2 in Context.UsrGames on u2.UserId equals uG2.UserId
                           where u2.UserId.Contains(s.Query)
                           select uG2.Title;
            foreach (string x in usrGames2)
            {
                results2.Add(x);
            }



            ViewBag.results = results;
            return View();
        }
    }
}
