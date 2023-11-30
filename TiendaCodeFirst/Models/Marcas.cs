using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Marcas
    {
        [Key] 
        public int IdMarca { get; set; }
        [StringLength(25)]
        public string Descripcion { get; set; }
    }
}
