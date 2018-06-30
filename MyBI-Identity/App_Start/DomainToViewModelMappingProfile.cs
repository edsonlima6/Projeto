using AutoMapper;
using MyBI_Identity.Models;
using TeleHelp.Domain.Entities;

namespace MyBI_Identity.App_Start
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Empresa, EmpresaViewModels>();
            CreateMap<TipoEmpresa, TipoEmpresaViewModels>();
        }
    }
}