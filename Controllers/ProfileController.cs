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


        public IActionResult ProfileIndex()
        {
          
            return View();
        }

        
        

       
        public IActionResult Edit()
        {
           
            return View();
        }

      




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
