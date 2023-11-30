using AutoMapper;
using Microsoft.Extensions.Options;
using TiendaCodeFirst.Data.Dtos;
using TiendaCodeFirst.Models;

namespace TiendaCodeFirst.Data.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles() {
            CreateMap<Producto, ProductoPedidosStockDTO>().ReverseMap()
            .ForMember(p => p.Lineas, option => option.Ignore());
            CreateMap<Producto, NuevoProductoDTO>().ReverseMap()
            .ForMember(p => p.Lineas, option => option.Ignore());
            CreateMap<Ventas, NuevaVentaDTO>().ReverseMap()
            .ForMember(p => p.Producto, option => option.Ignore());
            CreateMap<Ventas, EditVentaDTO>().ReverseMap()
            .ForMember(p => p.Producto, option => option.Ignore());
            CreateMap<LogPedidosProductos, RegistroPedidosLogsDTO>().ReverseMap();
            CreateMap<Recepcion, NuevaRecepcionMaterialDTO>().ReverseMap();
        }
        
    }
}
