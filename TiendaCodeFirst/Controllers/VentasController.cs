using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;
using TiendaCodeFirst.Repositories;

namespace TiendaCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private IRepositoryVentasTienda repo;
        public VentasController(IRepositoryVentasTienda repo)
        {
            this.repo = repo;
        }

        [HttpGet("[Action]/{id}")]
        public async Task<ActionResult> MostrarVentasProductoTienda(int id)
        {
            List<VentaTiendaDTO> ventas = await this.repo.GetVentasProductoTiendaAsync(id);
            return Ok(ventas);
        } 
        [HttpGet("[Action]")]
        public async Task<ActionResult> MostrarVentasTienda()
        {
            List<VentaTiendaDTO> ventas = await this.repo.GetVentasTiendaAsync();
            return Ok(ventas);
        }
        [HttpGet("[Action]/{id}")]
        public async Task<ActionResult> DetallesVentaTienda(int id)
        {
            VentaTiendaDTO venta = await this.repo.DetallesVentaTiendaAsync(id);
            return Ok(venta);
        }  
        [HttpGet]
        public async Task<ActionResult> MostrarVentas()
        {
            List<Ventas> ventas = await this.repo.GetVentasAsync();
            return Ok(ventas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> DetallesVenta(int id)
        {
            Ventas venta = await this.repo.DetallesVentaAsync(id);
            return Ok(venta);
        }  
        [HttpDelete("{id}")]
        public async Task<ActionResult> BajaVenta(int id)
        {
            await this.repo.DeleteVentaAsync(id);
            return Ok();
        } 
        [HttpPost]
        public async Task<ActionResult> NuevaVenta(Ventas venta)
        {
            await this.repo.NuevaVentaAsync(venta);
            return Ok();
        } 
        [HttpPost("[Action]")]
        public async Task<ActionResult> NuevaVentaTienda(NuevaVentaDTO venta)
        {
            await this.repo.NuevaVentaTiendaAsync(venta);
            return Ok();
        } 
        [HttpPut]
        public async Task<ActionResult> CambiarDatosVenta(Ventas venta)
        {
            await this.repo.EditVentaAsync(venta);
            return Ok();
        } 
        [HttpPut("[Action]")]
        public async Task<ActionResult> CambiarDatosVentaTienda(EditVentaDTO venta)
        {
            await this.repo.EditVentaTiendaAsync(venta);
            return Ok();
        }
    }
}