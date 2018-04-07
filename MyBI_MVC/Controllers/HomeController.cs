using MyBI_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;

namespace MyBI_MVC.Controllers
{
    public class HomeController : Controller
    {
        IClienteModel _clienteModel;
        IUsuarioAplication usuarioApplication;
        public HomeController()
        {

        }

        [HttpGet]
        public ActionResult Index()
        {
            //usuarioApplication.Add(new TeleHelp.Domain.Entities.Usuario
            //{
            //    Ativo = true,
            //    DataCadastro = DateTime.Now,
            //    Email = "edsonlima6@gmail.com",
            //    IdTipoAtendimento = 1,
            //    Login = "efeitosa"
            //});
            //usuarioApplication.SaveChanges();
         

            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioVM usuario)
        {
            //if (ModelState.IsValid)
            //{
            //    if (usuario != null && usuario.Email.Equals("x"))
            //    {
            //        return View("Contact");
            //    }
            //    ModelState.AddModelError("Nome Inválido.. ", "Nome Não está correto");
            //    return View(usuario);
            //}

            return View(usuario);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}