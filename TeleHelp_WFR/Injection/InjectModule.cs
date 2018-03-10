using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Application.Interface;
using TeleHelp.Application.Services;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Domain.Interfaces.Services;
using TeleHelp.Domain.Services;
using TeleHelp.Infraestrutura.Data.Repositorio;

namespace TeleHelp_WFR.Injection
{
    public class InjectModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAplicationBase<>)).To(typeof(AplicationBase<>));
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            Bind<IUsuarioAplication>().To<UsuarioAplication>();
            Bind<IUsuarioService>().To<UsuarioService>();
            Bind<IUsuarioRepository>().To<UsuarioRespository>();

            Bind<ICargoApplication>().To<CargoApplication>();
            Bind<ICargoService>().To<CargoService>();
            Bind<ICargoRepository>().To<CargoRepositories>();

            Bind<IGrupoApplication>().To<GrupoApplication>();
            Bind<IGrupoService>().To<GrupoService>();
            Bind<IGrupoRepository>().To<GrupoRepository>();

            Bind<IDepartamentoAppication>().To<DepartamentoApplication>();
            Bind<IDepartamentoService>().To<DepartamentoService>();
            Bind<IDepartamentoRepository>().To<DepartamentoRepository>();

            Bind<IRepresentanteApplication>().To<RepresentanteApplication>();
            Bind<IRepresentanteService>().To<RepresentanteService>();
            Bind<IRepresentanteRepository>().To<RepresentanteRepository>();

            Bind<IGrupoUsuarioApplication>().To<GrupoUsuarioApplication>();
            Bind<IGrupoUsuarioService>().To<GrupoUsuarioService>();
            Bind<IGrupoUsuarioRepository>().To<GrupoUsuarioRepository>();

            Bind<IRepresentanteUsuarioApplication>().To<RepresentanteUsuarioApplcation>();
            Bind<IRepresentanteUsuarioService>().To<RepresentanteUsuarioService>();
            Bind<IRepresentanteUsuarioRepository>().To<RepresentanteUsuarioRepository>();

            Bind<ITelaApplication>().To<TelaApplication>();
            Bind<ITelaService>().To<TelaService>();
            Bind<ITelaRepository>().To<TelaRepository>();

            Bind<IGrupoTelaApplication>().To<GrupoTelaApplication>();
            Bind<IGrupoTelaService>().To<GrupoTelaService>();
            Bind<IGrupoTelaRepository>().To<GrupoTelaRepository>();

        }
    }
}
