using TiendaCodeFirst.Data.Dtos;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryLogTienda
    {
        public Task<List<RegistroPedidosLogsDTO>> GetLogRecepcionProductos(int idProducto);
        
    }
}
