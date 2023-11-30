namespace TiendaCodeFirst.Data.Dtos
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string DescripcionComercial { get; set; }
        public string DescripcionTecnica { get; set; }
        public double Pvp { get; set; }
        public int Iva { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public bool Activo { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Objeto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
    }
}
