using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using IDGS904_temaa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prueba()
        {
            return View();
        } 

        public ActionResult Vista(string n1, string n2)
        {
            int res = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            ViewBag.Res = Convert.ToString(res);
            return View();
        }

        public ActionResult Calcular(OperasBas op)
        {
            var model = new OperasBas();

            model.Res = op.Operasbas();

            return View(model);
        }

        public ActionResult MuestraPulques()
        {
           var pulques = new ProductoServices();
           var model =  pulques.ObtenerProducto();
            return View(model);


        }
    }
}