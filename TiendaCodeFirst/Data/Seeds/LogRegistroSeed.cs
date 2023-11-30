using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class LogRegistroSeed : IEntityTypeConfiguration<LogPedidosProductos>
    {
        public void Configure(EntityTypeBuilder<LogPedidosProductos> builder)
        {
            builder.HasData(
                new LogPedidosProductos
                {
                    IdLog = 1,
                    IdProducto = 2,
                    ProductoPedidoName = "Portátiles",
                    Cantidad = 10,
                    Categoria = "Tecnología",
                    Marca = "Samsung",
                    ProductoPedido = null,
                    FechaRegistro = DateTime.UtcNow,
                    
                }, new LogPedidosProductos
                {
                    IdLog = 2,
                    IdProducto = 6,
                    ProductoPedidoName = "Zapatos",
                    Cantidad = 5,
                    Categoria = "Deporte",
                    Marca = "Nike",
                    ProductoPedido = null,
                    FechaRegistro = DateTime.UtcNow,
                }, new LogPedidosProductos
                {
                    IdLog = 3,
                    IdProducto = 3,
                    ProductoPedidoName = "Tienda Campaña",
                    Cantidad = 5,
                    Categoria = "Montaña",
                    Marca = "Decathlon",
                    ProductoPedido = null,
                    FechaRegistro = DateTime.UtcNow,
                }
              
                );
            
        }
    }
}
