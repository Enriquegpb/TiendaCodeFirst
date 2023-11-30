using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryLineaPedidoTienda
    {
        public Task<List<LineaPedido>> ObtenerLineasPedidosAsync();
        public Task<LineaPedido> InformacionLineaPedidosAsync(int id);
        public Task AgregarLineaPedidoAsync(LineaPedido linea);
        public Task ModificarLineaPedidoAsync(LineaPedido linea);
        public Task EliminarLineaPedidoAsync(int id);
        
    }
}
