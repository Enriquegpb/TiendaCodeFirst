using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class VentasSeed : IEntityTypeConfiguration<Ventas>
    {
        public void Configure(EntityTypeBuilder<Ventas> builder)
        {
            builder.HasData(
               new Ventas
               {
                  IdVenta = 1,
                  IdProducto = 3,
                  FechaVenta = DateTime.UtcNow,
                  Descuento = 3,
                  Importe = 23.45,
                  PvpUnitario = 30.25,
                  UnidadesVenta = 40,
               },new Ventas
               {
                  IdVenta = 2,
                  IdProducto = 4,
                  //FechaVenta = DateTime.UtcNow,
                  Descuento = 15,
                  Importe = 17.99,
                  PvpUnitario = 20.50,
                  UnidadesVenta = 20,
               },new Ventas
               {
                  IdVenta = 3,
                  IdProducto = 2,
                  FechaVenta = DateTime.UtcNow,
                  Descuento = 21,
                  Importe = 30.60,
                  PvpUnitario = 38.50,
                  UnidadesVenta = 15,
               },new Ventas
               {
                  IdVenta = 4,
                  IdProducto = 5,
                  FechaVenta = DateTime.UtcNow,
                  Descuento = 5,
                  Importe = 28.40,
                  PvpUnitario = 30.25,
                  UnidadesVenta = 120,
               },new Ventas
               {
                  IdVenta = 5,
                  IdProducto = 1,
                  FechaVenta = DateTime.UtcNow,
                  Descuento = 7,
                  Importe = 15.20,
                  PvpUnitario = 18.75,
                  UnidadesVenta = 45,
               },new Ventas
               {
                  IdVenta = 6,
                  IdProducto = 3,
                  FechaVenta = DateTime.UtcNow,
                  Descuento = 9,
                  Importe = 29.60,
                  PvpUnitario = 33.66,
                  UnidadesVenta = 66,
               }
               );
        }
    }
}
