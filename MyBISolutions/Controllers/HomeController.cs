using AutoMapper;
using MyBISolutions.Models;
using MyBISolutions.Models.ClassesFuncionais;
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
        readonly IUsuarioAplication _usuarioAplication;
        readonly SessionUser _sessionUser;
        public HomeController(IUsuarioAplication usuarioAplication)
        {
            _usuarioAplication = usuarioAplication;
            _sessionUser = new SessionUser(_usuarioAplication);
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
            try
            {
                if (ModelState.IsValid)
                {
                    _sessionUser.ValidaSession(usuarioModel);
                    return RedirectToAction("About");
                }
                return View(usuarioModel);
            }
            catch (Exception ex)
            {
                ViewBag.MsgError = ex.Message;
                return View(usuarioModel);
            }
          
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
                try
                {
                    var validaLogin = _usuarioAplication.GetAll()
                                                        .Any(u => u.Email.Equals(usuarioModel.Email));
                                                     
                    if(validaLogin)
                    {
                        ViewBag.erroLogin = "E-mail existente na base de dados";                        
                    }
                    else
                    {
                        _sessionUser.AddUser(usuarioModel);
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    return View();
                }

            }
            return View(usuarioModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}