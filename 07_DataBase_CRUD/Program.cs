using System;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace _07_DataBase_CRUD
{
    internal class Program
    {
        // 数据库连接字符串
        static string connStr = "Server=localhost;Database=MyDatabase1;User Id=cien;Password=123456;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            //SelectEmployees();

            //InsertEmployee();

            //UpdateEmployee();

            DeleteEmployee();
        }

        // 查询所有员工
        static void SelectEmployees()
        {
            string sql = "SELECT * FROM Employees";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmployeeID"]} | {reader["Name"]} | {reader["Salary"]}");
                }

                reader.Close();
            }
        }

        static void InsertEmployee()
        {
            string sql = @"INSERT INTO Employees
                   (Name, Gender, Age, Department, Salary, HireDate)
                   VALUES (@Name, @Gender, @Age, @Department, @Salary, @HireDate)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", "测试");
                cmd.Parameters.AddWithValue("@Gender", "男");
                cmd.Parameters.AddWithValue("@Age", 26);
                cmd.Parameters.AddWithValue("@Department", "技术部");
                cmd.Parameters.AddWithValue("@Salary", 9000);
                cmd.Parameters.AddWithValue("@HireDate", DateTime.Now);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine("影响行数：" + rows);
            }
        }

        static void UpdateEmployee()
        {
            string sql = "UPDATE Employees SET Salary = @Salary WHERE Name = @Name";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Salary", 15000);
                cmd.Parameters.AddWithValue("@Name", "张三");

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine("修改行数：" + rows);
            }
        }

        static void DeleteEmployee()
        {
            string sql = "DELETE FROM Employees WHERE Name = @Name";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", "测试");

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine("删除行数：" + rows);
            }
        }

    }
}
