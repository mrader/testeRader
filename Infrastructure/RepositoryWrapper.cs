using Infrastructure.Context;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Interfaces;

namespace Infraestructura
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private TotvsContext _dataContext;

        private ITransaccionRepository _transaccion;
        private IClienteRepository _cliente;
        private IPuntoVentaRepository _puntoVenta;

        public ITransaccionRepository Transaccion
        {
            get
            {
                if (_transaccion == null)
                {
                    _transaccion = new TransaccionRepository(_dataContext);
                }

                return _transaccion;
            }
        }

        public IClienteRepository Cliente
        {
            get
            {
                if (_cliente == null)
                {
                    _cliente = new ClienteRespository(_dataContext);
                }

                return _cliente;
            }
        }

        public IPuntoVentaRepository PuntoVenta
        {
            get
            {
                if (_puntoVenta == null)
                {
                    _puntoVenta = new PuntoVentaRepository(_dataContext);
                }

                return _puntoVenta;
            }
        }

        public RepositoryWrapper(TotvsContext repositoryContext)
        {
            _dataContext = repositoryContext;
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}
