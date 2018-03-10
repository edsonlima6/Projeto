using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;
using TeleHelp.Application.Services;
using TeleHelp.Domain.DTO;
using TeleHelp.Domain.Services;
using TeleHelp_MVCKENDO.App_Start;

namespace TeleHelp_MVCKENDO.Controllers
{
    public class AutenticacaoController : Controller
    {
        IKernel kernel;
        public AutenticacaoController()
        {
            kernel = new StandardKernel(new ninjectTeste());
        }
        
        // GET: Autorizacao
        public ActionResult Index()
        {
            return View();
        }

        // GET: Autorizacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: Autorizacao/Create
        [HttpPost]
        public ActionResult Logar(UsuarioDTO usuario)
        {
            try
            {
                var UsuarioServico = kernel.Get<IUsuarioAplication>();
                var Logar = UsuarioServico.ValidaLogin(usuario.Login, usuario.Senha);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autorizacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Autorizacao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autorizacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autorizacao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
