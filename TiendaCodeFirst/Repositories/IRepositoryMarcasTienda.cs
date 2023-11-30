using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryMarcasTienda
    {
        public Task<List<Marcas>> GetMarcasAsync();
        public Task<Marcas> DetallesMarcaAsync(int idMarca);
        public Task DeleteMarcaAsync(int idMarca);
        public Task NuevaMarcaAsync(Marcas marca);
        public Task EditMarcaAsync(Marcas marca);
        public Task<List<string>> ObtenerNombresMarcas();
        public Task<int> ObtenerIdMarcaAsync(string marca);

    }
}
