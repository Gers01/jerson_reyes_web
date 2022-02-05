using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


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
            //simulador de base de datos 
                
            List<prestamos> prestamos = new List<prestamos>();
            prestamos.Add(new prestamos()
            {
                Nombre = "Jerson",
                Apellido = "Reyes",
                Cedula = "0012206951206J",
                Direccion = "direccion cualquiera",
                Telefono = "12345678",
                Fecha_de_Prestamo = "12/01/22",
                Monto = "25,000",
                Interes="15%",
                Plazo = "6 meses",
                Edad = 25,
                
            });

            return View(prestamos);
        }

        public IActionResult ingresodatos()
        {
            return View();
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
