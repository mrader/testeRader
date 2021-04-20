using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IPuntoVentaService
    {
        Task<Transaccion> GetChange(int empresaId, int diaSemanaId, decimal importeAPagar, decimal importeRealPagado);
    }
}
