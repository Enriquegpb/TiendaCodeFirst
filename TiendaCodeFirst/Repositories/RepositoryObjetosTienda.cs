using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryObjetosTienda : IRepositoryObjetosTienda
    {
        private TiendaContext context;
        public RepositoryObjetosTienda(TiendaContext context)
        {
            this.context = context;
        }
        public async Task DeleteObjetoAsync(int idObjeto)
        {
            Objetos objeto = await this.DetallesObjetoAsync(idObjeto);
            this.context.Objetos.Remove(objeto);
            await this.context.SaveChangesAsync();
        }

        public async Task<Objetos> DetallesObjetoAsync(int idObjeto)
        {
            Objetos objeto = await this.context.Objetos.FirstOrDefaultAsync(o => o.IdObjeto == idObjeto);
            return objeto;
        }

        public async Task<List<Objetos>> GetObjetosAsync()
        {
            return await this.context.Objetos.ToListAsync();
        }

        public async Task EditObjetoAsync(Objetos objeto)
        {
            Objetos objetoEdit = await this.DetallesObjetoAsync(objeto.IdObjeto);
            objetoEdit.Descripcion = objeto.Descripcion;
            await this.context.SaveChangesAsync();
        }

        public async Task NuevoObjetoAsync(Objetos objeto)
        {
            Objetos objetonuevo = new Objetos
            {
                Descripcion = objeto.Descripcion,
            };
            await this.context.Objetos.AddAsync(objetonuevo);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<string>> ObtenerNombresObjetos()
        {
            var consulta = (from datos in this.context.Objetos
                            select datos.Descripcion).Distinct();
            return await consulta.ToListAsync();
        }

        public async Task<int> ObtenerIdProductoAsync(string producto)
        {
            var consulta = (from datos in this.context.Objetos
                            where producto == datos.Descripcion
                            select datos.IdObjeto
                            );
            return await consulta.FirstOrDefaultAsync();

        }
    }
}
