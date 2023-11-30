using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryLineaPedidoTienda: IRepositoryLineaPedidoTienda
    {
        private TiendaContext context;
        public RepositoryLineaPedidoTienda(TiendaContext context)
        {
            this.context = context;
        }

        #region METODOS_GET
        public async Task<List<LineaPedido>> ObtenerLineasPedidosAsync()
        {
            return await this.context.LineasPedido.ToListAsync();
        }

        public async Task<LineaPedido> InformacionLineaPedidosAsync(int id)
        {
            return await this.context.LineasPedido.FirstOrDefaultAsync(lp => lp.LineaPedidoId == id);
        }
        #endregion

        #region METODOS_ACCION

        public async Task AgregarLineaPedidoAsync(LineaPedido linea)
        {
            LineaPedido nuevaLp = new LineaPedido
            {
                //LineaPedidoId = linea.LineaPedidoId,
                PedidoId = linea.PedidoId,
                ProductoId = linea.ProductoId,
                Unidades = linea.Unidades
            };
            await this.context.AddAsync(nuevaLp);
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarLineaPedidoAsync(int id)
        {
            LineaPedido lineaPedido = await this.InformacionLineaPedidosAsync(id);
            this.context.Remove(lineaPedido);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarLineaPedidoAsync(LineaPedido linea)
        {
            LineaPedido lp = await this.InformacionLineaPedidosAsync(linea.LineaPedidoId);
            
            lp.ProductoId = linea.ProductoId;
            lp.PedidoId = linea.PedidoId;
            lp.Unidades = linea.Unidades;
            await this.context.SaveChangesAsync();
        }
        #endregion
    }
}
