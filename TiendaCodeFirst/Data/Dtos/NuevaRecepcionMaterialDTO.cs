namespace TiendaCodeFirst.Data.Dtos
{
    public class NuevaRecepcionMaterialDTO
    {
        public int IdProvedor {  get; set; }
        public int IdProducto { get; set; }
        public int CantidadPedida { get; set; }
        public int CantidadRecibida { get; set; }
        public DateTime Fecha { get; set; }

    }
}
