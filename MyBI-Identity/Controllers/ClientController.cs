using MyBI_Identity.App_Start;
using MyBI_Identity.Models;
using MyBI_Identity.Models.AreaCliente;
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
        // GET: Client
        public ActionResult Index()
        {
            return EmpresaCadastro();
        }

        [HttpGet]
        public ActionResult EmpresaCadastro()
        {
            var empresaVM = new EmpresaViewModels();
            var tpE = _tipoEmpresaApplication.GetAll().ToList();
            var estado = _estadoApplication.GetAll().ToList();
            empresaVM.tpEmpresasVM  = MapperConfig._Mapper.Map<List<TipoEmpresaViewModels>>(tpE);
            empresaVM.EstadoVM = MapperConfig._Mapper.Map<List<EstadoViewModel>>(estado);
            
            return View("EmpresaCadastro", empresaVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpresaCadastro(EmpresaViewModels empresaViewModels)
        {
            if (!ModelState.IsValid)
            {
                var empresaVM = new EmpresaViewModels();
                var tpE = _tipoEmpresaApplication.GetAll().ToList();
                var estado = _estadoApplication.GetAll().ToList();
                empresaVM.tpEmpresasVM = MapperConfig._Mapper.Map<List<TipoEmpresaViewModels>>(tpE);
                empresaVM.EstadoVM = MapperConfig._Mapper.Map<List<EstadoViewModel>>(estado);
                return View(empresaViewModels);
            }
            return View("Home");
        }

    }
}