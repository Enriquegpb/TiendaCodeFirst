using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class LineaPedidoSeed : IEntityTypeConfiguration<LineaPedido>
    {
        public void Configure(EntityTypeBuilder<LineaPedido> builder)
        {
            builder.HasData(
                new LineaPedido
                {
                    LineaPedidoId = 1,
                    PedidoId = 1,
                    ProductoId = 1,
                    Unidades = 10,
                },
                new LineaPedido
                {
                    LineaPedidoId = 2,
                    PedidoId = 2,
                    ProductoId = 2,
                    Unidades = 4,
                }
                );
        }
    }
}
