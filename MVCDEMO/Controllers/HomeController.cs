using MVCDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace MVCDEMO.Controllers
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
        public ActionResult viewEmployees()
        {
            ViewBag.Message = "Employees List.";

            var data = LoadEmployees();
            List<EmployeeModel> employee = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employee.Add(new EmployeeModel {
                    EmployeeId = row.EmployeeId,
                    Firstname = row.Firstname,
                    Lastname = row.Lastname,
                    Emailaddress = row.Emailaddress,
                    ConfirmEmail = row.Emailaddress

                });
                
            }

            return View(employee);
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign Up.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CaeateEmployee(model.EmployeeId, model.Firstname, model.Lastname, model.Emailaddress);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Profile_Employee()
        {
            ViewBag.Message = "Profile Employee";

            return View();
        }
    }
}