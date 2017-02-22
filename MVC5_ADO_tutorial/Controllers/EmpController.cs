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


        //private SqlConnection con;
        //private void connection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
        //    con = new SqlConnection(constr);

        //}


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
                /*
                connection();
                SqlCommand com = new SqlCommand("InsertData", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FName", Emp.FName);
                com.Parameters.AddWithValue("@MName", Emp.MName);
                com.Parameters.AddWithValue("@LName", Emp.LName);
                com.Parameters.AddWithValue("@EmailId", Emp.EmailId);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                */
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