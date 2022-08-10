using Portafolio.Models;

namespace Portafolio.Servicios
{
    //definiendo interface

    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
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
    }
}
