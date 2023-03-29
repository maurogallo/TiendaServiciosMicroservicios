using AutoMapper;
using TiendaServicios.Api.Libros.Modelo;

namespace TiendaServicios.Api.Libros.Aplicacion
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<LibreriaMaterial, LibroMaterialDto>();
        }
    }
}
