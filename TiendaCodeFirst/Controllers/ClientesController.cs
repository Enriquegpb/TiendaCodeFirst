using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IRepositoryClientesTienda repo;
        public ClientesController(IRepositoryClientesTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> MostrarClientes()
        {
            List<Cliente> clientes = await this.repo.ObtenerClientesAsync();
            return Ok(clientes);
        }
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarPedidosClientes()
        {
            List<Cliente> clientes = await this.repo.ObtenerPedidosClientesAsync();
            return Ok(clientes);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> ObtenerNPedidosClientesAsync()
        {
            List<NPedidosClientesDTO> npClientes = await this.repo.ObtenerNPedidosClientesAsync();
            return Ok(npClientes);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarPedidosClientesLineas()
        {
            List<Cliente> clientes = await this.repo.ObtenerPedidosClientesLineasAsync();
            return Ok(clientes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> DetallesCliente(int id)
        {
            Cliente cliente = await this.repo.DetallesClienteAsync(id);
            return Ok(cliente);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCliente(int id)
        {
            await this.repo.EliminarClienteAsync(id);
            return Ok();
        }
        
        [HttpPost("[Action]")]
        public async Task<ActionResult> NuevoCliente(Cliente cliente)
        {
            await this.repo.AgregarClienteAsync(cliente);
            return Ok();
        }
        [HttpPut("[Action]")]
        public async Task<ActionResult> EditarCliente(Cliente cliente)
        {
            await this.repo.ModificarClienteAsync(cliente);
            return Ok();
        }
    }
}
