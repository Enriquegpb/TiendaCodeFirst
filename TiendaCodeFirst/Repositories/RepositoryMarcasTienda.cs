using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryMarcasTienda : IRepositoryMarcasTienda
    {
        private TiendaContext context;
        public RepositoryMarcasTienda(TiendaContext context)
        {
            this.context = context;
        }

        public async Task DeleteMarcaAsync(int idMarca)
        {
            Marcas marca = await this.DetallesMarcaAsync(idMarca);
            this.context.Marcas.Remove(marca);
            await this.context.SaveChangesAsync();
        }

        public async Task<Marcas> DetallesMarcaAsync(int idMarca)
        {
            return await this.context.Marcas.FirstOrDefaultAsync(m => m.IdMarca == idMarca);
        }
        public async Task<List<Marcas>> GetMarcasAsync()
        {
            return await this.context.Marcas.ToListAsync();
        }

        public async Task EditMarcaAsync(Marcas marca)
        {
            Marcas marcaEdit = await this.DetallesMarcaAsync(marca.IdMarca);
            marcaEdit.Descripcion = marca.Descripcion;
            await this.context.SaveChangesAsync();
        }

        public async Task NuevaMarcaAsync(Marcas marca)
        {
            Marcas nuevaMarca = new Marcas
            {
                Descripcion = marca.Descripcion,
            };
            await this.context.Marcas.AddAsync(nuevaMarca);
            await this.context.SaveChangesAsync();
        }

        public async Task<List<string>> ObtenerNombresMarcas()
        {
            var consulta = (from datos in this.context.Marcas
                            select datos.Descripcion).Distinct();
            return await consulta.ToListAsync();
        }

        public async Task<int> ObtenerIdMarcaAsync(string marca)
        {
            
                var consulta = (from datos in this.context.Marcas
                                where marca == datos.Descripcion
                                select datos.IdMarca
                                );
                return await consulta.FirstOrDefaultAsync();

            
        }
    }
}
