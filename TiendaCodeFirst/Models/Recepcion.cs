using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaCodeFirst.Models
{
    public class Recepcion
    {
        [Key]
        public int Referencia { get; set; }
        [ForeignKey(nameof(ProductoRecepcion))]
        public int IdProducto { get; set; }
        public int IdProvedor { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadPedida { get; set; }
        public int CantidadRecibida { get; set; }
        public virtual Producto ProductoRecepcion { get; set; }

    }
}
