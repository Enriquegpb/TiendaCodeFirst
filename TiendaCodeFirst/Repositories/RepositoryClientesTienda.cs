using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryClientesTienda: IRepositoryClientesTienda
    {
        private TiendaContext context;
        public RepositoryClientesTienda(TiendaContext context)
        {
            this.context = context;
        }

        #region METODOS_GET
        public async Task<Cliente> ExisteClienteAsync(LoginClienteModel model)
        {
            return await this.context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == model.Id
            && c.Nombre == model.Nombre);
        }
        public async Task<Cliente> DetallesClienteAsync(int id)
        {
            return await this.context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == id);
        }

        public async Task<List<Cliente>> ObtenerClientesAsync()
        {
            return await this.context.Clientes.ToListAsync();
        }

        public Task<List<NPedidosClientesDTO>> ObtenerNPedidosClientesAsync()
        {
            var consulta = (from clientes in this.context.Clientes
                            join pedidos in this.context.Pedidos
                            on clientes.ClienteId equals pedidos.ClienteId
                            into c1
                            from c2 in c1.DefaultIfEmpty()
                            group clientes by clientes.Nombre into nPedidos
                            where nPedidos.Count() != 1
                            select new NPedidosClientesDTO
                            {
                                Nombre = nPedidos.Key,
                                Cantidad = nPedidos.Count(),
                            }
                            );

            //var consulta = this.context.Clientes.Join(
            //    this.context.Pedidos, c => c.ClienteId,
            //    p => p.ClienteId,
            //    (cliente, pedido) => new NPedidosClientesDTO
            //    {
            //        Nombre = cliente.Nombre,
            //        Cantidad = 2
            //    })/*.GroupBy(c => c.Cantidad).Select(x => x)*/;
            return consulta.ToListAsync();
        }

        public async Task<List<Cliente>> ObtenerPedidosClientesAsync()
        {
            return await this.context.Clientes.Include(p => p.Pedidos).ToListAsync();
        }
        public async Task<List<Cliente>> ObtenerPedidosClientesLineasAsync()
        {
            return await this.context.Clientes.Include(p => p.Pedidos).ThenInclude(lp => lp.Lineas).ToListAsync();
        }
        #endregion

        #region METODOS_ACCION

        public async Task AgregarClienteAsync(Cliente cliente)
        {
            //List<Pedido> pedidoscliente = new List<Pedido>();
            List<Pedido> pedidoscliente = await this.context.Pedidos.Where(p => p.ClienteId == cliente.ClienteId).ToListAsync();
            
            //foreach (Pedido pedido in cliente.Pedidos)
            //{
            //    pedidoscliente.Add(new Pedido{ FechaCreacion = pedido.FechaCreacion, ClienteId = pedido.ClienteId,Lineas = pedido.Lineas});
            //}
            Cliente clienteNuevo = new Cliente
            {
                //ClienteId = cliente.ClienteId,
                Nombre = cliente.Nombre,
                Pedidos = pedidoscliente,

            };
            await this.context.AddAsync(clienteNuevo);
            await this.context.SaveChangesAsync();
        }

        public async Task EliminarClienteAsync(int id)
        {
            Cliente cliente = await this.DetallesClienteAsync(id);
            this.context.Remove(cliente);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarClienteAsync(Cliente cliente)
        {
            Cliente clienteMofidicado = await this.DetallesClienteAsync(cliente.ClienteId);
            clienteMofidicado.Nombre = cliente.Nombre;
            //clienteMofidicado.Pedidos = cliente.Pedidos;
            await this.context.SaveChangesAsync();
        }

        #endregion
    }
}
