using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {

        public static int CaeateEmployee(int employeeid,
            string firstname,
            string lastname,
            string emailaddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeid,
                Firstname = firstname,
                Lastname = lastname,
                Emailaddress = emailaddress,


            };
            string sql = @"insert into dbo.Employee(EmployeeId,Firstname,Lastname,Emailaddress)
                           values(@EmployeeId,@Firstname,@Lastname,@Emailaddress);";


            return SqlDataAccess.SaveData(sql, data);


        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select ID,EmployeeId,Firstname,Lastname,Emailaddress from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);


        }


    }

}