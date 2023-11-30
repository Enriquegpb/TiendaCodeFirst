using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryObjetosTienda
    {
        public Task<List<Objetos>> GetObjetosAsync();
        public Task<Objetos> DetallesObjetoAsync(int idObjeto);
        public Task DeleteObjetoAsync(int idObjeto);
        public Task NuevoObjetoAsync(Objetos objeto);
        public Task EditObjetoAsync(Objetos objeto);
        public Task<List<string>> ObtenerNombresObjetos();
        public Task<int> ObtenerIdProductoAsync(string producto);
    }
}
