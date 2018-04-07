using MyBISolutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleHelp.Domain.Entities;

namespace MyBISolutions.App_Start
{
    public static class MapConfig
    {
        public static void CreateAutoMapperMappings()
        {
            //AutoMapper.Mapper.CreateMap<Usuario, UsuarioModel>()
            //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            //    .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
            //    .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.Sobrenome));

            //AutoMapper.Mapper.CreateMap<UsuarioViewModel, Usuario>()
            //    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            //    .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
            //    .ForMember(dest => dest.Sobrenome, opt => opt.MapFrom(src => src.Sobrenome));
        }
    }
}