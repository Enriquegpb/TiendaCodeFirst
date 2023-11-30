using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private IRepositoryCategoriasTienda repo;
        public CategoriasController(IRepositoryCategoriasTienda repo)
        {
            this.repo = repo;
        }
        [HttpGet("[Action]/{categoria}")]
        public async Task<ActionResult> RecuperarCodigoCategoria(string categoria) { 

            int idCategoria = await this.repo.ObtenerIdCategoriaAsync(categoria);
            return Ok(idCategoria);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarNombreCategorias() { 

            List<string> categorias = await this.repo.ObtenerNombresCategorias();
            return Ok(categorias);
        } 
        [HttpGet]
        public async Task<ActionResult> MostrarCategorias() { 

            List<Categorias> categorias = await this.repo.GetCategoriasAsync();
            return Ok(categorias);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> InfoCategoria(int id) 
        { 

            Categorias categoria = await this.repo.DetallesCategoriaAsync(id);
            return Ok(categoria);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCategoria(int id) 
        { 
            await this.repo.DeleteCategoriaAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> NuevaCategoria(Categorias categoria) 
        { 
            await this.repo.NuevaCategoriaAsync(categoria);
            return Ok();
        } 
        [HttpPut]
        public async Task<ActionResult> EditCategoria(Categorias categoria) 
        { 
            await this.repo.EditCategoriaAsync(categoria);
            return Ok();
        }
    }
}
