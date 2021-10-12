using Lab3.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Razor() => View();

        [HttpPost]
        public IActionResult Count()
        {
            
            ViewData["numOfBottles"] = Request.Form["numOfBottles"];
            return View(); 
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person) 
        {
            
            
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
