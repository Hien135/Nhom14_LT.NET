using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;


        namespace Nhom14_LT.NET.Forms
    {
        public partial class frmBaocaodoanhthu : Form
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QuanLyThueSach;Integrated Security=True");

            public frmBaocaodoanhthu()
            {
                InitializeComponent();
                this.Load += frmBaocaodoanhthu_Load;
                btnThongke.Click += btnThongke_Click;
                btnXuatexcel.Click += btnXuatexcel_Click;
                btnDong.Click += btnDong_Click;
            }
      
        private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
            }













            /*private void frmBaocaodoanhthu_Load(object sender, EventArgs e)
        {
            cboLoaithongke.Items.AddRange(new string[] { "Ngày", "Khách hàng", "Sách" });
            cboLoaithongke.SelectedIndex = 0;
        }*/
        private void frmBaocaodoanhthu_Load(object sender, EventArgs e)
        {
            if (cboLoaithongke.Items.Count == 0)
            {
                cboLoaithongke.Items.AddRange(new string[] { "Ngày", "Khách hàng", "Sách", "Nhân viên" });
            }
            cboLoaithongke.SelectedIndex = 0;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (cboLoaithongke.Text == "Ngày") ThongKeTheoNgay();
            else if (cboLoaithongke.Text == "Khách hàng") ThongKeTheoKhachHang();
            else if (cboLoaithongke.Text == "Sách") ThongKeTheoSach();
            else if (cboLoaithongke.Text == "Nhân viên") ThongKeTheoNhanVien();
        }
        private void HienThiTongDoanhThu(DataTable dt)
        {
            decimal tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong += Convert.ToDecimal(row["DoanhThu"]);
            }
            MessageBox.Show($"Tổng doanh thu: {tong:N0} VND", "Tổng kết", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThongKeTheoNhanVien()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = @"SELECT nv.TenNV, COUNT(ts.MaThue) AS SoLanTra, SUM(ts.TongTien) AS DoanhThu
                               FROM TraSach ts
                               JOIN ThueSach th ON ts.MaThue = th.MaThue
                               JOIN NhanVien nv ON th.MaNV = nv.MaNV
                               WHERE ts.NgayTra BETWEEN @TuNgay AND @DenNgay
                               GROUP BY nv.TenNV ORDER BY DoanhThu DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtTungay.Value.Date);
                cmd.Parameters.AddWithValue("@DenNgay", dtDenngay.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoanhthu.DataSource = dt;

                chartDoanhthu.Series.Clear();
                Series series = new Series("Doanh thu theo nhân viên");
                series.ChartType = SeriesChartType.Column;
                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["TenNV"].ToString(), Convert.ToDouble(row["DoanhThu"]));
                }
                chartDoanhthu.Series.Add(series);

                HienThiTongDoanhThu(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void ThongKeTheoNgay()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = @"SELECT NgayTra, SUM(TongTien) AS DoanhThu
                               FROM TraSach
                               WHERE NgayTra BETWEEN @TuNgay AND @DenNgay
                               GROUP BY NgayTra ORDER BY NgayTra";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtTungay.Value.Date);
                cmd.Parameters.AddWithValue("@DenNgay", dtDenngay.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoanhthu.DataSource = dt;

                chartDoanhthu.Series.Clear();
                Series series = new Series("Doanh thu theo ngày");
                series.ChartType = SeriesChartType.Column;
                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(Convert.ToDateTime(row["NgayTra"]).ToShortDateString(), Convert.ToDouble(row["DoanhThu"]));
                }
                chartDoanhthu.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void ThongKeTheoKhachHang()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = @"SELECT kh.TenKhach, COUNT(ts.MaThue) AS SoLanTra, SUM(ts.TongTien) AS DoanhThu
                               FROM TraSach ts
                               JOIN ThueSach th ON ts.MaThue = th.MaThue
                               JOIN KhachHang kh ON th.MaKhach = kh.MaKhach
                               WHERE ts.NgayTra BETWEEN @TuNgay AND @DenNgay
                               GROUP BY kh.TenKhach ORDER BY DoanhThu DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtTungay.Value.Date);
                cmd.Parameters.AddWithValue("@DenNgay", dtDenngay.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoanhthu.DataSource = dt;

                chartDoanhthu.Series.Clear();
                Series series = new Series("Doanh thu theo khách hàng");
                series.ChartType = SeriesChartType.Column;
                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["TenKhach"].ToString(), Convert.ToDouble(row["DoanhThu"]));
                }
                chartDoanhthu.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void ThongKeTheoSach()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string sql = @"SELECT s.TenSach, ctts.ThanhTien
FROM ChiTietTraSach ctts
JOIN Sach s ON ctts.MaSach = s.MaSach";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TuNgay", dtTungay.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@DenNgay", dtDenngay.Value.Date.ToString("yyyy-MM-dd"));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDoanhthu.DataSource = dt;

                chartDoanhthu.Series.Clear();
                Series series = new Series("Doanh thu theo sách");
                series.ChartType = SeriesChartType.Column;
                foreach (DataRow row in dt.Rows)
                {
                    string tenSach = row["TenSach"].ToString();
                    double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                    series.Points.AddXY(tenSach, doanhThu);
                }
                chartDoanhthu.Series.Add(series);

                HienThiTongDoanhThu(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê sách: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }







        private void btnXuatexcel_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)excelApp.ActiveSheet;

                for (int i = 1; i < dgvDoanhthu.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDoanhthu.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDoanhthu.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDoanhthu.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDoanhthu.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

       
    }
}
