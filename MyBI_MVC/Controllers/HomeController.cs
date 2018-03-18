using MyBI_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBI_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //Quinto commit mlk doido
            //using (var con = new CorreioService.AtendeClienteClient())
            //{
            //    var enderecoCliente = con.consultaCEP("06226130");


            //}

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