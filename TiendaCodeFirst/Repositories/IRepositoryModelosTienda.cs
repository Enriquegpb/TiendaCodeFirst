using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public interface IRepositoryModelosTienda
    {
        public Task<List<Modelos>> GetModelosAsync();
    }
}
