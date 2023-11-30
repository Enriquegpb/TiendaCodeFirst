using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineaPedidoController : ControllerBase
    {
        private IRepositoryLineaPedidoTienda repo;
        public LineaPedidoController(IRepositoryLineaPedidoTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> MostrarLineasPedidos()
        {
            List<LineaPedido> pedidos = await this.repo.ObtenerLineasPedidosAsync();
            return Ok(pedidos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> DetallesLineaPedidos(int id)
        {
            LineaPedido pedido = await this.repo.InformacionLineaPedidosAsync(id);
            return Ok(pedido);
        } 
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarLineaPedidos(int id)
        {
            await this.repo.EliminarLineaPedidoAsync(id);
            return Ok();
        }
        
        [HttpPost("[Action]")]
        public async Task<ActionResult> AgregarLineaPedidos(LineaPedido lp)
        {
            await this.repo.AgregarLineaPedidoAsync(lp);
            return Ok();
        }
        [HttpPut("[Action]")]
        public async Task<ActionResult> ModificarLineaPedidos(LineaPedido lp)
        {
            await this.repo.ModificarLineaPedidoAsync(lp);
            return Ok();
        }
    }
}
