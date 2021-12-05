using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSIte.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult ProfileIndex()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }
    }
}
