
using Ejercicio3_Unidad8_SGEMP.Models;
using Ejercicio3_Unidad8_SGEMP.Models.entidades;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio3_Unidad8_SGEMP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar()
        {
            clsPersona persona = new clsPersona("Marta","Devos","El samora","34332343");
            return View(persona);
        }
        [HttpPost]
        public IActionResult Editar(clsPersona clsPersona)
        {
           return View("PersonaModificada", clsPersona);         
        }
        public IActionResult Privacy()
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