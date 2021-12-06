using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBaseSite.Controllers
{
    public class CompareController : Controller
    {
        public IActionResult CompareIndex()
        {
            return View();
        }
    }
}
