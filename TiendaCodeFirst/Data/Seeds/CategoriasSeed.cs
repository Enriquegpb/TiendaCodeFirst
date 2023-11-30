using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class CategoriasSeed : IEntityTypeConfiguration<Categorias>
    {
        public void Configure(EntityTypeBuilder<Categorias> builder)
        {
            builder.HasData(
                new Categorias
                {
                    IdCategoria = 1,
                    Descripcion = "Hogar"
                }, new Categorias
                {
                    IdCategoria = 2,
                    Descripcion = "Deporte"
                }, new Categorias
                {
                    IdCategoria = 3,
                    Descripcion = "Tecnología"
                }, new Categorias
                {
                    IdCategoria = 4,
                    Descripcion = "Montaña"
                }
                //}, new Categorias
                //{
                //    IdCategoria = 5,
                //    Descripcion = "Coleccion"
                //}
                );
            
        }
    }
}
