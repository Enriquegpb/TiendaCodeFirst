using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryVentasTienda
    {
        public Task<List<Ventas>> GetVentasAsync();
        public Task<Ventas> DetallesVentaAsync(int id);
        public Task<List<VentaTiendaDTO>> GetVentasTiendaAsync();
        public Task<List<VentaTiendaDTO>> GetVentasProductoTiendaAsync(int idProducto);
        public Task<VentaTiendaDTO> DetallesVentaTiendaAsync(int id);
        //public Task<VentaTiendaDTO> DetallesVentaProductoTiendaAsync(int idProducto);
        public Task DeleteVentaAsync(int id);
        public Task EditVentaAsync(Ventas venta);
        public Task NuevaVentaAsync(Ventas venta);
        public Task NuevaVentaTiendaAsync(NuevaVentaDTO venta);
        public Task EditVentaTiendaAsync(EditVentaDTO venta);
    }
}
