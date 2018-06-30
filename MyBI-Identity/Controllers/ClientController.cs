using MyBI_Identity.App_Start;
using MyBI_Identity.Models;
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
            var tp = _tipoEmpresaApplication.GetAll()
                                            .ToList();


            var vm = MapperConfig._Mapper
                                 .Map<List<TipoEmpresaViewModels>>(tp);

            var estado = _estadoApplication.GetAll()
                                           .Select(e => new { idEstado = e.IdEstado, sigla = e.Sigla });



            return View("EmpresaCadastro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpresaCadastro(EmpresaViewModels empresaViewModels)
        {
            if (ModelState.IsValid)
            {
                return View("Home");
            }
            return View(empresaViewModels);
        }

    }
}