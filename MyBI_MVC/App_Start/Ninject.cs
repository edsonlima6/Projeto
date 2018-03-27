using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Ninject.Syntax;
using MyBI_MVC.Models;

namespace MyBI_MVC.App_Start
{
    public class Ninject
    {
        public static void ConfigurarDependencias()
        {
            //Cria o Container 
            IKernel kernel = new StandardKernel();

            //Instrução para mapear a interface IPessoa para a classe concreta Pessoa
            kernel.Bind<Models.IClienteModel>().To<Cliente>();

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