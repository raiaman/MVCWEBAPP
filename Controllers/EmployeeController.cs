using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            EmpModel emp = new EmpModel
            {
                EmpId = 100,
                Name = "Akbar",
                City = "Mum",
                Address = "xyz"

            };
            return View(emp);
        }
    }
}