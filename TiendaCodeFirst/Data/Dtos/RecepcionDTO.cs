namespace TiendaCodeFirst.Data.Dtos
{
    public class RecepcionDTO
    {
        public int Referencia { get; set; }
        public string Producto { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadPedida { get; set; }
        public int CantidadRecibida{ get; set; }
    }
    
}
