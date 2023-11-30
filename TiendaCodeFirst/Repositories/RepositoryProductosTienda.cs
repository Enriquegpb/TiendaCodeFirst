using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaCodeFirst.Data;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Repositories
{
    public class RepositoryProductosTienda: IRepositoryProductosTienda
    {
        private TiendaContext context;
        private IMapper maper;
        public RepositoryProductosTienda(TiendaContext context, IMapper maper)
        {
            this.context = context;
            this.maper = maper;
        }
        #region METODOS_GET
        public async Task<Producto> DetallesProductoAsync(int id)
        {
            return await this.context.Productos.FirstOrDefaultAsync(p => p.IdProducto == id);
        }
        public async Task<List<Producto>> ObtenerProductosAsync()
        {
            return await this.context.Productos.ToListAsync();
        }

        public async Task<List<Producto>> ObtenerProductosLineasAsync()
        {
            return await this.context.Productos.Include(p => p.Lineas).ToListAsync();
        }

        public async Task<List<Producto>> ObtenerProductosLineasPedidoPrecio(int precio)
        {
            var consulta = await (from productos in this.context.Productos
                                  join lp in this.context.LineasPedido
                                  on productos.IdProducto equals lp.ProductoId
                                  where productos.Pvp == precio
                                  select new Producto
                                  {
                                      IdProducto = productos.IdProducto,
                                      DescripcionComercial = productos.DescripcionComercial,
                                      Lineas = productos.Lineas,
                                      Pvp = productos.Pvp,
                                  }
                            ).ToListAsync();
            return consulta;
        }

        public async Task<List<NProductosLineaPedidoDTO>> NProductosLineaPedidos()
        {
            var consulta = (from productos in this.context.Productos
                            join lp in this.context.LineasPedido
                            on productos.IdMarca equals lp.ProductoId
                            into p1
                            from p2 in p1.DefaultIfEmpty()
                            group productos by productos.DescripcionComercial
                            into productosG
                            select new NProductosLineaPedidoDTO
                            {
                                NLineasProducto = productosG.Count(),
                                NombreProducto = productosG.Key
                            }
                            );
            return await consulta.ToListAsync();
        }

        #endregion

        #region METODOS_ACCION
        public async Task AgregarProductoAsync(Producto producto)
        {
            List<LineaPedido> lineasPedidos = await this.context.LineasPedido.Where(lp => lp.ProductoId == producto.IdProducto).ToListAsync();
            Producto producoNuevo = new Producto
            {
                IdMarca = producto.IdMarca,
                IdCategoria = producto.IdCategoria,
                IdObjeto = producto.IdObjeto,
                DescripcionTecnica = producto.DescripcionTecnica,
                Activo = producto.Activo,
                Stock = producto.Stock,
                Pvp = producto.Pvp,
                DescripcionComercial = producto.DescripcionComercial,
                Iva = producto.Iva,
                Categoria = producto.Categoria,
                Marca = producto.Marca,
                Objeto = producto.Objeto,
                Lineas = lineasPedidos,
            };
            await this.context.AddAsync(producoNuevo);
            await this.context.SaveChangesAsync();
        }

     
        public async Task EliminarProductoAsync(int id)
        {
            Producto producto = await this.DetallesProductoAsync(id);
            this.context.Remove(producto);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarProductoAsync(Producto producto)
        {
            Producto productoEdit = await this.DetallesProductoAsync(producto.IdProducto);
            productoEdit.IdObjeto = producto.IdObjeto;
            productoEdit.IdCategoria = producto.IdCategoria;
            productoEdit.IdMarca = producto.IdMarca;
            productoEdit.DescripcionTecnica = producto.DescripcionTecnica;
            productoEdit.DescripcionComercial = producto.DescripcionComercial;
            productoEdit.Pvp = producto.Pvp;
            productoEdit.Activo = producto.Activo;
            productoEdit.Iva = producto.Iva;
            productoEdit.Categoria = producto.Categoria;
            productoEdit.Objeto = producto.Objeto;
            productoEdit.Marca = producto.Marca;
            //productoEdit.Lineas = producto.Lineas;
            await this.context.SaveChangesAsync();
        }

        public async Task<List<ProductoDTO>> ObtenerProductosTiendaAsync()
        {
            var consulta = (from productos in this.context.Productos
                            join objetos in this.context.Objetos
                            on productos.IdObjeto equals objetos.IdObjeto
                            join marcas in this.context.Marcas on
                            productos.IdMarca equals marcas.IdMarca
                            join categorias in this.context.Categorias on
                            productos.IdCategoria equals categorias.IdCategoria
                            join modelos in this.context.Modelos on
                            productos.IdModelo equals modelos.IdModelo
                            select new ProductoDTO
                            {
                                IdProducto = productos.IdProducto,
                                DescripcionComercial = productos.DescripcionComercial,
                                DescripcionTecnica = productos.DescripcionTecnica,
                                Iva = productos.Iva,
                                Pvp = productos.Pvp,
                                Stock = productos.Stock,
                                StockMinimo = productos.StockMinimo,
                                Categoria = categorias.Descripcion,
                                Objeto = objetos.Descripcion,
                                Marca = marcas.Descripcion,
                                Activo = productos.Activo,
                                FechaAlta = productos.FechaAlta,
                                FechaActualizacion = productos.FechaModificacion,
                                Modelo = modelos.Descripcion,
                                Imagen = productos.Imagen,
                            }
                            );
            return await consulta.ToListAsync();
        }

        public async Task<ProductoDTO> DetallesProductoTiendaAsync(int id)
        {

            var consulta = (from productos in this.context.Productos
                            join objetos in this.context.Objetos
                            on productos.IdObjeto equals objetos.IdObjeto
                            join marcas in this.context.Marcas on
                            productos.IdMarca equals marcas.IdMarca
                            join categorias in this.context.Categorias on
                            productos.IdCategoria equals categorias.IdCategoria
                            join modelos in this.context.Modelos on
                            productos.IdModelo equals modelos.IdModelo
                            select new ProductoDTO
                            {
                                IdProducto = productos.IdProducto,
                                DescripcionComercial = productos.DescripcionComercial,
                                DescripcionTecnica = productos.DescripcionTecnica,
                                Iva = productos.Iva,
                                Pvp = productos.Pvp,
                                Stock = productos.Stock,
                                StockMinimo = productos.StockMinimo,
                                Modelo = modelos.Descripcion,
                                Categoria = categorias.Descripcion,
                                Objeto = objetos.Descripcion,
                                Marca = marcas.Descripcion,
                                Activo = productos.Activo,
                                FechaAlta = productos.FechaAlta,
                                FechaActualizacion = productos.FechaModificacion
                            }
                            );
            return await consulta.FirstOrDefaultAsync(p => p.IdProducto == id);

        }

        public async Task AgregarNuevoProductoAsync(NuevoProductoDTO producto)
        {
            
            NuevoProductoDTO producoNuevo = new NuevoProductoDTO
            {
                IdMarca = producto.IdMarca,
                IdCategoria = producto.IdCategoria,
                IdObjeto = producto.IdObjeto,
                DescripcionComercial = producto.DescripcionComercial,
                DescripcionTecnica = producto.DescripcionTecnica,
                Iva = producto.Iva,
                Pvp = producto.Pvp,
                Activo = producto.Activo,
                Stock = producto.Stock,
                StockMinimo = producto.StockMinimo,
                FechaAlta = DateTime.UtcNow,
                FechaModificacion = DateTime.UtcNow,
                IdModelo = producto.IdModelo,
                Imagen = producto.Imagen,
                
            };
            
            var dtoproducto = this.maper.Map<NuevoProductoDTO, Producto>( producoNuevo );

            await this.context.Productos.AddAsync(dtoproducto);
            await this.context.SaveChangesAsync();
        }

        public async Task ModificarProductoDTOAsync(EditProductoDTO producto)
        {
            
            Producto editProductoDTO = await this.DetallesProductoAsync(producto.IdProducto);
            editProductoDTO.IdMarca = producto.IdMarca;
            editProductoDTO.IdCategoria = producto.IdCategoria;
            editProductoDTO.IdObjeto = producto.IdObjeto;
            editProductoDTO.Pvp = producto.Pvp;
            editProductoDTO.Iva = producto.Iva;
            editProductoDTO.DescripcionComercial = producto.DescripcionComercial;
            editProductoDTO.DescripcionTecnica = producto.DescripcionTecnica;
            editProductoDTO.Stock = producto.Stock;
            editProductoDTO.StockMinimo = producto.StockMinimo;
            editProductoDTO.IdModelo = producto.IdModelo;
            editProductoDTO.FechaModificacion = DateTime.UtcNow;
            editProductoDTO.Imagen = producto.Imagen;
            await this.context.SaveChangesAsync();
            
        }

        public async Task BajaProductoAsync(int id)
        {
            Producto producto = await this.DetallesProductoAsync(id);
            producto.Activo = false;
            await this.context.SaveChangesAsync();
        }

        public async Task NuevoLogAsync(Producto productoPedido, ProductoPedidosStockDTO producto)
        {
            NuevaRecepcionMaterialDTO nuevaRecepcionMaterial = new NuevaRecepcionMaterialDTO
            {
                IdProvedor = productoPedido.IdMarca,
                IdProducto = producto.IdProducto,
                Fecha = DateTime.UtcNow,
                CantidadPedida = producto.Stock,
                CantidadRecibida = producto.Stock,
            };

            var nuevaRecepcionMaterialDto = this.maper.Map<NuevaRecepcionMaterialDTO, Recepcion>(nuevaRecepcionMaterial);

            await this.context.AddAsync(nuevaRecepcionMaterialDto);
            await this.context.SaveChangesAsync();
        }
  
        public async Task AgregarPedidoMaterialAsync(ProductoPedidosStockDTO producto)
        {
            /**
             * Aqui es donde agrego el pedido al provedor para
             * recibir nuevo stock del provedor
             */
            var productoPedidoDto = await this.DetallesProductoTiendaAsync(producto.IdProducto);
            RegistroPedidosLogsDTO nuevoPedidoProvedor = new RegistroPedidosLogsDTO
            {
                IdProducto = producto.IdProducto,
                Cantidad = producto.Stock,
                FechaRegistro = DateTime.UtcNow,
                Categoria = productoPedidoDto.Categoria,
                Marca = productoPedidoDto.Marca,
                ProductoPedidoName = productoPedidoDto.Objeto
                
            };
            var pedidoProvedorDto = this.maper.Map<RegistroPedidosLogsDTO, LogPedidosProductos>(nuevoPedidoProvedor);
            await this.context.Logs.AddAsync(pedidoProvedorDto);
            await this.context.SaveChangesAsync();
            /**
             * Este método lo llamo cuando necesite pedir nuevo producto
             * al provedor, pero todavía no me llega
             * hasta que el provedor de al boton confirmar.
             */
        } 
        public async Task ModificarSotckProductoVentaAsync(int idProducto,int cantidad)
        {
            Producto producto = await this.DetallesProductoAsync(idProducto);
            producto.Stock -= cantidad;
            var stockTotal = producto.Stock;
            await this.context.SaveChangesAsync();
        }

        public async Task RealizarRecepciónProducto(NuevaRecepcionMaterialDTO nuevaRecepcion, int numeroRegistro)
        {
            /**
             * Este método realizar la acción de recepcionar los productos
             * del pedido que se ha realizado, cuando el provedor 
             * pulse el botón confirmar
             * 
             */
            var transaction = this.context.Database.BeginTransaction();
            try
            {
                //Aumentamos la cantidad total de stock que disponemos, porque nos ha llegado el nuevo pedido
                Producto productoPedido = await this.DetallesProductoAsync(nuevaRecepcion.IdProducto);
                var productoStockDto = this.maper.Map<ProductoPedidosStockDTO>(productoPedido);

                productoStockDto.Stock = productoPedido.Stock + nuevaRecepcion.CantidadRecibida;
                var stockTotal = productoStockDto.Stock;

                this.maper.Map(productoStockDto, productoPedido);
                await this.context.SaveChangesAsync();
                //Agregamos el registro de la recepcion.
                NuevaRecepcionMaterialDTO nuevaRecepcionDTO = new NuevaRecepcionMaterialDTO
                {
                    IdProducto = nuevaRecepcion.IdProducto,
                    IdProvedor = nuevaRecepcion.IdProvedor,
                    CantidadPedida = nuevaRecepcion.CantidadPedida,
                    CantidadRecibida = nuevaRecepcion.CantidadRecibida,
                    Fecha = DateTime.UtcNow,
                };
                var productoRecepcionDTO = this.maper.Map<NuevaRecepcionMaterialDTO, Recepcion> (nuevaRecepcionDTO);
                await this.context.Recepciones.AddAsync(productoRecepcionDTO);
                await this.context.SaveChangesAsync();
                /**
                 * Quedaría por eliminar el registro de la tabla de pedidosMaterial
                 */
                LogPedidosProductos reg = await this.GetRegistroRecepcion(numeroRegistro);
                this.context.Remove(reg);
                await this.context.SaveChangesAsync();
                transaction.Commit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
            }
            
        }

        public async Task<LogPedidosProductos> GetRegistroRecepcion(int numeroRegistro)
        {
            return await this.context.Logs.FirstOrDefaultAsync(registro => registro.IdLog == numeroRegistro);
        }
        #endregion
    }
}
