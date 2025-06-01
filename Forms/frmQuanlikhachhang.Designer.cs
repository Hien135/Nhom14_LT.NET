
using Nhom14_LT.NET;
namespace quanlikhachhang
{
    partial class frmQLKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMakhach = new System.Windows.Forms.Label();
            this.lblTenkhach = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            //this.quanLyThueSachDataSet = new quanlikhachhang.QuanLyThueSachDataSet();
            //this.khachHangTableAdapter = new quanlikhachhang.QuanLyThueSachDataSetTableAdapters.KhachHangTableAdapter();
            this.mskSdt = new System.Windows.Forms.MaskedTextBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioitinh = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
           // ((System.ComponentModel.ISupportInitialize)(this.quanLyThueSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakhach
            // 
            this.lblMakhach.AutoSize = true;
            this.lblMakhach.Location = new System.Drawing.Point(13, 79);
            this.lblMakhach.Name = "lblMakhach";
            this.lblMakhach.Size = new System.Drawing.Size(55, 13);
            this.lblMakhach.TabIndex = 0;
            this.lblMakhach.Text = "Mã khách";
            // 
            // lblTenkhach
            // 
            this.lblTenkhach.AutoSize = true;
            this.lblTenkhach.Location = new System.Drawing.Point(12, 132);
            this.lblTenkhach.Name = "lblTenkhach";
            this.lblTenkhach.Size = new System.Drawing.Size(59, 13);
            this.lblTenkhach.TabIndex = 1;
            this.lblTenkhach.Text = "Tên khách";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(13, 180);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 2;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(257, 128);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(257, 79);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(70, 13);
            this.lblSdt.TabIndex = 4;
            this.lblSdt.Text = "Số điện thoại";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(257, 180);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioitinh.TabIndex = 5;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(139, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(88, 79);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(100, 20);
            this.txtMakhach.TabIndex = 7;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(88, 129);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(100, 20);
            this.txtTenkhach.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(88, 177);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnThem.Location = new System.Drawing.Point(12, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSua.Location = new System.Drawing.Point(146, 394);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.BurlyWood;
            this.btnXoa.Location = new System.Drawing.Point(293, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnLuu.Location = new System.Drawing.Point(442, 394);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnTimkiem.Location = new System.Drawing.Point(582, 177);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 14;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDong.Location = new System.Drawing.Point(582, 394);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // quanLyThueSachDataSet
            // 
            //this.quanLyThueSachDataSet.DataSetName = "QuanLyThueSachDataSet";
            //this.quanLyThueSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachHangTableAdapter
            // 
          //  this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // mskSdt
            // 
            this.mskSdt.Location = new System.Drawing.Point(349, 72);
            this.mskSdt.Mask = "000 000 0000";
            this.mskSdt.Name = "mskSdt";
            this.mskSdt.Size = new System.Drawing.Size(126, 20);
            this.mskSdt.TabIndex = 17;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(349, 125);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtNgaysinh.TabIndex = 18;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.Location = new System.Drawing.Point(349, 172);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(121, 21);
            this.cboGioitinh.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // frmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(679, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboGioitinh);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.mskSdt);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTenkhach);
            this.Controls.Add(this.lblMakhach);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmQLKH";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.frmQLKH_Load);
           // ((System.ComponentModel.ISupportInitialize)(this.quanLyThueSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakhach;
        private System.Windows.Forms.Label lblTenkhach;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnDong;
        private QuanLyThueSachDataSet quanLyThueSachDataSet;
       // private QuanLyThueSachDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.MaskedTextBox mskSdt;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.ComboBox cboGioitinh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
