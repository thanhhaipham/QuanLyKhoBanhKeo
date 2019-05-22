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
    public partial class BaoCaoDoanhThu : Form
    {
        BAOCAODOANHTHUBLL bllbc;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            bllbc = new BAOCAODOANHTHUBLL();
        }

        public void ShowAllPBCDT()
        {
            DataTable dt = bllbc.getAllPBCDT();
            dataGridViewBCDT.DataSource = dt;
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            ShowAllPBCDT();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtSPBC.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phiếu báo cáo.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSPBC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã kho.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSPX.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phiếu xuất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSPX.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                BCDT bc = new BCDT();
                bc.SOPBC = txtSPBC.Text;
                bc.MAKHO = txtMK.Text;
                bc.SOPX = txtSPX.Text;

                if (bllbc.InsertPBCDT(bc))
                    ShowAllPBCDT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (CheckData())
            {
                BCDT bc = new BCDT();
                bc.SOPBC = txtSPBC.Text;
                bc.MAKHO = txtMK.Text;
                bc.SOPX = txtSPX.Text;
                bc.TUNGAY = DateTime.Parse(dtpTN.Text);
                bc.DENNGAY = DateTime.Parse(dtpDN.Text);

                if (bllbc.UpdatePBCDT(bc))
                    ShowAllPBCDT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BCDT bc = new BCDT();
                bc.SOPBC = txtSPBC.Text;
                if (bllbc.DeletePBCDT(bc))
                    ShowAllPBCDT();
                else
                    MessageBox.Show("Đã xảy ra lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridViewBCDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSPBC.Text = dataGridViewBCDT.Rows[index].Cells["SOPBC"].Value.ToString();
                txtMK.Text = dataGridViewBCDT.Rows[index].Cells["MAKHO"].Value.ToString();
                dtpTN.Text = dataGridViewBCDT.Rows[index].Cells["TUNGAY"].Value.ToString();
                dtpDN.Text = dataGridViewBCDT.Rows[index].Cells["DENNGAY"].Value.ToString();
                txtSPX.Text = dataGridViewBCDT.Rows[index].Cells["SOPX"].Value.ToString();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string value = txtTK.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllbc.FindPBCDT(value);
                dataGridViewBCDT.DataSource = dt;
            }
            else
                ShowAllPBCDT();
        }
    }
}
