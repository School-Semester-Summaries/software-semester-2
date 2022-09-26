using BlankoMundo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlankoMundo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Animal animal = new Animal("Rex");

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(animal);
        }

        public IActionResult Swagger(int fakeBoolLol)
        {
            animal.ChangeIsMeetingRoom(fakeBoolLol);
            return Ok(fakeBoolLol);
        }

        public IActionResult Privacy(string name)
        {
            animal.ChangeName(name);
            return View(animal);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
