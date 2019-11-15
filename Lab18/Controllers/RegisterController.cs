using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayRegistrant(Registrant newRegistrant)
        {
            if (ModelState.IsValid)
            {
                return View(newRegistrant);
            }
            else
            {
                return View("Index");
            }
        }
    }
}