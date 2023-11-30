using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class LineaPedido
    {
        [Key]
        public int LineaPedidoId { get; set; }

        public int PedidoId { get; set; }

        public int ProductoId { get; set; }

        public int Unidades { get; set; }

        //public virtual Pedido Pedido { get; set; }

        //public virtual Producto Producto { get; set; }
    }
}
