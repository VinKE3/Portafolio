using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var Proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = Proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List <Proyecto>()
            {
              new Proyecto
              {
                  Titulo = "Amazon",
                  Descripcion = "E-comerce realizado en React",
                  Link = "https://amazon.com",
                  ImagenUrl = "/imagenes/amazon.png"

              },
              new Proyecto
              {
                  Titulo = "New York Times",
                  Descripcion = "Pagina de noticias en React",
                  Link = "https://nytimes.com",
                  ImagenUrl = "/imagenes/nyt.png"

              },
              new Proyecto
              {
                  Titulo = "Reddit",
                  Descripcion = "Red social para compartir comunidades",
                  Link = "https://reddit.com",
                  ImagenUrl = "/imagenes/reddit.png"

              },
              new Proyecto
              {
                  Titulo = "Steam",
                  Descripcion = "Tienda virtual para comprar videojuegos",
                  Link = "https://steam.com",
                  ImagenUrl = "/imagenes/steam.png"

              },
            };
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