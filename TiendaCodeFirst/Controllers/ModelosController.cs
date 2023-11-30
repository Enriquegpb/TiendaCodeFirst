using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private IRepositoryModelosTienda repo;
        public ModelosController(IRepositoryModelosTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerModelos()
        {
            List<Modelos> modelos = await this.repo.GetModelosAsync();
            return Ok(modelos);
        }
    }
}
