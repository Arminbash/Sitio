using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using muestra.Models;
namespace muestra.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(users model)
        {
            if (ModelState.IsValid)
            {
                muestraEntities1 db = new muestraEntities1();
                users user = db.users.Where(x => x.correo == model.correo && x.pass == model.pass).FirstOrDefault();
                if (user != null)
                {
                    return RedirectToAction("Index", "Home", new { user.id });
                }
                else
                {
                    ViewBag.Error= "Correo o contraseña invalido.";
                }
            }

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }
	}
}