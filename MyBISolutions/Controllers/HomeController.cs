using AutoMapper;
using MyBISolutions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.Entities;

namespace MyBISolutions.Controllers
{
    public class HomeController : Controller
    {
        IUsuarioAplication usuarioAplication;
        public HomeController(IUsuarioAplication _usuarioAplication)
        {
            //usuarioAplication = _usuarioAplication;
        }
        public ActionResult Index()
        {
            var usuario = new Usuario()
            {
                Nome = "Edson"
            };
            var vm = Mapper.Map<Usuario, UsuarioModel>(usuario);
            var u = Mapper.Map<UsuarioModel, Usuario>(vm);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
              return  RedirectToAction("About");
            }
            return View(usuarioModel);
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