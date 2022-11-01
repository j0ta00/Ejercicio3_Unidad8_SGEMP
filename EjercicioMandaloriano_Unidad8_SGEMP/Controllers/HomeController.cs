using Ejercicio3_Unidad8_SGEMP.Capa_DAL;
using EjercicioMandaloriano_Unidad8_SGEMP.Models;
using EjercicioMandaloriano_Unidad8_SGEMP.Models.entidades;
using EjercicioMandaloriano_Unidad8_SGEMP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjercicioMandaloriano_Unidad8_SGEMP.Controllers
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
            VMMisiones vm = new VMMisiones();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(String titulo)
        {
            VMMisiones vm = new VMMisiones();
            ViewData["titulo"] = titulo;
            ViewData["descripcion"] = vm.getDescripcionMision(titulo);
            return View(vm);
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