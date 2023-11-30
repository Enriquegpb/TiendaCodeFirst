using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryLogTienda : IRepositoryLogTienda
    {
        private TiendaContext context;
        public RepositoryLogTienda(TiendaContext context)
        {
            this.context = context;
        }
        public async Task<List<RegistroPedidosLogsDTO>> GetLogRecepcionProductos(int idProducto)
        {
            var consulta =
                (from registros in this.context.Logs
                 join productos in this.context.Productos
                 on registros.IdProducto equals productos.IdProducto
                 where registros.IdProducto == idProducto
                 select new RegistroPedidosLogsDTO
                 {
                     IdLog = registros.IdLog,
                     IdProducto = registros.IdProducto,
                     Cantidad = registros.Cantidad,
                     Categoria = registros.Categoria,
                     FechaRegistro = registros.FechaRegistro,
                     Marca = registros.Marca,
                     ProductoPedidoName = registros.ProductoPedidoName
                 }
                 );
            return await consulta.ToListAsync();
        }
    }
}
