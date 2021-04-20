using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Totvs.Dtos
{
    public class PostTransaccionDto
    {
        public int idCliente { get; set; }
        public int idPuntoVenta { get; set; }
        public decimal importeAPagar { get; set; }
        public decimal importePagado { get; set; }
    }
}
