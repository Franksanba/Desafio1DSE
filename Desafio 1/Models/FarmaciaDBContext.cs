using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio_1.Models
{
    public class FarmaciaDBContext : DbContext
    {
        public FarmaciaDBContext() : base("FarmaciaDBContext")
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
    }
}