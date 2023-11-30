using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Dtos
{
    public class NuevoProductoDTO
    {
        //public int IdProducto { get; set; }
        public string DescripcionComercial { get; set; }
        public string DescripcionTecnica { get; set; }
        public int Iva { get; set; }
        public double Pvp { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public bool Activo { get; set; }
        public int IdMarca {  get; set; }
        public int IdCategoria { get; set; }
        public int IdObjeto { get; set; }
        public int IdModelo { get; set; }
        //public Marcas Marca { get; set; }
        //public Categorias Categoria { get; set; }
        //public Objetos Objeto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Imagen { get; set; }
    }
}
