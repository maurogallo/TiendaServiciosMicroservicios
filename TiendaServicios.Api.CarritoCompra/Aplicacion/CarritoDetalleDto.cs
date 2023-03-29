using System;


namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class CarritoDetalleDto
    {
        public Guid?   LibroId { get; set; }
        public String TituloLibro { get; set; }
        public String AutorLibro { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
