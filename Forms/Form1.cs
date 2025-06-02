using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom14_LT.NET
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoScrollMargin = new Size(0, 0); // Đặt AutoScrollMargin để không có khoảng trống
            childForm.Dock = DockStyle.Fill;
            System.Diagnostics.Debug.WriteLine($"Kích thước panel_body: {panel_body.Size}");
            System.Diagnostics.Debug.WriteLine($"Vị trí panel_body: {panel_body.Location}");
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            System.Diagnostics.Debug.WriteLine("--- Debug Thông số Form con và Panel cha ---");

            // Thông tin của Panel chứa Form con (panel_body)
            System.Diagnostics.Debug.WriteLine($"Panel cha - Tên: {panel_body.Name}");
            System.Diagnostics.Debug.WriteLine($"Panel cha - Vị trí (Location): {panel_body.Location}");
            System.Diagnostics.Debug.WriteLine($"Panel cha - Kích thước (Size): {panel_body.Size}");
            System.Diagnostics.Debug.WriteLine($"Panel cha - Kích thước Client (ClientSize): {panel_body.ClientSize}"); // Kích thước thực tế bên trong, sau khi trừ Padding
            System.Diagnostics.Debug.WriteLine($"Panel cha - Padding: {panel_body.Padding}");

            // Thông tin của Form con (childForm)
            System.Diagnostics.Debug.WriteLine($"Form con - Tên: {childForm.Name}");
            System.Diagnostics.Debug.WriteLine($"Form con - Vị trí (Location): {childForm.Location}");
            System.Diagnostics.Debug.WriteLine($"Form con - Kích thước (Size): {childForm.Size}");
            System.Diagnostics.Debug.WriteLine($"Form con - Kích thước Client (ClientSize): {childForm.ClientSize}"); // Kích thước bên trong Form con
            System.Diagnostics.Debug.WriteLine($"Form con - Margin: {childForm.Margin}");
            System.Diagnostics.Debug.WriteLine($"Form con - FormBorderStyle: {childForm.FormBorderStyle}");
            System.Diagnostics.Debug.WriteLine($"Form con - TopLevel: {childForm.TopLevel}");
            System.Diagnostics.Debug.WriteLine($"Form con - MinimumSize: {childForm.MinimumSize}");


            System.Diagnostics.Debug.WriteLine("--- Kết thúc Debug ---");
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        /*private void btn_Sach_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmSach());
            label_top.Text = "Quản lý sách";
        }
        */
        private void btn_KhachHang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKH());
            label_top.Text = "Quản lý khách hàng";
        }

       /* private void btn_NhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
            label_top.Text = "Nhân viên";
        }

        private void btn_MuonTra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThueTraSach());
            label_top.Text = "Quản lý mượn trả sách";
        }

        private void btn_BaoCao_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCao());
            label_top.Text = "Báo cáo thống kê";
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label_top.Text = "Trang chủ";
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_top_Click(object sender, EventArgs e)
        {

        }
    }
}
