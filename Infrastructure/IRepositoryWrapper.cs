using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura
{
    public interface IRepositoryWrapper
    {
        ITransaccionRepository Transaccion { get; }
        IClienteRepository Cliente { get; }
        IPuntoVentaRepository PuntoVenta { get; }
        void Save();
    }
}
