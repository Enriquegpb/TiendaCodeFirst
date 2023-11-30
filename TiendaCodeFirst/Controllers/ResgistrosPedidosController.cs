using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResgistrosPedidosController : ControllerBase
    {
        private IRepositoryLogTienda repo;
        public ResgistrosPedidosController(IRepositoryLogTienda repo)
        {
            this.repo = repo;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetRegistrosPedidos(int id)
        {
            List<RegistroPedidosLogsDTO> pedidos = await this.repo.GetLogRecepcionProductos(id);
            return Ok(pedidos);
        }
       
    }
}
