using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Pedido
    {
        public Pedido()

        {

            Lineas = new Collection<LineaPedido>();

        }
        [Key]
        public int PedidoId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int ClienteId { get; set; }

        //public virtual Cliente Cliente { get; set; }

        public virtual ICollection<LineaPedido> Lineas { get; set; }
    }
}
