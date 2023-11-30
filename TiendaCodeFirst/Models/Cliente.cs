using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Cliente
    {
        public Cliente()

        {

            Pedidos = new Collection<Pedido>();

        }
        [Key]
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
