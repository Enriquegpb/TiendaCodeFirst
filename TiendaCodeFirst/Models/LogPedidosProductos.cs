using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaCodeFirst.Models
{
    public class LogPedidosProductos
    {
        [Key] 
        public int IdLog { get; set; }
        [ForeignKey(nameof(ProductoPedido))]
        public int IdProducto { get; set; }
        public string ProductoPedidoName { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public virtual Producto ProductoPedido { get; set; }

        
    }
}
