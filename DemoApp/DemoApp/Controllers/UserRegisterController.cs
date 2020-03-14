using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class UserRegisterController : Controller
    {
        // GET: UserRegister
        public ActionResult UserRegister()
        {
            UserRegisterModel model = new UserRegisterModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult UserRegister(UserRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                //System.Text.StringBuilder sbMessage = new System.Text.StringBuilder();
                //sbMessage.Append("Your Name is : " + model.Name + "</br/>");
                //sbMessage.Append("Your Password is : " + model.Password + "</br/>");
                //sbMessage.Append("Your Email is : " + model.Email + "</br/>");
                //return Content(sbMessage.ToString());

                return View("Success", model); 
            }
            else
            {
                return View(model);
            }
        }

        // GET: UserLogin
        public ActionResult UserLogin()
        {
            return View();
        }
    }
}