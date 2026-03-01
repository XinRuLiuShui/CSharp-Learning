using _07_DataBase_CRUD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DataBase_CRUD.DAL
{
    public class EmployeeDAL
    {
        public List<Employee> GetAll()
        {
            string sql = "SELECT * FROM Employees";
            var list = new List<Employee>();

            using var reader = SqlHelper.ExecuteReader(sql, new SqlParameter[0]);

            while (reader.Read())
            {
                list.Add(new Employee
                {
                    EmployeeID = (int)reader["EmployeeID"],
                    Name = reader["Name"]?.ToString() ?? string.Empty,  // 如果为 null，返回空字符串
                    Gender = reader["Gender"]?.ToString() ?? string.Empty,
                    Age = (int)reader["Age"],
                    Department = reader["Department"]?.ToString() ?? string.Empty,
                    Salary = (decimal)reader["Salary"],
                    HireDate = (DateTime)reader["HireDate"]
                });
            }

            return list;
        }

        public int Insert(Employee emp)
        {
            string sql = @"INSERT INTO Employees
                        (Name, Gender, Age, Department, Salary, HireDate)
                        VALUES (@Name, @Gender, @Age, @Department, @Salary, @HireDate)";

            SqlParameter[] parameters =
            {
                new("@Name", emp.Name),
                new("@Gender", emp.Gender),
                new("@Age", emp.Age),
                new("@Department", emp.Department),
                new("@Salary", emp.Salary),
                new("@HireDate", emp.HireDate)
            };

            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int Delete(string name)
        {
            string sql = "DELETE FROM Employees WHERE Name=@Name";

            SqlParameter[] parameters =
            {
                new("@Name", name)
            };

            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
