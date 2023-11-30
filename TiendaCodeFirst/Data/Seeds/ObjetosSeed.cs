using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class ObjetosSeed : IEntityTypeConfiguration<Objetos>
    {
        public void Configure(EntityTypeBuilder<Objetos> builder)
        {
            builder.HasData(
               new Objetos
               {
                   IdObjeto = 1,
                   Descripcion = "Movil"
               }, new Objetos
               {
                   IdObjeto = 2,
                   Descripcion = "Portátiles"
               }, new Objetos
               {
                   IdObjeto = 3,
                   Descripcion = "Tienda Campaña"
               }, new Objetos
               {
                   IdObjeto = 4,
                   Descripcion = "Mesas"
               }, new Objetos
               {
                   IdObjeto = 5,
                   Descripcion = "Zapatillas"
               }
               );
        }
    }
}
