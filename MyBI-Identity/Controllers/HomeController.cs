using EP.IdentityIsolation.Infra.CrossCutting.Identity.Configuration;
using Microsoft.AspNet.Identity.Owin;
using MyBI_Identity.Models.AreaCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeleHelp.Application.Interface;

namespace MyBI_Identity.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
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

        [AllowAnonymous]
        [HttpPost]
        [AcceptVerbs(HttpVerbs.Post)]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Login( UsuarioViewModel usuarioViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(usuarioViewModel);
                }

                var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager2>();
                
                var user = await userManager.FindAsync(usuarioViewModel.Login, usuarioViewModel.Senha);
                if (user != null) 
                {

                    var appAsign = HttpContext.GetOwinContext().Get<ApplicationSignInManager2>();

                    appAsign.SignIn(user, true, true);

                    return View("index");
                }
                //var n = new HttpStatusCodeResult(HttpStatusCode.Unauthorized, "No Acess");

                return View("index");
                //return  RedirectToAction("Index", "Client");
                //return Redirect("google.com");
            }
            catch (Exception)
            {
                return View("index");
            }
        }
    }
}