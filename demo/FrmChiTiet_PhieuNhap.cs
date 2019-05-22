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
    public partial class FrmChiTiet_PhieuNhap : Form
    {
        CHITIET_PHIEUNHAPBLL bllCTPN;
        public FrmChiTiet_PhieuNhap()
        {
            InitializeComponent();
            bllCTPN = new CHITIET_PHIEUNHAPBLL();
        }
        public void ShowAllCTPN()
        {
            DataTable dt = bllCTPN.getAllCTPN();
            dataGridView1.DataSource = dt;
        }

        private void FrmChiTiet_PhieuNhap_Load(object sender, EventArgs e)
        {
            ShowAllCTPN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHITIET_PHIEUNHAP c = new CHITIET_PHIEUNHAP();
            c.SOPN = txtSOPN.Text;
            c.MAHH = txtMAHH.Text;
            c.SLGIAO = int.Parse(txtSLGIAO.Text);
            c.SLNHAN = int.Parse(txtSLNHAN.Text);
            c.DONGIA = int.Parse(txtDONGIA.Text);
            c.SOHIEUDH = txtSOHIEUDH.Text;

            if (bllCTPN.InsertCTPN(c))
            {
                ShowAllCTPN();
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
                txtMAHH.Text = dataGridView1.Rows[index].Cells["MAHH"].Value.ToString();
                txtSLGIAO.Text = dataGridView1.Rows[index].Cells["SLGIAO"].Value.ToString();
                txtSLNHAN.Text = dataGridView1.Rows[index].Cells["SLNHAN"].Value.ToString();
                txtDONGIA.Text = dataGridView1.Rows[index].Cells["DONGIA"].Value.ToString();
                txtSOHIEUDH.Text = dataGridView1.Rows[index].Cells["SOHIEUDH"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHITIET_PHIEUNHAP c = new CHITIET_PHIEUNHAP();
            c.SOPN = txtSOPN.Text;
            c.MAHH = txtMAHH.Text;
            c.SLGIAO = int.Parse(txtSLGIAO.Text);
            c.SLNHAN = int.Parse(txtSLNHAN.Text);
            c.DONGIA = int.Parse(txtDONGIA.Text);
            c.SOHIEUDH = txtSOHIEUDH.Text;

            if (bllCTPN.UpdateCTPN(c))
            {
                ShowAllCTPN();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CHITIET_PHIEUNHAP c = new CHITIET_PHIEUNHAP();
                c.SOPN = txtSOPN.Text;
                c.MAHH = txtMAHH.Text;

                if (bllCTPN.DeleteCTPN(c))
                {
                    ShowAllCTPN();
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
                DataTable dt = bllCTPN.FindCTPN(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllCTPN();
        }
    }
}
