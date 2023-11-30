using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryPedidosTienda
    {
        public Task<List<Pedido>> ObtenerPedidosClientesCantidadMinLineasAsync(int unidades);
        public Task<List<Pedido>> ObtenerPedidosClienteAsync(int idCliente);
        public Task<List<PedidoClienteDTO>> ObtenerPedidosClienteProductosAsync(int idCliente);
        public Task<List<Pedido>> ObtenerPedidosLineasAsync();
        public Task<List<Pedido>> ObtenerPedidosAsync();
        public Task<Pedido> DetallesPedidoAsync(int id);
        public Task AgregarPedidoAsync(int idCliente, int idProducto);
        public Task<PedidoClienteDTO> DetallesPedidoClienteAsync(int idCliente, int idPedido);
        public Task ModificarPedidoAsync(Pedido pedido);
        public Task EliminarPedidoAsync(int id);
    }
}
