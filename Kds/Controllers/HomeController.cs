using Kds.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kds.Controllers
{
    public class HomeController : Controller
    {
        AppContextMy dbCon;
        public HomeController()
        {
            dbCon = new AppContextMy();
            //dbCon.Users.Add(new User() { Age = 15, Name = "Dima" });
            //dbCon.SaveChanges();
        }

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
        //@model IEnumerable<Kds.Models.User>
        public ActionResult View1()
        {
            ViewBag.Message = "Your contact page.777";

            return View(dbCon.Users);
        }

        public ActionResult Delete(int id)
        {
            ViewBag.Message = "Your contact page.";
            var x= dbCon.Users.First(el=>el.Id==id);
            dbCon.Users.Remove(x);

            return RedirectToAction("View1");
        }
    }
}