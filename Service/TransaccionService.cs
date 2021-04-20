using Infraestructura;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service
{
    public class TransaccionService : ItransaccionService
    {
        private IRepositoryWrapper _repoWrapper;

        public TransaccionService(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public List<NotaDto> GetChange(int clienteId, int puntoVentaId, decimal importeAPagar, decimal importeRealPagado)
        {
            try
            {

                List<NotaDto> ln = new List<NotaDto>();

                if (importeRealPagado >= importeAPagar)
                {

                    Cliente cl = _repoWrapper.Cliente.Get(clienteId);
                    
                    // no existe el cliente
                    if (cl == null) {
                        ln.Add(new NotaDto("Cliente no existente.", 0));
                        return ln;
                    }


                    PuntoVenta pv = _repoWrapper.PuntoVenta.Get(puntoVentaId);

                    // no existe punto de venta
                    if (pv == null)
                    {
                        ln.Add(new NotaDto("Punto de Venta no existente.", 0));
                        return ln;
                    }

                    Transaccion tr = new Transaccion();
                    tr.ImporteTotalAPagar = importeAPagar;
                    tr.ImporteRealPagado = importeRealPagado;
                    tr.cliente = cl;
                    tr.puntoVenta = pv;

                    _repoWrapper.Transaccion.Create(tr);
                    _repoWrapper.Save();

                    ln = calcularCambio(importeAPagar, importeRealPagado);
                }
                else
                {
                    ln.Add(new NotaDto("No es posible realizar la transaccion, el importe pagado es menor al importe a pagar", 0));
                }

                return ln;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private List<NotaDto> calcularCambio(decimal aPagar, decimal pagado) 
        {
            List<NotaDto> ln = new List<NotaDto>();
            decimal diff = pagado - aPagar;

            if (diff >= 100) {
                ln.Add(new NotaDto("R$ 100,00", (int)(diff / 100)));
                diff = diff % 100;
            }
            
            if(diff >= 50) {
                ln.Add(new NotaDto("R$ 50,00", (int)(diff / 50)));
                diff = diff % 50;
            }

            if (diff >= 20) {
                ln.Add(new NotaDto("R$ 20,00", (int)(diff / 20)));
                diff = diff % 20;
            }
            
            if (diff >= 10) {
                ln.Add(new NotaDto("R$ 10,00", (int)(diff / 10)));
                diff = diff % 10;
            }
            
            if (diff >= 0.5M) {
                ln.Add(new NotaDto("R$ 0,50", (int)(diff / 0.5M)));
                diff = diff % 0.5M;
            }
            
            if (diff >= 0.1M) {
                ln.Add(new NotaDto("R$ 0,10", (int)(diff / 0.1M)));
                diff = diff % 0.1M;
            }
            
            if (diff >= 0.05M) {
                ln.Add(new NotaDto("R$ 0,05", (int)(diff / 0.05M)));
                diff = diff % 50;
            }
            
            if (diff >= 0.01M) {
                ln.Add(new NotaDto("R$ 0,01", (int)(diff / 0.01M)));
                diff = diff % 0.01M;
            }

            if(ln.Count == 0)
                ln.Add(new NotaDto("Pago Exacto.", 0));

            return ln;
        }

    }

}
