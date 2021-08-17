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

        // [HttpPost]
        public IActionResult Habitacion1(string clave)
        {
            if (clave == "pase"){
                return Redirect("Habitacion2");
            }

            // if(clave.Length > 0){
            //     ViewBag.Error = "Clave incorrecta";
            // }
            
            return View();
        }

        // [HttpPost]
        public IActionResult Habitacion2(string clave)
        {
            if(clave == "How to Sell Drugs Online"){
                return Redirect("Habitacion3");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Habitacion3(string clave)
        {
            if(clave == "Peaky Blinders"){
                Redirect("Habitacion4");
            }
            
            return View();
        }
        [HttpPost]
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
