namespace Portafolio.Servicios
{
    public class ServcioUnico
    {
        public ServcioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServcioDelimitado
    {
        public ServcioDelimitado()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServcioTransitorio
    {
        ServcioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }
}
