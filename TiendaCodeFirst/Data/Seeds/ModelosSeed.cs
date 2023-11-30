using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Seeds
{
    public class ModelosSeed : IEntityTypeConfiguration<Modelos>
    {
        public void Configure(EntityTypeBuilder<Modelos> builder)
        {
            builder.HasData(
              new Modelos
              {
                  IdModelo = 1,
                  Descripcion = "HP Spectre"
              },
              new Modelos
              {
                  IdModelo = 2,
                  Descripcion = "HP Pavilion"
              },
              new Modelos
              {
                  IdModelo = 3,
                  Descripcion = "HP Envy"
              },
              new Modelos
              {
                  IdModelo = 4,
                  Descripcion = "Galaxy Note"
              },
              new Modelos
              {
                  IdModelo = 5,
                  Descripcion = "Galaxy Z Flip"
              },
              new Modelos
              {
                  IdModelo = 6,
                  Descripcion = "Galaxy S"
              },
              new Modelos
              {
                  IdModelo = 7,
                  Descripcion = "Galaxy A"
              },
              new Modelos
              {
                  IdModelo = 8,
                  Descripcion = "Casio FX-991SPX"
              },
              new Modelos
              {
                  IdModelo = 9,
                  Descripcion = "Casio fx-82MS"
              },
              new Modelos
              {
                  IdModelo = 10,
                  Descripcion = "Leggins"
              },
              new Modelos
              {
                  IdModelo = 11,
                  Descripcion = "Pantalón mom jean"
              },
              new Modelos
              {
                  IdModelo = 12,
                  Descripcion = "Pantalón joggers"
              },
              new Modelos
              {
                  IdModelo = 13,
                  Descripcion = "cuello redondo"
              },
              new Modelos
              {
                  IdModelo = 14,
                  Descripcion = "cuello ancho"
              },
              new Modelos
              {
                  IdModelo = 15,
                  Descripcion = "polos"
              },
              new Modelos
              {
                  IdModelo = 16,
                  Descripcion = "Nike Air Max 95 Ultra"
              },
              new Modelos
              {
                  IdModelo = 17,
                  Descripcion = "Nike Go FlyEase"
              },
              new Modelos
              {
                  IdModelo = 18,
                  Descripcion = "Nike Wearallday"
              },
              new Modelos
              {
                  IdModelo = 19,
                  Descripcion = "ADIDAS N-5923"
              },
              new Modelos
              {
                  IdModelo = 20,
                  Descripcion = "ADIDAS NMD"
              },
              new Modelos
              {
                  IdModelo = 21,
                  Descripcion = "ADIDAS SWIFT RUN"
              },
              new Modelos
              {
                  IdModelo = 22,
                  Descripcion = "ADIDAS I-5923"
              },
              new Modelos
              {
                  IdModelo = 23,
                  Descripcion = "ADIDAS YUNG 96"
              },
              new Modelos
              {
                  IdModelo = 24,
                  Descripcion = "ADIDAS FALCON"
              },
              new Modelos
              {
                  IdModelo = 25,
                  Descripcion = "ADIDAS AS 520"
              },
              new Modelos
              {
                  IdModelo = 26,
                  Descripcion = "ADIDAS ZX 2K BOOST"
              },
              new Modelos
              {
                  IdModelo = 27,
                  Descripcion = "ADIDAS NMD V3"
              },
              new Modelos
              {
                  IdModelo = 28,
                  Descripcion = "ADIDAS ZX22"
              },
              new Modelos
              {
                  IdModelo = 29,
                  Descripcion = "ADIDAS ADI2000 X"
              }
              );
        }
    }
}
