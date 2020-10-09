using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WedstrijdSysteem.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Oversight()
        {
            return View();
        }
        public IActionResult SingleReport()
        {
            return View();
        }
        public IActionResult NewReport()
        {
            return View();
        }
    }
}
