using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryCategoriasTienda: IRepositoryCategoriasTienda
    {
        private TiendaContext context;
        public RepositoryCategoriasTienda(TiendaContext context)
        {
            this.context = context;
        }

        public async Task DeleteCategoriaAsync(int idCategoria)
        {
            Categorias categoria = await this.DetallesCategoriaAsync(idCategoria);
            this.context.Categorias.Remove(categoria);
            await this.context.SaveChangesAsync();
        }

        public async Task<Categorias> DetallesCategoriaAsync(int idCategoria)
        {
            return await this.context.Categorias.FirstOrDefaultAsync(cat => cat.IdCategoria == idCategoria);
        }
        public async Task<List<Categorias>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }

        public async Task EditCategoriaAsync(Categorias categoria)
        {
            Categorias categoriaEdit = await this.DetallesCategoriaAsync(categoria.IdCategoria);
            categoriaEdit.Descripcion = categoria.Descripcion;
            await this.context.SaveChangesAsync();
        }

        public async Task NuevaCategoriaAsync(Categorias categoria)
        {
            Categorias nuevaCategoria = new Categorias
            {
                Descripcion = categoria.Descripcion,
            };
            await this.context.Categorias.AddAsync(nuevaCategoria);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<string>> ObtenerNombresCategorias()
        {
            var consulta = (from datos in this.context.Categorias
                            select datos.Descripcion).Distinct();
            return await consulta.ToListAsync();
        }

        public async Task<int> ObtenerIdCategoriaAsync(string categoria)
        {
            var consulta = (from datos in this.context.Categorias
                            where categoria == datos.Descripcion
                            select datos.IdCategoria
                                );
            return await consulta.FirstOrDefaultAsync();

        }
    }
}
