using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using arackiralamaproject.Models.Entity;


namespace arackiralamaproject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dbkiralikaracEntities1 db = new dbkiralikaracEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBLCARS.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
       
        {
            

            return View();
        }
    }


}