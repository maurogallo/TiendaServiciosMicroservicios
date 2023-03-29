using System;

namespace TiendaServicios.Api.Libros.Modelo
{
    public class LibreriaMaterial
    {
        public Guid? LibreriaMaterialId  { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public Guid? AutorLibro { get; set; }

    }
}
