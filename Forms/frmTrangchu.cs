using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom14_LT.NET; 

using quanlikhachhang;
namespace Nhom14_LT.NET
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }
    
     private void frmTrangchu_Load(object sender, EventArgs e)
 {

 }

 private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
 {
     frmQLKH f = new frmQLKH();
     f.ShowDialog();
 }
 }
}
