using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Softecnologia.Models;

namespace Softecnologia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoriaProducto> CategoriaProducto {get; set;}

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Compra> Compra {get; set;}

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<Producto> Producto {get; set;}

        public DbSet<Rol>  Rol { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
