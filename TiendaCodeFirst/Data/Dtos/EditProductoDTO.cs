namespace TiendaCodeFirst.Data.Dtos
{
    public class EditProductoDTO
    {
        public int IdProducto { get; set; }
        public string DescripcionComercial { get; set; }
        public string DescripcionTecnica { get; set; }
        public int Iva { get; set; }
        public double Pvp { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdObjeto { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
