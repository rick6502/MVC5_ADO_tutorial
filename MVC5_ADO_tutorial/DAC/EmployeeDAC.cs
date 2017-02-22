using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using MVC5_ADO_tutorial.Models;

using System.Configuration;
using System.Data;



namespace MVC5_ADO_tutorial.DAC
{
    public class EmployeeDAC
    {

        public static string ConnectionString { get; set; }

        public EmployeeDAC(string connectString)
        {
            EmployeeDAC.ConnectionString = connectString;
        }

        private static SqlConnection DBConnectionSQL
        {
            get
            {
                SqlConnection sqlConn = new SqlConnection();
                string connString = ConnectionString;
                sqlConn.ConnectionString = connString;
                return sqlConn;
            }
        }


        public int AddNewRecord(EmpModel empModel)
        {
            int i = 0;

            using (var DBConn = DBConnectionSQL)
            {
                SqlCommand com = new SqlCommand("InsertData", DBConn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FName", empModel.FName);
                com.Parameters.AddWithValue("@MName", empModel.MName);
                com.Parameters.AddWithValue("@LName", empModel.LName);
                com.Parameters.AddWithValue("@EmailId", empModel.EmailId);
                DBConn.Open();
                i = com.ExecuteNonQuery();
            }
            return i;
        }



    }
}