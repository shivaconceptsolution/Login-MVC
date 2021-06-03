using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFirst.Models;
namespace DataFirst.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login obj)
        {
            var s = (from c in db.Logins where c.UserId.Equals(obj.UserId) && c.Password.Equals(obj.Password) select c).FirstOrDefault();
            if (s != null)
            {
                return RedirectToAction("Index", "Emp");
            }
            ViewBag.data = "Invalid userid and password";
            return View();
        }

    }
}
