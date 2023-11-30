using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryPedidosTienda : IRepositoryPedidosTienda
    {
        private TiendaContext context;
        public RepositoryPedidosTienda(TiendaContext context)
        {
            this.context = context;
        }

        #region METODOS_GET
        public async Task<Pedido> DetallesPedidoAsync(int id)
        {
            return await this.context.Pedidos.FirstOrDefaultAsync(p => p.PedidoId == id);
        }

        public async Task<List<Pedido>> ObtenerPedidosAsync()
        {
            return await this.context.Pedidos.ToListAsync();
        }

        public Task<List<Pedido>> ObtenerPedidosClientesCantidadMinLineasAsync(int unidades)
        {
            var consulta = (from pedidos in this.context.Pedidos
                            join clientes in this.context.Clientes
                            on pedidos.ClienteId equals clientes.ClienteId
                            join lp in this.context.LineasPedido
                            on pedidos.PedidoId equals lp.PedidoId
                            where lp.Unidades < unidades
                            select new Pedido
                            {
                                ClienteId = clientes.ClienteId,
                                PedidoId = lp.PedidoId,
                                FechaCreacion = pedidos.FechaCreacion,
                                Lineas = pedidos.Lineas,

                            }
                            ).ToListAsync();
            return consulta;
        }

        public async Task<List<Pedido>> ObtenerPedidosLineasAsync()
        {
            return await this.context.Pedidos.Include(lp => lp.Lineas).ToListAsync();
        }
        #endregion

        #region METODOS_ACCION

        public async Task AgregarPedidoAsync(int idCliente, int idProducto)
        {
            int maxId = await this.context.Pedidos.MaxAsync(p => p.PedidoId)+1;
            List<LineaPedido> lineaPedidos = await this.context.LineasPedido.Where(lp => lp.PedidoId == maxId && lp.ProductoId == idProducto).ToListAsync();
            if(lineaPedidos.Count() == 0)
            {
                lineaPedidos = new List<LineaPedido>
                {
                    new LineaPedido
                    {
                        PedidoId = maxId,
                        ProductoId = idProducto,
                        Unidades = 10
                    }
                };
            }
            Pedido pedidonuevo = new Pedido
            {
                ClienteId = idCliente,
                FechaCreacion = DateTime.UtcNow,
                Lineas = lineaPedidos,
            };
            foreach(LineaPedido lp in lineaPedidos)
            {
                await this.context.AddAsync(lp);
            }
            
            await this.context.AddAsync(pedidonuevo);
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarPedidoAsync(int id)
        {
            Pedido pedido = await this.DetallesPedidoAsync(id);
            LineaPedido lp = await this.context.LineasPedido.FirstOrDefaultAsync(p => p.PedidoId == id);
            this.context.Remove(pedido);
            this.context.LineasPedido.Remove(lp);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarPedidoAsync(Pedido pedido)
        {
            Pedido pedidoEditado = await this.DetallesPedidoAsync(pedido.PedidoId);
            pedidoEditado.ClienteId = pedido.ClienteId;
            pedidoEditado.FechaCreacion = pedido.FechaCreacion;
            //pedidoEditado.Lineas = pedido.Lineas;
            await this.context.SaveChangesAsync();
        }

        public async Task<List<Pedido>> ObtenerPedidosClienteAsync(int idCliente)
        {
            return await this.context.Pedidos.Where(p => p.ClienteId == idCliente).ToListAsync();
        }

        public async Task<List<PedidoClienteDTO>> ObtenerPedidosClienteProductosAsync(int idCliente)
        {
            var consulta = (from pedidos in this.context.Pedidos
                            join clientes in this.context.Clientes
                            on pedidos.ClienteId equals clientes.ClienteId
                            join lp in this.context.LineasPedido
                            on pedidos.PedidoId equals lp.PedidoId
                            join p in this.context.Productos on
                            lp.ProductoId equals p.IdProducto
                            where clientes.ClienteId == idCliente
                            select new PedidoClienteDTO
                            {
                                IdPedido = pedidos.PedidoId,
                                NombrePedido = p.DescripcionComercial,
                                Pvp = p.Pvp,
                                NombreCliente = clientes.Nombre,
                                FechaCreacion = pedidos.FechaCreacion
                            }
                            );
            return await consulta.ToListAsync();
        }

        public async Task<PedidoClienteDTO> DetallesPedidoClienteAsync(int idCliente, int idPedido)
        {
            var consulta = (from pedidos in this.context.Pedidos
                            join clientes in this.context.Clientes
                            on pedidos.ClienteId equals clientes.ClienteId
                            join lp in this.context.LineasPedido
                            on pedidos.PedidoId equals lp.PedidoId
                            join p in this.context.Productos on
                            lp.ProductoId equals p.IdProducto
                            where clientes.ClienteId == idCliente
                            select new PedidoClienteDTO
                            {
                                IdPedido = pedidos.PedidoId,
                                NombrePedido = p.DescripcionComercial,
                                Pvp = p.Pvp,
                                NombreCliente = clientes.Nombre,
                                FechaCreacion = pedidos.FechaCreacion
                            }
                           );
            return await consulta.FirstOrDefaultAsync(p=> p.IdPedido == idPedido);
        }
        #endregion
    }
}
