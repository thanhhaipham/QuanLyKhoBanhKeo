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
    public partial class PhieuXuat : Form
    {
        PHIEUXUATBLL bllpx;
        public PhieuXuat()
        {
            InitializeComponent();
            bllpx = new PHIEUXUATBLL();
        }

        public void ShowAllPHIEUXUAT()
        {
            DataTable dt = bllpx.getAllPHIEUXUAT();
            dataGridViewPX.DataSource = dt;
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            ShowAllPHIEUXUAT();
        }

        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtSPX.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phiếu xuất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSPX.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã kho.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTKH.Focus();
                return false;
            }

            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                PHIEU_XUAT px = new PHIEU_XUAT();
                px.SOPX = txtSPX.Text;
                px.MAKHO = txtMK.Text;
                px.TENKH = txtTKH.Text;

                if (bllpx.InsertPHIEUXUAT(px))
                    ShowAllPHIEUXUAT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                PHIEU_XUAT px = new PHIEU_XUAT();
                px.SOPX = txtSPX.Text;
                px.MAKHO = txtMK.Text;
                px.TENKH = txtTKH.Text;

                if (bllpx.UpdatePHIEUXUAT(px))
                    ShowAllPHIEUXUAT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PHIEU_XUAT px = new PHIEU_XUAT();
                px.SOPX = txtSPX.Text;
                if (bllpx.DeletePHIEUXUAT(px))
                    ShowAllPHIEUXUAT();
                else
                    MessageBox.Show("Đã xảy ra lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void dataGridViewPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSPX.Text = dataGridViewPX.Rows[index].Cells["SOPX"].Value.ToString();
                txtMK.Text = dataGridViewPX.Rows[index].Cells["MAKHO"].Value.ToString();
                txtTKH.Text = dataGridViewPX.Rows[index].Cells["TENKH"].Value.ToString();
                dtpNX.Text = dataGridViewPX.Rows[index].Cells["NGAYXUAT"].Value.ToString();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string value = txtTK.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllpx.FindPHIEUXUAT(value);
                dataGridViewPX.DataSource = dt;
            }
            else
                ShowAllPHIEUXUAT();
        }
    }
}
