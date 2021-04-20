using Infraestructura;
using Infrastructure.Context;
using Infrastructure.Repositories.Interfaces;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class PuntoVentaRepository : RepositoryBase<PuntoVenta>, IPuntoVentaRepository
    {
        public PuntoVentaRepository(TotvsContext dataContext)
            : base(dataContext)
        {
        }
    }
}
