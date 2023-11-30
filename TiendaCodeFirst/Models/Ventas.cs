using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaCodeFirst.Models
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }
        [ForeignKey(nameof(Producto))]
        public int IdProducto { get; set; }
        public DateTime FechaVenta { get; set; }
        public double PvpUnitario { get; set; }
        public int Descuento { get; set; }
        public int UnidadesVenta { get; set; }
        public double Importe { get; set; }
        [MaxLength(20)]
        public Producto Producto { get; set; }
    }
}
