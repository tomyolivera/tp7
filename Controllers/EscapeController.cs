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

        public IActionResult checkResult(string clave, string respuesta, string urlActual, string nuevaUrl)
        {
            ViewBag.Error = "";

            if(clave == respuesta){
                return Redirect(nuevaUrl);
            }else if (clave != ""){
                ViewBag.Error = "Clave incorrecta";
            }

            return View(urlActual);
        }

        public EscapeController(ILogger<EscapeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // [HttpPost]
        public IActionResult Habitacion1(string clave="")
        {
            if(clave != ""){
                return this.checkResult(clave, "how to sell drugs online", "Habitacion1", "Habitacion2");
            }

            return View("Habitacion1");
        }

        // [HttpPost]
        public IActionResult Habitacion2(string clave="")
        {
            if(clave != ""){
                return this.checkResult(clave, "rick", "Habitacion2", "Habitacion3");
            }

            return View("Habitacion2");
        }

        // [HttpPost]
        public IActionResult Habitacion3(string clave="")
        {
            if(clave != ""){
                return this.checkResult(clave, "black mirror", "Habitacion3", "Habitacion4");
            }

            return View("Habitacion3");
        }
        // [HttpPost]
        public IActionResult Habitacion4(string clave="")
        {
            if(clave != ""){
                return this.checkResult(clave, "los 100", "Habitacion4", "Victoria");
            }

            return View("Habitacion4");
        }

        public IActionResult Victoria()
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
