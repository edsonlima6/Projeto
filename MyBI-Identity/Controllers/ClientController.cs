using MyBI_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;

namespace MyBI_Identity.Controllers
{
    public class ClientController : Controller
    {
        ITipoEmpresaApplication _tipoEmpresaApplication;
        public ClientController(ITipoEmpresaApplication tipoEmpresaApplication)
        {
            _tipoEmpresaApplication = tipoEmpresaApplication;
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
            var tp = _tipoEmpresaApplication.GetAll().ToList();

            return View("EmpresaCadastro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpresaCadastro(EmpresaViewModels empresaViewModels)
        {
            return View("EmpresaCadastro");
        }

    }
}