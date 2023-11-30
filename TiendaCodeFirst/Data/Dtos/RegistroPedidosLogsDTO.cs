namespace TiendaCodeFirst.Data.Dtos
{
    public class RegistroPedidosLogsDTO
    {
        public int IdLog { get; set; }
        public int IdProducto { get; set; }
        public string ProductoPedidoName { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
