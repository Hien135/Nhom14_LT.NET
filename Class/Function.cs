using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom14_LT.NET.Class
{
    internal class Function
    {
        public static SqlConnection Conn = new SqlConnection();
        public static string ConnString = "Data Source=DESKTOP-6RBUAUT\\SQLEXPRESS;" +
                                                 "Initial Catalog=QuanLyNhanVien;" +
                                                 "Integrated Security=True;Encrypt=False";


        public static void Connect()
        {
            Conn.ConnectionString = ConnString;
            try
            {
                if (Conn != null & Conn.State == ConnectionState.Closed)
                    Conn.Open();
                // MessageBox.Show("kết nối thành công");

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Disconnect()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
                Conn.Dispose();
                Conn = null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable LoadDataToTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Function.Conn);
            adapter.Fill(dt);
            return dt;
        }
        public static bool checkkey(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Function.Conn);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public static void Runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Function.Conn;
            cmd.CommandText = sql;
            // có 2 cách thực thi sqlcommand
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//giải phóng
            cmd = null;
        }
    }
}
