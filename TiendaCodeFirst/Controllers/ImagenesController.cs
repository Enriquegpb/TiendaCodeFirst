using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Helpers;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagenesController : ControllerBase
    {
        private IRepositoryProductosTienda repo;
        private HelperPathProvider provider;
        public ImagenesController(IRepositoryProductosTienda repo, HelperPathProvider provider)
        {
            this.repo = repo;
            this.provider = provider;
        }

        [HttpPost("[Action]")]
        public async Task<ActionResult> UploadImagen()
        {
            var file = Request.Form.Files[0];
            if( file != null)
            {
                var fileName = Path.GetFileName(file.FileName);

                string path = this.provider.MapPath(fileName, Folders.Imagenes);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    
                    await file.CopyToAsync(fileStream);
                }
            }
            return Ok();
        }

    }
}
