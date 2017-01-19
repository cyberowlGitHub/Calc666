using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calc.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Calc()
        {
            ViewBag.Message = "Página Calc.";
            return View();
        }

        public JsonResult ReceiveClick(int orderFormId)
        {
            string message = "3";

            return this.Json(new { reloadIntegration = true, orderFormId = orderFormId, message = message }, JsonRequestBehavior.AllowGet);
        }
    }
}