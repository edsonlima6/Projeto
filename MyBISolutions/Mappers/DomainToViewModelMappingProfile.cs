using AutoMapper;
using MyBISolutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleHelp.Domain.Entities;

namespace MyBISolutions.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioModel>();
            CreateMap<UsuarioModel,Usuario>();
        }
        // Não realizar este override na versão 4.x e superiores
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        //protected override void Configure()
        //{
        //    //Mapper..CreateMap<UsuarioModel, Usuario>();
        //}
    }

}