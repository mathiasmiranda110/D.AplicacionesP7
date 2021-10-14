using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppMVC02.datos;
using AppMVC02.Models;

namespace AppMVC02.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerAdmin admin = new CustomerAdmin();
       
       
 public ActionResult Index()
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(PRODUCTOS modelo)
        {
            admin.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(PRODUCTOS modelo)
        {
            admin.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            PRODUCTOS modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }

    }
}