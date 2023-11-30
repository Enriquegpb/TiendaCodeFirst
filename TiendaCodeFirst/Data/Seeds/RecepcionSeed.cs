using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class RecepcionSeed : IEntityTypeConfiguration<Recepcion>
    {
        public void Configure(EntityTypeBuilder<Recepcion> builder)
        {
            builder.HasData(
               new Recepcion
               {
                   Referencia = 1,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 1,
                   IdProvedor = 1,
                   CantidadPedida = 15,
                   CantidadRecibida = 15
               }, new Recepcion
               {
                   Referencia = 2,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 2,
                   IdProvedor = 2,
                   CantidadPedida = 15,
                   CantidadRecibida = 15
               }, new Recepcion
               {
                   Referencia = 3,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 2,
                   IdProvedor = 3,
                   CantidadPedida = 40,
                   CantidadRecibida = 40
               }, new Recepcion
               {
                   Referencia = 4,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 2,
                   IdProvedor = 4,
                   CantidadPedida = 60,
                   CantidadRecibida = 60
               }, new Recepcion
               {
                   Referencia = 5,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 3,
                   IdProvedor = 4,
                   CantidadPedida = 80,
                   CantidadRecibida = 80
               }, new Recepcion
               {
                   Referencia = 6,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 4,
                   IdProvedor = 5,
                   CantidadPedida = 25,
                   CantidadRecibida = 25
               }, new Recepcion
               {
                   Referencia = 7,
                   Fecha = DateTime.UtcNow,
                   IdProducto = 4,
                   IdProvedor = 6,
                   CantidadPedida = 40,
                   CantidadRecibida = 40
               }
               );
        }
    }
}
