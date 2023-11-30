using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class ProductoSeed : IEntityTypeConfiguration<Producto>
    {
        
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasData(
                new Producto
                {
                    IdProducto = 1,
                    IdObjeto = 1,
                    IdCategoria = 1,
                    IdMarca = 1,
                    DescripcionTecnica = "Mi descripcion Tecnica",
                    DescripcionComercial = "Mi descripcion Comercial",
                    Pvp = 5,
                    Stock = 4,
                    StockMinimo = 7,
                    Iva = 15,
                    Activo = true,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo = null,
                    IdModelo = 1,
                    Imagen = "imagen1.png"
                },
                new Producto
                {
                    IdProducto = 2,
                    IdObjeto = 2,
                    IdCategoria = 2,
                    IdMarca = 2,
                    DescripcionTecnica = "Mi descripcion Tecnica",
                    DescripcionComercial = "Mi descripcion Comercial",
                    Pvp = 3,
                    Stock = 4,
                    StockMinimo = 2,
                    Iva = 9,
                    Activo = false,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo  = null,
                    IdModelo = 2,
                    Imagen = "imagen2.png"
                },
                new Producto
                {
                    IdProducto = 3,
                    IdObjeto = 3,
                    IdCategoria = 3,
                    IdMarca = 3,
                    DescripcionTecnica = "Tiene un volumen de 5 cubicos, guia de motaje fácil.... ",
                    DescripcionComercial = "Tiene un capacidad de dos personas, ideal para campementos....",
                    Pvp = 12,
                    Stock = 4,
                    StockMinimo = 2,
                    Iva = 7,
                    Activo = true,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo = null,
                    IdModelo = 3,
                    Imagen = "imagen3.png"
                },
                new Producto
                {
                    IdProducto = 4,
                    IdObjeto = 4,
                    IdCategoria = 4,
                    IdMarca = 4,
                    DescripcionTecnica = "Producto de laraga duracion que tiene mucha autonomia y de las mejores prestaciones tecnologicas ",
                    DescripcionComercial = "Te lo puedes llevar a la montaña de vacaciones a otras ciudades...",
                    Pvp = 2,
                    Stock = 4,
                    StockMinimo = 3,
                    Iva = 3,
                    Activo = true,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo = null,
                    IdModelo = 4,
                    Imagen = "imagen4.png"
                },
                new Producto
                {
                    IdProducto = 5,
                    IdObjeto = 4,
                    IdCategoria = 3,
                    IdMarca = 5,
                    DescripcionTecnica = "Este producto ofrece todas las mejores prestaciones de la tecnología actual....",
                    DescripcionComercial = "Todos los clientes esstan muy satisfechos con el producto, algunos hasta consideran que tiene demasiona para lo que es....",
                    Pvp = 2,
                    Stock = 4,
                    StockMinimo = 6,
                    Iva = 22,
                    Activo = true,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo = null,
                    IdModelo = 5,
                    Imagen = "imagen5.png"
                },
                new Producto
                {
                    IdProducto = 6,
                    IdObjeto = 4,
                    IdCategoria = 1,
                    IdMarca = 7,
                    DescripcionTecnica = "Folios de papel blancos para imprimir, colegio, hacer manualidades....  ",
                    DescripcionComercial = "Folios de papel blancos para imprimir de oficiona de 80 g de grosor....",
                    Pvp = 2,
                    Stock = 4,
                    StockMinimo = 2,
                    Iva = 15,
                    Activo = true,
                    FechaAlta = DateTime.UtcNow,
                    FechaModificacion = DateTime.UtcNow,
                    Categoria = null,
                    Marca = null,
                    Objeto = null,
                    Modelo = null,
                    IdModelo = 6,
                    Imagen = "imagen6.png"
                }
                );
        }
    }
}
