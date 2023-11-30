using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecepcionController : ControllerBase
    {
        IRepositoryRecepcionMaterialTienda repo;
        public RecepcionController(IRepositoryRecepcionMaterialTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet("{idProducto}")]
        public async Task<ActionResult> Get(int idProducto)
        {
            List<RecepcionDTO> recepciones = await this.repo.GetRecepcionProductoAsync(idProducto);
            return Ok(recepciones);
        }

        //[HttpPost("[Action]")]
        //public async Task<ActionResult> NuevaRecepcionMaterialProductos(NuevaRecepcionMaterialDTO nuevaRecepcion)
        //{
        //    await this.repo.NuevaRecepcionMaterialProductos(nuevaRecepcion);
        //    return Ok();
        //}
    }
}
