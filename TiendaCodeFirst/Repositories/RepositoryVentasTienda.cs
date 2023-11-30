using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryVentasTienda : IRepositoryVentasTienda
    {
        private TiendaContext context;
        private IMapper mapper;
        public RepositoryVentasTienda(TiendaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<Ventas> DetallesVentaAsync(int id)
        {
            return await this.context.Ventas.FirstOrDefaultAsync(v => v.IdVenta == id);   
        }

        public async Task EditVentaAsync(Ventas venta)
        {
            Ventas editventa = await this.DetallesVentaAsync(venta.IdVenta);
            editventa.Descuento = venta.Descuento;
            editventa.UnidadesVenta = venta.UnidadesVenta;
            editventa.FechaVenta = DateTime.UtcNow;
            editventa.Importe = venta.Importe;
            editventa.IdProducto = venta.IdProducto;

            await this.context.SaveChangesAsync();
        }

        public async Task NuevaVentaAsync(Ventas venta)
        {
            Ventas nuevoVenta = new Ventas
            {
                IdProducto = venta.IdProducto,
                FechaVenta = DateTime.UtcNow,
                Importe = venta.Importe,
                Descuento = venta.Descuento,
                PvpUnitario = venta.PvpUnitario,
                UnidadesVenta = venta.UnidadesVenta,
                Producto = venta.Producto,
                
            };
            await this.context.Ventas.AddAsync(nuevoVenta);
            await this.context.SaveChangesAsync();  
        }

        public async Task<List<Ventas>> GetVentasAsync()
        {
            return await this.context.Ventas.ToListAsync();
        }

        public async Task DeleteVentaAsync(int id)
        {
            Ventas venta = await this.DetallesVentaAsync(id);
            this.context.Ventas.Remove(venta);
            await this.context.SaveChangesAsync();
        }

        public async Task NuevaVentaTiendaAsync(NuevaVentaDTO venta)
        {
            NuevaVentaDTO nuevaVenta = new NuevaVentaDTO
            {
                IdProducto = venta.IdProducto,
                FechaVenta = DateTime.UtcNow,
                Importe = venta.Importe,
                Descuento = venta.Descuento,
                PvpUnitario = venta.PvpUnitario,
                UnidadesVenta = venta.UnidadesVenta,
            };

            var nuevaVentaDto = this.mapper.Map<NuevaVentaDTO, Ventas>(nuevaVenta);
            await this.context.AddAsync(nuevaVentaDto);
            await this.context.SaveChangesAsync();
        }

        public async Task EditVentaTiendaAsync(EditVentaDTO venta)
        {
            Ventas editVenta = await this.DetallesVentaAsync(venta.IdVenta);
            //editVenta.Descuento = venta.Descuento;
            editVenta.Descuento = venta.Descuento;
            editVenta.PvpUnitario = venta.PvpUnitario;
            editVenta.UnidadesVenta = venta.UnidadesVenta;
            editVenta.FechaVenta = DateTime.UtcNow;
            editVenta.Importe = venta.Importe;

            this.mapper.Map<Ventas, EditVentaDTO>(editVenta);

            await this.context.SaveChangesAsync();
        }

        public async Task<List<VentaTiendaDTO>> GetVentasTiendaAsync()
        {
            var consulta = (from ventas in this.context.Ventas
                            join productos in this.context.Productos
                            on ventas.IdProducto equals productos.IdProducto
                            select new VentaTiendaDTO
                            {
                                IdVenta = ventas.IdVenta,
                                Descuento = ventas.Descuento,
                                FechaVenta = ventas.FechaVenta,
                                Importe = ventas.Importe,
                                PvpUnitario = ventas.PvpUnitario,
                                UnidadesVenta = ventas.UnidadesVenta,
                                ProductoVenta = productos.Objeto.Descripcion
                            }
                            );
            return await consulta.ToListAsync();
        }

        public async Task<VentaTiendaDTO> DetallesVentaTiendaAsync(int id)
        {
            var consulta = (from ventas in this.context.Ventas
                            join productos in this.context.Productos
                            on ventas.IdProducto equals productos.IdProducto
                            select new VentaTiendaDTO
                            {
                                IdVenta = ventas.IdVenta,
                                Descuento = ventas.Descuento,
                                FechaVenta = ventas.FechaVenta,
                                Importe = ventas.Importe,
                                PvpUnitario = ventas.PvpUnitario,
                                UnidadesVenta = ventas.UnidadesVenta,
                                ProductoVenta = productos.Objeto.Descripcion
                            }
                           );
            return await consulta.FirstOrDefaultAsync(v => v.IdVenta == id);
        }

        public async Task<List<VentaTiendaDTO>> GetVentasProductoTiendaAsync(int idProducto)
        {
            var consulta = (from ventas in this.context.Ventas
                            join productos in this.context.Productos
                            on ventas.IdProducto equals productos.IdProducto
                            where productos.IdProducto == idProducto
                            select new VentaTiendaDTO
                            {
                                IdVenta = ventas.IdVenta,
                                Descuento = ventas.Descuento,
                                FechaVenta = ventas.FechaVenta,
                                Importe = ventas.Importe,
                                PvpUnitario = ventas.PvpUnitario,
                                UnidadesVenta = ventas.UnidadesVenta,
                                ProductoVenta = productos.Objeto.Descripcion
                            }
                          );
            return await consulta.ToListAsync();
        }
    }
}