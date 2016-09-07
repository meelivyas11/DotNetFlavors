using Jquery_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery_Ajax.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserDetails()
        {
            return View();
        }

        public JsonResult GetUserDetails(int userId)
        {
            UserModal user = new UserModal();
            user.FirstName = "Meeli";
            user.LastName = "Vyas";
            return Json(new { isSuccess = true, userModal = user }, JsonRequestBehavior.AllowGet);
        }
    }
}