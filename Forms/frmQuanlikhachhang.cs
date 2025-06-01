using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlikhachhang
{
    public partial class frmQLKH : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyThueSach;Integrated Security=True");

        public frmQLKH()
        {
            InitializeComponent();
            this.Load += frmQLKH_Load;
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            LoadData();
            if (cboGioitinh.Items.Count == 0)
                cboGioitinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });

            //btnThem.Click += btnThem_Click;
           // btnLuu.Click += btnLuu_Click;
           // btnSua.Click += btnSua_Click;
           // btnXoa.Click += btnXoa_Click;
          //  btnTimkiem.Click += btnTimkiem_Click;
           // btnDong.Click += btnDong_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private bool CheckMaTrung(string maKH)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM KhachHang WHERE MaKhach = '" + maKH + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        private void ResetForm()
        {
            txtMakhach.Clear();
            txtTenkhach.Clear();
            txtDiachi.Clear();
            mskSdt.Clear();
            cboGioitinh.Text = "";
            dtNgaysinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtMakhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckMaTrung(txtMakhach.Text))
            {
                MessageBox.Show("Mã khách đã tồn tại!");
                return;
            }
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = "INSERT INTO KhachHang VALUES (@Ma, @Ten, @NgaySinh, @GT, @DiaChi, @SDT)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", txtMakhach.Text);
                cmd.Parameters.AddWithValue("@Ten", txtTenkhach.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaysinh.Value);
                cmd.Parameters.AddWithValue("@GT", cboGioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@SDT", mskSdt.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMakhach.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ bảng hoặc nhập mã khách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa thông tin khách này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = "UPDATE KhachHang SET TenKhach = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GT, DiaChi = @DiaChi, DienThoai = @SDT WHERE MaKhach = @Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", txtMakhach.Text);
                cmd.Parameters.AddWithValue("@Ten", txtTenkhach.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtNgaysinh.Value);
                cmd.Parameters.AddWithValue("@GT", cboGioitinh.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@SDT", mskSdt.Text);
                int rows = cmd.ExecuteNonQuery();
                LoadData();
                if (rows > 0)
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không tìm thấy khách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMakhach.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                string sql = "DELETE FROM KhachHang WHERE MaKhach = @Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", txtMakhach.Text);
                int rows = cmd.ExecuteNonQuery();
                LoadData();
                if (rows > 0)
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không tìm thấy khách để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xoá: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();

                string sql = "SELECT * FROM KhachHang WHERE 1=1";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrWhiteSpace(txtMakhach.Text))
                {
                    sql += " AND MaKhach LIKE @MaKhach";
                    cmd.Parameters.AddWithValue("@MaKhach", "%" + txtMakhach.Text.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(txtTenkhach.Text))
                {
                    sql += " AND TenKhach LIKE @TenKhach";
                    cmd.Parameters.AddWithValue("@TenKhach", "%" + txtTenkhach.Text.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(mskSdt.Text.Trim().Replace(" ", "")))
                {
                    sql += " AND DienThoai LIKE @SDT";
                    cmd.Parameters.AddWithValue("@SDT", "%" + mskSdt.Text.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(txtDiachi.Text))
                {
                    sql += " AND DiaChi LIKE @DiaChi";
                    cmd.Parameters.AddWithValue("@DiaChi", "%" + txtDiachi.Text.Trim() + "%");
                }
                if (!string.IsNullOrWhiteSpace(cboGioitinh.Text))
                {
                    sql += " AND GioiTinh LIKE @GT";
                    cmd.Parameters.AddWithValue("@GT", "%" + cboGioitinh.Text.Trim() + "%");
                }

                cmd.CommandText = sql;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMakhach.Text = row.Cells["MaKhach"].Value.ToString();
                txtTenkhach.Text = row.Cells["TenKhach"].Value.ToString();
                dtNgaysinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                cboGioitinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                mskSdt.Text = row.Cells["DienThoai"].Value.ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
