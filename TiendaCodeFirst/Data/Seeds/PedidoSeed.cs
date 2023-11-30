using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class PedidoSeed : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasData(
                new Pedido
                {
                    ClienteId = 1,
                    FechaCreacion = DateTime.UtcNow,
                    PedidoId = 1,
                    Lineas = null
                } ,
                 new Pedido
                {
                    ClienteId = 2,
                    FechaCreacion = DateTime.UtcNow,
                    PedidoId = 2,
                    Lineas = null
                }
                );
        }
    }
}
