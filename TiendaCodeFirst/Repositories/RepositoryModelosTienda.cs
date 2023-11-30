using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryModelosTienda : IRepositoryModelosTienda
    {
        private TiendaContext context;
        public RepositoryModelosTienda(TiendaContext context)
        {
            this.context = context;
        }

        public async Task<List<Modelos>> GetModelosAsync()
        {
            return await this.context.Modelos.ToListAsync();
        }
    }
}
