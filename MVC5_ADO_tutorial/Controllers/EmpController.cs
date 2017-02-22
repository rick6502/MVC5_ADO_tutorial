using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVC5_ADO_tutorial.Models;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using MVC5_ADO_tutorial.DAC;

namespace MVC5_ADO_tutorial.Controllers
{
    public class EmpController : Controller
    {


        ///<summary>  
        ///Action method which  
        ///insert the data into database by capturing  
        ///Model values which comes from user as input  
        ///</summary>  
        public ActionResult AddNewEmployee(EmpModel Emp)
        {
            //To Prevent firing validation error on first page Load  

            if (ModelState.IsValid)
            {

                string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
                EmployeeDAC employeeDAC = new EmployeeDAC(constr);
                int i = employeeDAC.AddNewRecord(Emp);

                if (i >= 1)
                {
                    ViewBag.Message = "New Employee Added Successfully";
                }

            }
            ModelState.Clear();
            return View();
            
        }
    }
}