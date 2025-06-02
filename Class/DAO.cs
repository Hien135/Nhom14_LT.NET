using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyThueSach
{
    internal class DAO
    {
        // conect to database
        public static SqlConnection conn = new SqlConnection();
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        public static void Connect()
        {
            conn.ConnectionString = ConnectionString;
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối thất bại: " + ex.Message);
            }
        }
        public static void Close()
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

        public static DataTable loadDataToTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        // ham kiem tra khoa nhap vao
        public static bool checkKey(string sql)
        {
            bool result = false;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) { result = true; }
            return result;

        }
        

        public void fillComboBox(ComboBox cb, string sql, string value, string display)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }
    }
}
