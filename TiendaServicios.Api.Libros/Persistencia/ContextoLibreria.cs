using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Libros.Modelo;

namespace TiendaServicios.Api.Libros.Persistencia
{
    public class ContextoLibreria : DbContext
    {
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options) { }

        public DbSet<LibreriaMaterial> LibreriaMaterial { get; set;}



    }
}
