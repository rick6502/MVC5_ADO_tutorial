using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC5_ADO_tutorial.Models;

namespace MVC5_ADO_tutorial.Controllers
{
    public class EmpController : Controller
    {
        public ActionResult AddNewEmployee(EmpModel Emp)
        {

            return View();

        }
    }
}