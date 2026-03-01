using _07_DataBase_CRUD.BLL;
using _07_DataBase_CRUD.Models;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System;

namespace _07_DataBase_CRUD
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            EmployeeBLL bll = new EmployeeBLL();

            var list = bll.GetAllEmployees();

            foreach (var emp in list)
            {
                Console.WriteLine($"{emp.EmployeeID} | {emp.Name} | {emp.Salary}");
            }

            // 添加测试
            //bll.AddEmployee(new Employee
            //{
            //    Name = "企业测试",
            //    Gender = "男",
            //    Age = 30,
            //    Department = "技术部",
            //    Salary = 10000,
            //    HireDate = DateTime.Now
            //});

            bll.DeleteEmployee("企业测试");
            Console.WriteLine("操作完成");
        }
    }
}
