using _07_DataBase_CRUD.DAL;
using _07_DataBase_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DataBase_CRUD.BLL
{
    public class EmployeeBLL
    {
        private EmployeeDAL dal = new EmployeeDAL();

        public List<Employee> GetAllEmployees()
        {
            return dal.GetAll();
        }

        public void AddEmployee(Employee emp)
        {
            dal.Insert(emp);
        }

        public void DeleteEmployee(string name)
        {
            dal.Delete(name);
        }
    }
}
