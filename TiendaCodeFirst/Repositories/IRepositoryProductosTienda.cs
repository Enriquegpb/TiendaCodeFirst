using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryProductosTienda
    {
        public Task<ProductoDTO> DetallesProductoTiendaAsync(int id);
        public Task<List<ProductoDTO>> ObtenerProductosTiendaAsync();
        public Task<List<NProductosLineaPedidoDTO>> NProductosLineaPedidos();
        public Task<List<Producto>> ObtenerProductosLineasPedidoPrecio(int precio);
        public Task<List<Producto>> ObtenerProductosLineasAsync();
        public Task<List<Producto>> ObtenerProductosAsync();
        public Task<Producto> DetallesProductoAsync(int id);
        //public Task<Producto> DetallesProductoTiendaAsync(int id);
        public Task AgregarProductoAsync(Producto producto);
        public Task AgregarNuevoProductoAsync(NuevoProductoDTO producto);
        public Task ModificarProductoAsync(Producto producto);
        public Task ModificarProductoDTOAsync(EditProductoDTO producto);
        public Task EliminarProductoAsync(int id);
        public Task BajaProductoAsync(int id);
        public Task AgregarPedidoMaterialAsync(ProductoPedidosStockDTO producto);
        public Task RealizarRecepciónProducto(NuevaRecepcionMaterialDTO nuevaRecepcion, int numeroRegistro);
        public Task ModificarSotckProductoVentaAsync(int idProducto, int cantidad);
        public Task<LogPedidosProductos> GetRegistroRecepcion(int numeroRegistro);


    }
}
