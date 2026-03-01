using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DataBase_CRUD.DAL
{
    public class SqlHelper
    {
        private static readonly string connStr =
            "Server=localhost;Database=MyDatabase1;User Id=cien;Password=123456;TrustServerCertificate=True;";

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            //using 已经自动关闭连接了
            //不需要手动 conn.Close()
            using SqlConnection conn = new SqlConnection(connStr);
            using SqlCommand cmd = new SqlCommand(sql, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            //当关闭 reader 时，自动关闭 connection
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
