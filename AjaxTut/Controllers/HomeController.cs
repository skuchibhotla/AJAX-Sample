using AjaxTut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTut.Controllers
{
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

        [HttpPost]
        public ActionResult AddUser(string UserName, string Email, string Password)     // Pass all the fields that were passed in the AJAX data field. 
        {
            var user = new UserModel();

            user.UserName = UserName;
            user.Email = Email;
            user.Password = Password;
            
            return Json(user, JsonRequestBehavior.AllowGet);
        }
    }
}