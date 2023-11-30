namespace TiendaCodeFirst.Data.Dtos
{
    public class EditVentaDTO
    {
        public int IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public double PvpUnitario { get; set; }
        public int Descuento { get; set; }
        public int UnidadesVenta { get; set; }
        public double Importe { get; set; }
    }
}
