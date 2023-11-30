using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryClientesTienda
    {
        public Task<Cliente> ExisteClienteAsync(LoginClienteModel model);
        public Task<List<NPedidosClientesDTO>> ObtenerNPedidosClientesAsync();
        public Task<List<Cliente>> ObtenerPedidosClientesAsync();
        public Task<List<Cliente>> ObtenerPedidosClientesLineasAsync();
        public Task<List<Cliente>> ObtenerClientesAsync();
        public Task<Cliente> DetallesClienteAsync(int id);
        public Task AgregarClienteAsync(Cliente cliente);
        public Task ModificarClienteAsync(Cliente cliente);
        public Task EliminarClienteAsync(int id);
    }
}
