using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WedstrijdSysteem.Controllers
{
    public class UserController : Controller
    {
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }
    }
}
