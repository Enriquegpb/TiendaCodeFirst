using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Dtos
{
    public class ProductoPedidosStockDTO
    {
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public bool Activo { get; set; }
    }
}
