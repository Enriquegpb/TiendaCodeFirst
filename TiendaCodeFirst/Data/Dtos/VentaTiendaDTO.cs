namespace TiendaCodeFirst.Data.Dtos
{
    public class VentaTiendaDTO
    {
        public int IdVenta { get; set; }
        public string ProductoVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public double PvpUnitario { get; set; }
        public int Descuento { get; set; }
        public int UnidadesVenta { get; set; }
        public double Importe { get; set; }
    }
}
