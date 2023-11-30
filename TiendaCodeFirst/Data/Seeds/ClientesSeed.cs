using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class ClientesSeed : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(
                new Cliente
                {
                    ClienteId = 1,
                    Nombre = "Cliente1",
                    Pedidos = null
                },
                new Cliente
                {
                    ClienteId = 2,
                    Nombre = "Cliente3",
                    Pedidos = null
                }, 
                new Cliente
                {
                    ClienteId = 3,
                    Nombre = "Cliente4",
                    Pedidos = null
                }
                //    Pedidos = new List<Pedido>
                // 2023-09-18T11:30:25Z   {
                //        new Pedido
                //        {
                //            ClienteId = 1,
                //            FechaCreacion = DateTime.UtcNow,
                //            PedidoId = 1,
                //            Cliente = null,
                //            Lineas = new List<LineaPedido>
                //            {
                //                new LineaPedido
                //                {
                //                    LineaPedidoId = 1,
                //                    PedidoId = 1,
                //                    ProductoId = 1,
                //                    Pedido = null,
                //                    Producto = null,
                //                    Unidades = 1
                //                }
                //            }
                           
                //        }
                //    }
                    
                //}
                );
        }
    }
}
