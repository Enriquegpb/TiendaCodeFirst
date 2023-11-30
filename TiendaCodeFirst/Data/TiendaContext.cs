using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TiendaCodeFirst.Data.Seeds;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data
{
    public class TiendaContext: DbContext
    {

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Producto>()
        .HasOne(p => p.Modelo)
        .WithMany()
        .IsRequired();

            builder.ApplyConfiguration(new ClientesSeed());
            builder.ApplyConfiguration(new LineaPedidoSeed());
            builder.ApplyConfiguration(new PedidoSeed());
            builder.ApplyConfiguration(new ProductoSeed());
            builder.ApplyConfiguration(new CategoriasSeed());
            builder.ApplyConfiguration(new ObjetosSeed());
            builder.ApplyConfiguration(new ModelosSeed());
            builder.ApplyConfiguration(new MarcasSeed());
            builder.ApplyConfiguration(new LogRegistroSeed());
            builder.ApplyConfiguration(new VentasSeed());
            builder.ApplyConfiguration(new RecepcionSeed());
            
            
        }

            public DbSet<Cliente> Clientes { get; set; }
 
            public DbSet<Objetos> Objetos { get; set; }
            public DbSet<Marcas> Marcas { get; set; }
            public DbSet<Categorias> Categorias { get; set; }
            public DbSet<Producto> Productos { get; set; }
            public DbSet<Ventas> Ventas { get; set; }
            public DbSet<Pedido> Pedidos { get; set; }
            public DbSet<LogPedidosProductos> Logs { get; set; }
            public DbSet<Recepcion> Recepciones { get; set; }
            public DbSet<LineaPedido> LineasPedido { get; set; }
            public DbSet<Modelos> Modelos { get; set; }

    }
}
