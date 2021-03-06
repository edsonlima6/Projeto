﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Ninject.Syntax;
using TeleHelp.Application.Interface;
using TeleHelp.Application.Services;
using TeleHelp.Domain.Interfaces.Services;
using TeleHelp.Domain.Services;
using TeleHelp.Domain.Interfaces.Repositories;
using TeleHelp.Infraestrutura.Data.Repositorio;

namespace MyBI_Identity.App_Start
{
    public class Ninject
    {
        //Cria o Container
        public static IKernel kernel { get; private set; }

        public static void ConfigurarDependencias()
        {

            kernel = new StandardKernel();

            //Instrução para mapear a interface IPessoa para a classe concreta Pessoa


            kernel.Bind<IUsuarioAplication>().To<UsuarioAplication>();
            kernel.Bind<IUsuarioService>().To<UsuarioService>();
            kernel.Bind<IUsuarioRepository>().To<UsuarioRespository>();

            kernel.Bind<ITipoEmpresaApplication>().To<TipoEmpresaApplication>();
            kernel.Bind<ITipoEmpresaService>().To<TipoEmpresaService>();
            kernel.Bind<ITipoEmpresaRepository>().To<TipoEmpresaRepository>();

            kernel.Bind<IEstadoApplication>().To<EstadoApplication>();
            kernel.Bind<IEstadoService>().To<EstadoService>();
            kernel.Bind<IEstadoRepository>().To<EstadoRepository>();

            kernel.Bind<IEmpresaApplication>().To<EmpresaApllication>();
            kernel.Bind<IEmpresaService>().To<EmpresaService>();
            kernel.Bind<IEmpresaRepository>().To<EmpresaRepository>();

            //Registra o container no ASP.NET
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }

    }
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IResolutionRoot _resolutionRoot;

        public NinjectDependencyResolver(IResolutionRoot kernel)
        {
            _resolutionRoot = kernel;
        }

        public object GetService(Type serviceType)
        {
            return _resolutionRoot.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolutionRoot.GetAll(serviceType);
        }
    }
}