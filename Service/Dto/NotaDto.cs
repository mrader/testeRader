using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Dtos
{
    public class NotaDto
    {
        public NotaDto(string nota, int cantidad) {

            Nota = nota;
            Cantidad = cantidad;
        }
        public string Nota { get; set; }
        public int Cantidad { get; set; }

    }
}
