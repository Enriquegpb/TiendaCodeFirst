using TiendaCodeFirst.Data.Dtos;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryRecepcionMaterialTienda
    {
        public Task<List<RecepcionDTO>> GetRecepcionProductoAsync(int idProducto);
        //public Task NuevaRecepcionMaterialProductos(NuevaRecepcionMaterialDTO nuevaRecepcion);
    }
}
