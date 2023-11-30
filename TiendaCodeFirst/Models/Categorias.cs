using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        [StringLength(25)]
        public string Descripcion { get; set;}
    }
}
