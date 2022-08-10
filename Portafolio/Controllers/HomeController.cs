using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;
//una accion es un metodo de un controlador que le retorna contenido al usario, puede ser un documento html, un archivo pdf, excel o un string simple texto
//
namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly ServcioDelimitado servcioDelimitado;
        private readonly ServcioTransitorio servcioTransitorio;
        private readonly ServcioUnico servcioUnico;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos,
            ServcioDelimitado servcioDelimitado, ServcioTransitorio servcioTransitorio, ServcioUnico servcioUnico)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servcioDelimitado = servcioDelimitado;
            this.servcioTransitorio = servcioTransitorio;
            this.servcioUnico = servcioUnico;
        }

        public IActionResult Index()
        {
          
            var Proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
            var guidViewModel = new EjemploGuidViewModel()
            {
                Delimitado = servcioDelimitado.ObtenerGuid,
                Transitorio = servcioTransitorio.ObtenerGuid,
                Unico = servcioUnico.ObtenerGuid
            };
            var modelo = new HomeIndexViewModel() { 
                Proyectos = Proyectos, 
                EjemploGUID_1 = guidViewModel
            };
            return View(modelo);
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