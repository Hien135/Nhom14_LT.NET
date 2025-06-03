namespace Nhom14_LT.NET.Forms
{
    partial class frmBaocaodoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDenngay = new System.Windows.Forms.Label();
            this.lblTungay = new System.Windows.Forms.Label();
            this.lblLoaithongke = new System.Windows.Forms.Label();
            this.dtTungay = new System.Windows.Forms.DateTimePicker();
            this.dtDenngay = new System.Windows.Forms.DateTimePicker();
            this.cboLoaithongke = new System.Windows.Forms.ComboBox();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnXuatexcel = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.chartDoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDoanhthu = new System.Windows.Forms.DataGridView();
//            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // lblDenngay
            // 
            this.lblDenngay.AutoSize = true;
            this.lblDenngay.Location = new System.Drawing.Point(31, 117);
            this.lblDenngay.Name = "lblDenngay";
            this.lblDenngay.Size = new System.Drawing.Size(56, 13);
            this.lblDenngay.TabIndex = 1;
            this.lblDenngay.Text = "Đến ngày:";
            // 
            // lblTungay
            // 
            this.lblTungay.AutoSize = true;
            this.lblTungay.Location = new System.Drawing.Point(38, 90);
            this.lblTungay.Name = "lblTungay";
            this.lblTungay.Size = new System.Drawing.Size(49, 13);
            this.lblTungay.TabIndex = 2;
            this.lblTungay.Text = "Từ ngày:";
            // 
            // lblLoaithongke
            // 
            this.lblLoaithongke.AutoSize = true;
            this.lblLoaithongke.Location = new System.Drawing.Point(12, 59);
            this.lblLoaithongke.Name = "lblLoaithongke";
            this.lblLoaithongke.Size = new System.Drawing.Size(75, 13);
            this.lblLoaithongke.TabIndex = 3;
            this.lblLoaithongke.Text = "Loại thống kê:";
            // 
            // dtTungay
            // 
            this.dtTungay.Location = new System.Drawing.Point(109, 86);
            this.dtTungay.Name = "dtTungay";
            this.dtTungay.Size = new System.Drawing.Size(200, 20);
            this.dtTungay.TabIndex = 4;
            // 
            // dtDenngay
            // 
            this.dtDenngay.Location = new System.Drawing.Point(109, 117);
            this.dtDenngay.Name = "dtDenngay";
            this.dtDenngay.Size = new System.Drawing.Size(200, 20);
            this.dtDenngay.TabIndex = 5;
            // 
            // cboLoaithongke
            // 
            this.cboLoaithongke.FormattingEnabled = true;
            this.cboLoaithongke.Location = new System.Drawing.Point(109, 59);
            this.cboLoaithongke.Name = "cboLoaithongke";
            this.cboLoaithongke.Size = new System.Drawing.Size(200, 21);
            this.cboLoaithongke.TabIndex = 6;
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(15, 151);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(75, 23);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnXuatexcel
            // 
            this.btnXuatexcel.Location = new System.Drawing.Point(122, 151);
            this.btnXuatexcel.Name = "btnXuatexcel";
            this.btnXuatexcel.Size = new System.Drawing.Size(75, 23);
            this.btnXuatexcel.TabIndex = 8;
            this.btnXuatexcel.Text = "Xuất excel";
            this.btnXuatexcel.UseVisualStyleBackColor = true;
//            this.btnXuatexcel.Click += new System.EventHandler(this.btnXuatexcel_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(234, 151);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // chartDoanhthu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhthu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhthu.Legends.Add(legend1);
            this.chartDoanhthu.Location = new System.Drawing.Point(355, 59);
            this.chartDoanhthu.Name = "chartDoanhthu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhthu.Series.Add(series1);
            this.chartDoanhthu.Size = new System.Drawing.Size(258, 115);
            this.chartDoanhthu.TabIndex = 10;
            this.chartDoanhthu.Text = "chart1";
            // 
            // dgvDoanhthu
            // 
            this.dgvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhthu.Location = new System.Drawing.Point(15, 194);
            this.dgvDoanhthu.Name = "dgvDoanhthu";
            this.dgvDoanhthu.Size = new System.Drawing.Size(294, 114);
            this.dgvDoanhthu.TabIndex = 11;
            // 
            // lblTongDoanhThu
            // 
          
            // frmBaocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(671, 376);
          //  this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.dgvDoanhthu);
            this.Controls.Add(this.chartDoanhthu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXuatexcel);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.cboLoaithongke);
            this.Controls.Add(this.dtDenngay);
            this.Controls.Add(this.dtTungay);
            this.Controls.Add(this.lblLoaithongke);
            this.Controls.Add(this.lblTungay);
            this.Controls.Add(this.lblDenngay);
            this.Controls.Add(this.label1);
            this.Name = "frmBaocaodoanhthu";
            this.Text = "frmBaocaodoanhthu";
            this.Load += new System.EventHandler(this.frmBaocaodoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDenngay;
        private System.Windows.Forms.Label lblTungay;
        private System.Windows.Forms.Label lblLoaithongke;
        private System.Windows.Forms.DateTimePicker dtTungay;
        private System.Windows.Forms.DateTimePicker dtDenngay;
        private System.Windows.Forms.ComboBox cboLoaithongke;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnXuatexcel;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhthu;
        private System.Windows.Forms.DataGridView dgvDoanhthu;
      //  private System.Windows.Forms.Label lblTongDoanhThu;
    }
}