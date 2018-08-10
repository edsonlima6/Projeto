using MyBI_Identity.App_Start;
using MyBI_Identity.Models;
using MyBI_Identity.Models.AreaCliente;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.Entities;

namespace MyBI_Identity.Controllers
{
    public class ClientController : Controller
    {
        ITipoEmpresaApplication _tipoEmpresaApplication;
        IEstadoApplication _estadoApplication;
        public ClientController(ITipoEmpresaApplication tipoEmpresaApplication, IEstadoApplication estadoApplication)
        {
            _tipoEmpresaApplication = tipoEmpresaApplication;
            _estadoApplication = estadoApplication;
        }

        List<TipoEmpresaViewModels> tipoEmpresaViewModels;
        List<TipoEmpresaViewModels> ListTipoEmpresa
        {
            get { return (tipoEmpresaViewModels == null) ? MapperConfig._Mapper.Map<List<TipoEmpresaViewModels>>(_tipoEmpresaApplication.GetAll().ToList()) : tipoEmpresaViewModels; }

        }

        List<EstadoViewModel> estadoViewModels;
        List<EstadoViewModel> ListEstadoVM
        {
            get { return estadoViewModels ?? MapperConfig._Mapper.Map<List<EstadoViewModel>>(_estadoApplication.GetAll().ToList()); }
        }

        IEmpresaApplication _empresaApplication { get { return App_Start.Ninject.kernel.Get<IEmpresaApplication>(); } }


        // GET: Client
        public ActionResult Index()
        {
            return EmpresaCadastro();
        }

        [HttpGet]
        public ActionResult EmpresaCadastro()
        {
            var empresaVM = new EmpresaViewModels();
            empresaVM.tpEmpresasVM = ListTipoEmpresa;
            empresaVM.EstadoVM = ListEstadoVM;            
            return View("EmpresaCadastro", empresaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpresaCadastro(EmpresaViewModels empresaViewModels)
        {
            if (!ModelState.IsValid)
            {
                empresaViewModels.tpEmpresasVM = ListTipoEmpresa;
                empresaViewModels.EstadoVM = ListEstadoVM;
                return View(empresaViewModels);
            }

            _empresaApplication.Add(MapperConfig._Mapper.Map<Empresa>(empresaViewModels));


            return View("Home");
        }

    }
}