using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestauranteDatos;
using RestauranteNegocio;
using RestauranteWeb.Models.Repos;



namespace RestauranteWeb.Controllers
{
    public class GarzonController : Controller
    {

        private GarzonRepo context = new GarzonRepo();

        // GET: Garzon
        public ActionResult Index()
        {
            return View();
        }

        // GET: Botones
        public ActionResult Garzon()
        {
            return View();
        }


        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Index(USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                USUARIO usu = new USUARIO();
                usu = context.buscarUsuario(usuario.RUT_USUARIO);
                if (usu == null)
                {
                    usuario.EMAIL_USUARIO = "No existe correo";
                    usu = context.buscarUsuario(usuario.RUT_USUARIO);

                }
                //System.Web.HttpContext.Current.Session["idusuario"] = usu.ID_USUARIO;
                //System.Web.HttpContext.Current.Session["usuario"] = usu.NOMBRE_USUARIO;
                return RedirectToAction("Garzon");
            }
            else
            {
                return View(usuario);
            }
        }

    }
}