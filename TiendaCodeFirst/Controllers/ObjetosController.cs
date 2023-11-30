using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosController : ControllerBase
    {
        private IRepositoryObjetosTienda repo;
        public ObjetosController(IRepositoryObjetosTienda repo)
        {
            this.repo = repo;
        }
        [HttpGet("[Action]/{producto}")]
        public async Task<ActionResult> RecuperarCodigoProducto(string producto)
        {
            int id = await this.repo.ObtenerIdProductoAsync(producto);
            return Ok(id);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarNombreObjetos()
        {
            List<string> objetos = await this.repo.ObtenerNombresObjetos();
            return Ok(objetos);
        } 
        [HttpGet]
        public async Task<ActionResult> MostrarObjetos()
        {
            List<Objetos> objetos = await this.repo.GetObjetosAsync();
            return Ok(objetos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Infoobjeto(int id)
        {
            Objetos objeto = await this.repo.DetallesObjetoAsync(id);
            return Ok(objeto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Deleteobjeto(int id)
        {
            await this.repo.DeleteObjetoAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> Nuevaobjeto(Objetos objeto)
        {
            await this.repo.NuevoObjetoAsync(objeto);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Editobjeto(Objetos objeto)
        {
            await this.repo.EditObjetoAsync(objeto);
            return Ok();
        }
    }
}
