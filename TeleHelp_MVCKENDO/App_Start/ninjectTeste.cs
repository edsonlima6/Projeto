using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleHelp.Application.Interface;
using TeleHelp.Application.Services;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Domain.Interfaces.Services;
using TeleHelp.Domain.Services;
using TeleHelp.Infraestrutura.Data.Repositorio;

namespace TeleHelp_MVCKENDO.App_Start
{
    public class ninjectTeste : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAplicationBase<>)).To(typeof(AplicationBase<>));
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            Bind<IUsuarioAplication>().To<UsuarioAplication>();
            Bind<IUsuarioService>().To<UsuarioService>();
            Bind<IUsuarioRepository>().To<UsuarioRespositorio>();


        }


    }
}