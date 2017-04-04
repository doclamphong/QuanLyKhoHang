using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyKhoHang.DataAccessLayer
{
    public static class SqlHelper 
    {
        private static SqlConnection GetConnection()
        {
            //server=EliteBook\SQL2012
            return new SqlConnection("server=.;database=QuanLyKhoHang;user=sa;password=123456");
        }
        public static int ExecuteCommand(string query, params SqlParameter[] parameterList)
        {
            int result = 0;
            using (SqlConnection sqlConn = GetConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddRange(parameterList);
                sqlConn.Open();
                result = cmd.ExecuteNonQuery();
            }
            return result;

        }
        public static SqlDataReader ExecuteReader(string query , params SqlParameter[] parameterList)
        {
            try
            {
                SqlConnection sqlConn = GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddRange(parameterList);
                sqlConn.Open();
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
    }
}
