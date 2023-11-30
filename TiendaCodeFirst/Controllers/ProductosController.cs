using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IRepositoryProductosTienda repo;
        private IMemoryCache cache;

        public ProductosController(IRepositoryProductosTienda repo, IMemoryCache cache)
        {
            this.repo = repo;
            this.cache = cache;
        }
        [HttpPut("[Action]/{idProducto}/{cantidad}")]
        public async Task<ActionResult> CalcularStockVentaProducto(int idProducto, int cantidad)
        {
            await this.repo.ModificarSotckProductoVentaAsync(idProducto,cantidad);
            return Ok();
        }   
        [HttpPost("[Action]")]
        public async Task<ActionResult> AgregarPedidoMaterialAsync(ProductoPedidosStockDTO producto)
        {
            await this.repo.AgregarPedidoMaterialAsync(producto);
            return Ok();
        }    
        [HttpPut("[Action]/{idLog}")]
        public async Task<ActionResult> CompletarRecepcionMaterial(NuevaRecepcionMaterialDTO producto, int idLog)
        {
            await this.repo.RealizarRecepciónProducto(producto, idLog);
            return Ok();
        }  
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarProductosTienda()
        {

            List<ProductoDTO> productos = await this.repo.ObtenerProductosTiendaAsync();
            this.cache.Set("productos", productos);
            return Ok(productos);
        }  
        [HttpPost("[Action]")]
        public async Task<ActionResult> NuevoProductoTienda(NuevoProductoDTO producto)
        {
            await this.repo.AgregarNuevoProductoAsync(producto);
            return Ok();
        }   
        [HttpPut("[Action]")]
        public async Task<ActionResult> EditProductoTienda(EditProductoDTO producto)
        {
            await this.repo.ModificarProductoDTOAsync(producto);
            return Ok();
        }  
        [HttpGet("[Action]/{id}")]
        public async Task<ActionResult> InfoProductoTienda(int id)
        {
            ProductoDTO producto = await this.repo.DetallesProductoTiendaAsync(id);
            return Ok(producto);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarProductosLineas()
        {
            List<Producto> productos = await this.repo.ObtenerProductosLineasAsync();
            return Ok(productos);
        }
        [HttpGet("[Action]")]
        public async Task<ActionResult> NProductosLineaPedidos()
        {
            List<NProductosLineaPedidoDTO> productosLp = await this.repo.NProductosLineaPedidos();
            return Ok(productosLp);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> ObtenerProductosLineasPedidoPrecio(int precio)
        {
            List<Producto> productos = await this.repo.ObtenerProductosLineasPedidoPrecio(precio);
            return Ok(productos);
        }
        [HttpGet]
        public async Task<ActionResult> MostrarProductos()
        {
            List<Producto> productos = await this.repo.ObtenerProductosAsync();
            return Ok(productos);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> DetallesProducto(int id)
        {
            Producto producto = await this.repo.DetallesProductoAsync(id);
            return Ok(producto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarProducto(int id)
        {
            await this.repo.EliminarProductoAsync(id);
            return Ok();
        }  
        [HttpPut("[Action]/{id}")]
        public async Task<ActionResult> BajaProducto(int id)
        {
            await this.repo.BajaProductoAsync(id);
            return Ok();
        }
        [HttpPost("[Action]")]
        public async Task<ActionResult> NuevoProducto(Producto producto)
        {
            await this.repo.AgregarProductoAsync(producto);
            return Ok();
        }
        [HttpPut("[Action]")]
        public async Task<ActionResult> ModificarProducto(Producto producto)
        {
            await this.repo.ModificarProductoAsync(producto);
            return Ok();
        }

    }
}
