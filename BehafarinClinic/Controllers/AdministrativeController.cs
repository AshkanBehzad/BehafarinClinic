using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MentalHealthClinic.Models;

namespace MentalHealthClinic.Controllers
{
    public class AdministrativeController : Controller
    {
        // GET: Administrative
        public ActionResult Index()
        {
            return View();
        }

        // User Management Logic
        public ActionResult UserList()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(AddUserViewModel model)
        {

            return View();
        }






        // Role Management Logic
        public ActionResult RoleList()
        {
            return View();
        }

        public ActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(AddUserViewModel model)
        {

            return View();
        }
    }
}