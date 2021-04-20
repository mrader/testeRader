using Model.Entidades;
using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ItransaccionService
    {
        List<NotaDto> GetChange(int empresaId, int diaSemanaId, decimal importeAPagar, decimal importeRealPagado);
    }
}
