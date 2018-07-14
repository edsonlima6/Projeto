using AutoMapper;
using MyBI_Identity.Models;
using MyBI_Identity.Models.AreaCliente;
using TeleHelp.Domain.Entities;

namespace MyBI_Identity.App_Start
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EstadoViewModel, Estado >();
            CreateMap<TipoEmpresaViewModels, TipoEmpresa>();
            CreateMap<EmpresaViewModels, Empresa>();
        }
    }
}