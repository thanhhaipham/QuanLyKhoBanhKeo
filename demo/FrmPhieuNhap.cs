using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class FrmPhieuNhap : Form
    {
        PHIEUNHAPBLL bllPN;
        CHITIET_PHIEUNHAPBLL bllCTPN;
        public FrmPhieuNhap()
        {
            InitializeComponent();
            bllPN = new PHIEUNHAPBLL();
        }
        public void ShowAllPN()
        {
            DataTable dt = bllPN.getAllPN();
            dataGridView1.DataSource = dt;
        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            ShowAllPN();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.SOPN = txtSOPN.Text;
            pn.NGAYNHAP = DateTime.Parse(dtpNGAYNHAP.Value.ToString());
            pn.MANV = txtMANV.Text;
            pn.MANCC = txtMANCC.Text;
            pn.MAKHO = txtMAKHO.Text;

            if (bllPN.InsertPN(pn))
            {
                ShowAllPN();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSOPN.Text = dataGridView1.Rows[index].Cells["SOPN"].Value.ToString();
                dtpNGAYNHAP.Text = dataGridView1.Rows[index].Cells["NGAYNHAP"].Value.ToString();
                txtMAKHO.Text = dataGridView1.Rows[index].Cells["MAKHO"].Value.ToString();
                txtMANCC.Text = dataGridView1.Rows[index].Cells["MANCC"].Value.ToString();
                txtMANV.Text = dataGridView1.Rows[index].Cells["MANV"].Value.ToString();
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            PHIEUNHAP pn = new PHIEUNHAP();
            pn.SOPN = txtSOPN.Text;
            pn.NGAYNHAP = DateTime.Parse(dtpNGAYNHAP.Value.ToString());
            pn.MANV = txtMANV.Text;
            pn.MANCC = txtMANCC.Text;
            pn.MAKHO = txtMAKHO.Text;

            if (bllPN.UpdatePN(pn))
            {
                ShowAllPN();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                PHIEUNHAP pn = new PHIEUNHAP();
                pn.SOPN = txtSOPN.Text;

                if (bllPN.DeletePN(pn))
                {
                    ShowAllPN();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllPN.FindPN(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllPN();
        }

        private void btnXemCTPN_Click(object sender, EventArgs e)
        {
            string sopn = txtSOPN.Text;
            if (!string.IsNullOrEmpty(sopn))
            {
                DataTable dt = bllCTPN.getAllCTPN1(sopn);
                dataGridView1.DataSource = dt;
            }
            else
                bllCTPN.getAllCTPN();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();

            main.ShowDialog();
            this.Close();
        }
    }
}
