using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class TotvsContext : DbContext
    {
        public TotvsContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Cliente> Cliente { get; set; }
        DbSet<PuntoVenta> PuntoVenta { get; set; }
        DbSet<Transaccion> Transaccion { get; set; }
    }
}
