using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {
            var pulque = new Models.Producto
            {
                Nombre = "pulque1",
                Descripcion = "fresa",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 2)
            };
            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return Content("<h1>Amanda <br>Torres</>");
            //return View();
        }

        public RedirectResult vista()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult Vista2()
        {
            TempData["Nombre"] = "Amanda";
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";

            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }

            ViewBag.valor = nombre;
            return View();
        }
    }
}