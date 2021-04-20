using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entidades
{
    public class Transaccion
    {
        public int Id { get; set; }
        public decimal ImporteTotalAPagar { get; set; }
        public decimal ImporteRealPagado { get; set; }

        public virtual Cliente cliente { get; set; }
        public virtual PuntoVenta puntoVenta { get; set; }
    }
}
