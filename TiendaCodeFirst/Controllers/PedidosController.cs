using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private IRepositoryPedidosTienda repo;

        public PedidosController(IRepositoryPedidosTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> MostrarPedidos()
        {
            List<Pedido> pedidos = await this.repo.ObtenerPedidosAsync();
            return Ok(pedidos);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarPedidosLineas()
        {
            List<Pedido> pedidos = await this.repo.ObtenerPedidosLineasAsync();
            return Ok(pedidos);
        }
        [HttpGet("[Action]/{idCliente}")]
        public async Task<ActionResult> MostrarPedidosCliente(int idCliente)
        {
            List<Pedido> pedidos = await this.repo.ObtenerPedidosClienteAsync(idCliente);
            return Ok(pedidos);
        } 
        [HttpGet("[Action]/{idCliente}")]
        public async Task<ActionResult> MostrarPedidosClienteProductos(int idCliente)
        {
            List<PedidoClienteDTO> pedidos = await this.repo.ObtenerPedidosClienteProductosAsync(idCliente);
            return Ok(pedidos);
        } 
        [HttpGet("[Action]/{idCliente}/{idPedido}")]
        public async Task<ActionResult> DetallesPedidosClienteProductos(int idCliente, int idPedido)
        {
            PedidoClienteDTO pedidos = await this.repo.DetallesPedidoClienteAsync(idCliente, idPedido);
            return Ok(pedidos);
        }
        [HttpGet("[Action]")]
        public async Task<ActionResult> ObtenerPedidosClientesCantidadMinLineasAsync(int cantidad)
        {
            List<Pedido> pedidos = await this.repo.ObtenerPedidosClientesCantidadMinLineasAsync(cantidad);
            return Ok(pedidos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> DetallesPedido(int id)
        {
            Pedido pedido = await this.repo.DetallesPedidoAsync(id);
            return Ok(pedido);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarPedido(int id)
        {
            await this.repo.EliminarPedidoAsync(id);
            return Ok();
        }
        
        [HttpPost("[Action]/{idCliente}/{idProducto}")]
        public async Task<ActionResult> NuevoPedido(int idCliente, int idProducto)
        {
            await this.repo.AgregarPedidoAsync(idCliente, idProducto);
            return Ok();
        }
        [HttpPut("[Action]")]
        public async Task<ActionResult> EdicionPedido(Pedido pedido)
        {
            await this.repo.ModificarPedidoAsync(pedido);
            return Ok();
        }
    }
}
