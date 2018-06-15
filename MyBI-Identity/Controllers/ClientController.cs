using MyBI_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBI_Identity.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View("EmpresaCadastro");
        }


        [HttpPost]
        public ActionResult EmpresaCadastro(EmpresaViewModels empresaViewModels)
        {
            return View("EmpresaCadastro");
        }
    }
}