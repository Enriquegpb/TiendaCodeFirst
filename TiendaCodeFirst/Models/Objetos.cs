using System.ComponentModel.DataAnnotations;

namespace TiendaCodeFirst.Models
{
    public class Objetos
    {
        [Key]
        public int IdObjeto { get; set; }
        [StringLength(25)]
        public string Descripcion { get; set; }

    }
}
