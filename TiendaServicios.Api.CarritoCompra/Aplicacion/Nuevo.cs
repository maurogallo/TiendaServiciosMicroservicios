using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TiendaServicios.Api.CarritoCompra.Modelo;
using TiendaServicios.Api.CarritoCompra.Persistencia;

namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<Unit>
        {
            public DateTime FechaCreacionSesion { get; set; }
            public List<String> ProductoLista { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, Unit>
        {
            private readonly CarritoContexto _contexto;

            public Manejador(CarritoContexto contexto)
            {
                _contexto = contexto;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }
                if (request.ProductoLista == null || request.ProductoLista.Count == 0)
                {
                    throw new ArgumentException("La lista de productos no puede estar vacía.", nameof(request.ProductoLista));
                }

                var carritoSesion = new CarritoSesion
                {
                    FechaCreacion = request.FechaCreacionSesion == default ? DateTime.UtcNow : request.FechaCreacionSesion
                };

                _contexto.CarritoSesion.Add(carritoSesion);
                var saveResult = await _contexto.SaveChangesAsync(cancellationToken);

                if (saveResult == 0)
                {
                    throw new Exception("Error en la insercion del carrito de compras");
                }

                int id = carritoSesion.CarritoSesionId;

                foreach (var obj in request.ProductoLista)
                {
                    var detalleSesion = new CarritoSesionDetalle
                    {
                        FechaCreacion = DateTime.UtcNow,
                        CarritoSesionId = id,
                        ProductoSeleccionado = obj
                    };
                    _contexto.CarritoSesionDetalle.Add(detalleSesion);
                }

                saveResult = await _contexto.SaveChangesAsync(cancellationToken);

                if (saveResult > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo insertar el detalle del carrito de compra");
            }
        }
    }
}
