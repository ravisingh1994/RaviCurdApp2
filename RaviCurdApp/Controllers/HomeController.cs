using RaviCurdApp.DB_New;
using RaviCurdApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaviCurdApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Studentdatils obj)
        {
            STUDENTSINFOEntities res = new STUDENTSINFOEntities();

            STUDETAIL obj1 = new STUDETAIL();

            obj1.SNAME = obj.SNAME;
            obj1.FEE = obj.FEE;
            obj1.ROLL = obj.ROLL;

            res.STUDETAILs.Add(obj1);
            res.SaveChanges();
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
    }
}