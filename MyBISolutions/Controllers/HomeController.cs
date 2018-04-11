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
            usuarioAplication = _usuarioAplication;
        }
        public ActionResult Index()
        {
            //var vm = Mapper.Map<Usuario, UsuarioModel>(usuario);
            //var u = Mapper.Map<UsuarioModel, Usuario>(vm);
            return View();
        }

        [ValidateAntiForgeryToken]
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
            ViewBag.Message = "Soluções em finanças pessoais";

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult About(UsuarioModel usuarioModel)
        {
            if (ModelState.IsValid)
            {
                //return View(usuarioModel);
            }
            var usuarioDomain = Mapper.Map<UsuarioModel, Usuario>(usuarioModel);
            try
            {
                usuarioDomain.DataCadastro = DateTime.Now;
                usuarioDomain.Login = usuarioDomain.Email;
                usuarioAplication.Add(usuarioDomain);
                usuarioAplication.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
           

            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}