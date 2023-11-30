using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private IRepositoryMarcasTienda repo;
        public MarcasController(IRepositoryMarcasTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet("[Action]/{marca}")]
        public async Task<ActionResult> RecuperarCodigoMarca(string marca)
        {
            int idMarca = await this.repo.ObtenerIdMarcaAsync(marca);
            return Ok(idMarca);
        }

        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarNombreMarcas()
        {
            List<string> marcas = await this.repo.ObtenerNombresMarcas();
            return Ok(marcas);
        }

        [HttpGet]
        public async Task<ActionResult> MostrarMarcas()
        {
            List<Marcas> marcas = await this.repo.GetMarcasAsync();
            return Ok(marcas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> InfoMarca(int id)
        {
            Marcas Marca = await this.repo.DetallesMarcaAsync(id);
            return Ok(Marca);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMarca(int id)
        {
            await this.repo.DeleteMarcaAsync(id);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> NuevaMarca(Marcas Marca)
        {
            await this.repo.NuevaMarcaAsync(Marca);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> EditMarca(Marcas Marca)
        {
            await this.repo.EditMarcaAsync(Marca);
            return Ok();
        }
    }
}
