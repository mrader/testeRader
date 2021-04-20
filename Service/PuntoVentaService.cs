using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PuntoVentaService : IPuntoVentaService
    {
        public Task<Transaccion> GetChange(int clienteId, int puntoVentaId, decimal importeAPagar, decimal importeRealPagado)
        {
            throw new NotImplementedException();
        }
    }
}
