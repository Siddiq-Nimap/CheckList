using Jquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContex Empdb = new EmployeeContex();

        public ActionResult Index()
        {
            var data = Empdb.employees.ToList();

            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
         public ActionResult Create(Employee emp)
        {
            if(!ModelState.IsValid) { return View(); }
            Empdb.employees.Add(emp);
            Empdb.SaveChanges();
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