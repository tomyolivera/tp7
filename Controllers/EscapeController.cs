using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tp7.Models;

namespace tp7.Controllers
{
    public class EscapeController : Controller
    {
        private readonly ILogger<EscapeController> _logger;

        public EscapeController(ILogger<EscapeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Habitacion1(string clave)
        {
            // string claveToLower = clave.ToLower();

            // if(claveToLower == "elite"){
            //     Redirect("Habitacion2");
            // }

            ViewBag.Error = "sos un pelotudo, no es esa";
            ViewBag.Clave = clave;
           
            return View();
        }

        public IActionResult Habitacion2(string clave)
        {
            if(clave == "How to Sell Drugs Online"){
                Redirect("Habitacion3");
            }
            ViewBag.Error = "sos un pelotudo, no es esa";
            return View();
        }

        public IActionResult Habitacion3(string clave)
        {
            if(clave == "Peaky Blinders"){
                Redirect("Habitacion4");
            }
            ViewBag.Error = "sos un pelotudo, no es esa";
            return View();
        }

        public IActionResult Habitacion4(string clave)
        {
            if(clave == "Breaking Bad"){
                Redirect("Victoria");
            }
            ViewBag.Error = "sos un pelotudo, no es esa";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
