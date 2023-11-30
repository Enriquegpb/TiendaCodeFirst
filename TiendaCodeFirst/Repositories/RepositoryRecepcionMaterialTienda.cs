using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryRecepcionMaterialTienda : IRepositoryRecepcionMaterialTienda
    {
        private TiendaContext context;
        private IMapper mapper;
        public RepositoryRecepcionMaterialTienda(TiendaContext context, IMapper maper)
        {
            this.context = context;
            this.mapper = maper;
        }

        public async Task<List<RecepcionDTO>> GetRecepcionProductoAsync(int idProducto)
        {
            var consulta = (from recepciones in this.context.Recepciones
                            join productos in this.context.Productos on
                            recepciones.IdProducto equals productos.IdProducto
                            join objetos in this.context.Objetos on
                            productos.IdObjeto equals objetos.IdObjeto
                            join marcas in this.context.Marcas
                            on productos.IdMarca equals marcas.IdMarca
                            where recepciones.IdProducto == idProducto
                            select new RecepcionDTO
                            {
                                Referencia = recepciones.Referencia,
                                Producto = objetos.Descripcion,
                                Proveedor = marcas.Descripcion,
                                CantidadPedida = recepciones.CantidadPedida,
                                CantidadRecibida = recepciones.CantidadRecibida,
                                Fecha = recepciones.Fecha,
                            }
                            );
            return await consulta.ToListAsync();
        }

        //public async Task NuevaRecepcionMaterialProductos(NuevaRecepcionMaterialDTO nuevaRecepcion)
        //{
        //    //var consulta = from productos in this.context.Productos
        //    //               where productos.IdProducto == nuevaRecepcion.IdProducto
        //    //               select productos.IdMarca;
            
        //    //int idProvedor = await consulta.FirstOrDefaultAsync();
                           
                           
        //    NuevaRecepcionMaterialDTO nuevaRecepcionMaterial = new NuevaRecepcionMaterialDTO
        //    {
        //        Provedor = nuevaRecepcion.Provedor,
        //        IdProducto = nuevaRecepcion.IdProducto,
        //        Fecha = DateTime.UtcNow,
        //        CantidadPedida = nuevaRecepcion.CantidadPedida,
        //        CantidadRecibida = nuevaRecepcion.CantidadRecibida
        //    };

        //    var nuevaRecepcionMaterialDto = this.mapper.Map<NuevaRecepcionMaterialDTO, Recepcion>( nuevaRecepcionMaterial );

        //    await this.context.AddAsync(nuevaRecepcionMaterialDto);
        //    await this.context.SaveChangesAsync();
        //}
    }
}
