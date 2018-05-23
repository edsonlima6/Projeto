﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;

namespace MyBI_Identity.Controllers
{
    public class HomeController : Controller
    {
        IUsuarioAplication usuarioAplication;
        public HomeController(IUsuarioAplication _usuarioAplication)
        {
            
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[Authorize(Roles ="Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}