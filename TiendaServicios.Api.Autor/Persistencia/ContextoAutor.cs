using Microsoft.EntityFrameworkCore;
using System;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options): base(options){
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DbSet<AutorLibro> AutorLibro { get; set; }
        
        public DbSet<GradoAcademico> GradoAcademico { get; set; }

    }
}
