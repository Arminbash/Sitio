using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using muestra.Models;
using System.IO;
namespace muestra.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
            //muestraEntities1 db = new muestraEntities1();
            //users user = db.users.Find(id);
            //var resultado = from t1 in db.users
            //                 join t2 in db.personas on t1.id equals t2.users_id
            //                 join t3 in db.imagenes on t2.imagen_id equals t3.id

            //                 where t1.id == id
            //                 select t2;
            personas resultado = new personas();
            using (var db = new muestraEntities1())
            {
                resultado = db.personas
                                .Where(x =>x.users_id  == id)
                                .Single();
            }
            ViewBag.nombre = resultado.nombre;
            ViewBag.id = resultado.id;
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

        public ActionResult FileUpload(HttpPostedFileBase FileUpload1)
        {
            if (FileUpload1 != null)
            {
                var db = new muestraEntities1();
                imagenes img = new imagenes();
                using (BinaryReader reader = new BinaryReader(FileUpload1.InputStream))
                {
                    byte[] image = reader.ReadBytes(FileUpload1.ContentLength);
                   img.imagen = image;
                    img.active=true;
                    db.imagenes.Add(img);
                db.SaveChanges();
                }

            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult convertirimagen(int id)
        {
            var db = new muestraEntities1();
            var pers = db.personas.Find(id);
            var s = db.imagenes.Where(x => x.id == pers.imagen_id).FirstOrDefault();
            if (s != null)
                return File(s.imagen, "image/jpeg");
            else
                return File("~/Images/prueba.png", "image/jpeg");
        }

    }
}