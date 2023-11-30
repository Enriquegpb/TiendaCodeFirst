using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaCodeFirst.Models
{
    [Index(nameof(IdModelo), IsUnique = true)]
    public class Producto
    {
        public Producto()

        {

            Lineas = new Collection<LineaPedido>();

        }
        [Key]
        public int IdProducto { get; set; }
        [ForeignKey(nameof(Objeto))]
        public int IdObjeto { get; set; }
        [ForeignKey(nameof(Marca))]
        public int  IdMarca { get; set; }
        [ForeignKey(nameof(Categoria))]
        public int  IdCategoria { get; set; } 
        [ForeignKey(nameof(Modelo))]
        public int  IdModelo { get; set; }
        [StringLength(200)]  
        [MaxLength(200)]
        public string DescripcionComercial { get; set; }  
        [StringLength(200)]
        [MaxLength(200)]
        public string DescripcionTecnica { get; set; }
        public double Pvp {  get; set; }
        [Range(1,100)]
        public int Stock { get; set; }
        [Range(1,100)]
        public int StockMinimo { get; set; }
        public int Iva { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public virtual ICollection<LineaPedido> Lineas { get; set; }
        public virtual Objetos Objeto { get; set; }
        public virtual Categorias Categoria {  get; set; }
        public virtual Marcas Marca { get; set; }
        public virtual Modelos Modelo { get; set; }
        [StringLength(50)]
        [MaxLength(50)]
        public string Imagen { get; set; }
    }
}
