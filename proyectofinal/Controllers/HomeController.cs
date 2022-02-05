using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using proyectofinal.Models;

namespace proyectofinal.Controllers
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
            //Simular los datos como que estoy usando base de datos

            List<Prestamos> prestamo = new List<prestamos>();

           /*Prestamo.Add(new Prestamos()
            {
                Nombre = "Jorge Urbina",
                Direccion = "Alguna direccion",
                Edad = 33,
                Telefono = "12345678"
            });

            Prestamo.Add(new Prestamos()
            {
                Nombre = "Otro Nombre",
                Direccion = "Otra direccion",
                Edad = 20,
                Telefono = "454545454"
            });*/

            return View(prestamo);
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
