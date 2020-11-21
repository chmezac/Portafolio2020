using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transbank.Webpay;
using RestauranteDatos;
using RestauranteWeb.Models;
using RestauranteWeb.Models.Repos;

namespace RestauranteWeb.Controllers
{
    public class WebPayController : Controller
    {

        //private PLATO context = new PLATO();


        // GET: WebPay
        public ActionResult Index()
        {

            var transaction = new Webpay(Configuration.ForTestingWebpayPlusNormal()).NormalTransaction;

            var amount = 8790;
            var buyOrder = new Random().Next(100000, 999999999).ToString();
            var sessionId = "sessionId";

            string returnUrl = "http://localhost:50386/WebPay/Return";
            string finalUrl = "http://localhost:50386/Webpay/Final";

            var initResult = transaction.initTransaction(amount, buyOrder, sessionId, returnUrl, finalUrl);

            var tokenWs = initResult.token;
            var formAction = initResult.url;

            ViewBag.Amount = amount;
            ViewBag.BuyOrder = buyOrder;
            ViewBag.TokenWs = tokenWs;
            ViewBag.FormAction = formAction;

            return View();
        }


        public ActionResult Return()
        {
            var transaccion = new Webpay(Configuration.ForTestingWebpayPlusNormal()).NormalTransaction;
            string tokenWs = Request.Form["token_ws"];

            var resultado = transaccion.getTransactionResult(tokenWs);
            var output = resultado.detailOutput[0];
            if (output.responseCode == 0)
            {
                ViewBag.UrlRedirection = resultado.urlRedirection;
                ViewBag.TokenWs = tokenWs;
                ViewBag.ResponseCode = output.responseCode;
                ViewBag.Amount = output.amount;
                ViewBag.AuthorizationCode = output.authorizationCode;
            }

            return View();
        }

        public ActionResult Final()
        {
            return View();
        }

    }
}