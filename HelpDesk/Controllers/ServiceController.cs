using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelpDesk.Controllers
{
    [Authorize (Roles = "Администратор")]
    public class ServiceController : Controller
    {
        HelpdeskContext db = new HelpdeskContext();

        [HttpGet]
        public ActionResult Departments()
        {
            ViewBag.Departments = db.Departments;
            return View();
        }

        [HttpPost]
        public ActionResult Departments(Department depo)
        {
            if(ModelState.IsValid)
            {
                db.Departments.Add(depo);
                db.SaveChanges();
            }
            ViewBag.Departments = db.Departments;
            return View(depo);
        }

        public ActionResult DeleteDepartment(int id)
        {
            Department depo = db.Departments.Find(id);
            db.Departments.Remove(depo);
            db.SaveChanges();
            return RedirectToAction("Departments");
        }

    }
}