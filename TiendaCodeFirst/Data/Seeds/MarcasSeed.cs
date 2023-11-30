using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class MarcasSeed : IEntityTypeConfiguration<Marcas>
    {
        public void Configure(EntityTypeBuilder<Marcas> builder)
        {
            builder.HasData(
               new Marcas
               {
                   IdMarca = 1,
                   Descripcion = "HP"
               }, new Marcas
               {
                   IdMarca = 2,
                   Descripcion = "Samsung"
               }, new Marcas
               {
                   IdMarca = 3,
                   Descripcion = "NIKE"
               }, new Marcas
               {
                   IdMarca = 4,
                   Descripcion = "Decathlon"
               }, new Marcas
               {
                   IdMarca = 5,
                   Descripcion = "Casio"
               }, new Marcas
               {
                   IdMarca = 6,
                   Descripcion = "Leroy Merlin"
               }, new Marcas
               {
                   IdMarca = 7,
                   Descripcion = "Auchan"
               }
               );
        }
    }
}
