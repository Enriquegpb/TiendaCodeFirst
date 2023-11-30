using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Modelos
    {
        [Key]
        public int IdModelo { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
