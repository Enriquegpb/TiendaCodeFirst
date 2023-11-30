using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryCategoriasTienda
    {
        public Task<List<Categorias>> GetCategoriasAsync();
        public Task<Categorias> DetallesCategoriaAsync(int idCategoria);
        public Task DeleteCategoriaAsync(int idCategoria);
        public Task NuevaCategoriaAsync(Categorias categoria);
        public Task EditCategoriaAsync(Categorias categoria);
        public Task<List<string>> ObtenerNombresCategorias();
        public Task<int> ObtenerIdCategoriaAsync(string categoria);
    }
}
