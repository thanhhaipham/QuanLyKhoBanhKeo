using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom;

namespace demo
{
    public partial class FrmMain : Form
    {
        public object BAOCAODOANHTHU { get; private set; }

        public FrmMain()
        {
            InitializeComponent();
        }


        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            FrmHangHoa hh = new FrmHangHoa();
            hh.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPhieuNhap pn = new FrmPhieuNhap();
            pn.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DM_kksl dm = new DM_kksl();
            dm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormKKCL cl = new FormKKCL();
            cl.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DanhMuc d = new DanhMuc();
            d.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu b = new BaoCaoDoanhThu();
            b.ShowDialog();
        }

        private void pbHangHoa_Click(object sender, EventArgs e)
        {
            FrmHangHoa hh = new FrmHangHoa();
            hh.ShowDialog();
        }

        private void pbKho_Click(object sender, EventArgs e)
        {
            FrmKho k = new FrmKho();
            k.ShowDialog();
        }

        private void pbNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien n = new FrmNhanVien();
            n.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien n = new FrmNhanVien();
            n.ShowDialog();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            FrmKho k = new FrmKho();
            k.ShowDialog();
        }

        private void pbNhaCungCap_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

    }
}
