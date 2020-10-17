using RestauranteNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RestauranteWeb.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult Login()
        {
            return View();          
        }

        [HttpPost]
        public ActionResult Login(Cliente cliente, string ReturnUrl)
        {

            if (IsValid(cliente))
            {

                FormsAuthentication.SetAuthCookie(Convert.ToString(cliente.Rut), false);

                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }

                return RedirectToAction("Index", "Home");

            }

            TempData["mensaje"] = "No existe el usuario en el sistema.";
            return View(cliente);
        }

        private bool IsValid(Cliente cliente)
        {
          return cliente.Autenticar();

        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");

        }
    }
}