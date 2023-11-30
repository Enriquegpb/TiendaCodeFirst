namespace TiendaCodeFirst.Data.Dtos
{
    public class PedidoClienteDTO
    {

        public int IdPedido { get; set;}
        public string NombrePedido { get; set;}
        public double Pvp {  get; set;}
        public string NombreCliente { get; set;}
        public DateTime FechaCreacion { get; set;}
    }
}
