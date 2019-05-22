using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom
{
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void btnPX_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.ShowDialog();
        }

        private void btnCTPX_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat ct = new ChiTietPhieuXuat();
            ct.ShowDialog();
        }

       
    }
}
