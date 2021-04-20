using Infraestructura;
using Infrastructure.Context;
using Infrastructure.Repositories.Interfaces;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class TransaccionRepository : RepositoryBase<Transaccion>, ITransaccionRepository
    {
        public TransaccionRepository(TotvsContext dataContext)
            : base(dataContext)
        {
        }
    }
}
