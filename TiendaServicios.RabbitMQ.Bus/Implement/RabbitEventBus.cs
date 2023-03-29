using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaServicios.RabbitMQ.Bus.BusRabbit;
using TiendaServicios.RabbitMQ.Bus.Comandos;
using TiendaServicios.RabbitMQ.Bus.Eventos;

namespace TiendaServicios.RabbitMQ.Bus.Implement
{
    internal class RabbitEventBus : IRabbitEventBus
    {
        public Task EnviarComando<T>(T omando) where T : Comando
        {
            throw new NotImplementedException();
        }

        public void Publich<T>(T evento) where T : Evento
        {
            throw new NotImplementedException();
        }

        public void Subscribe<T, TH>()
            where T : Evento
            where TH : IEventoManejador<T>
        {
            throw new NotImplementedException();
        }
    }
}
