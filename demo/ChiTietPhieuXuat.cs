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
    public partial class ChiTietPhieuXuat : Form
    {
        CHITIET_PHIEUXUATBLL bllct;
        public ChiTietPhieuXuat()
        {
            InitializeComponent();
            bllct = new CHITIET_PHIEUXUATBLL();
        }
        public void ShowAllCHITIET_PHIEUXUAT()
        {
            DataTable dt = bllct.getAllCHITIET_PHIEUXUAT();
            dataGridViewCHITIET.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllCHITIET_PHIEUXUAT();
        }

        public bool CheckData()
        {
            if(string.IsNullOrEmpty(txtSPX.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phiếu xuất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSPX.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMHH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMHH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSLX.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng xuất.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLX.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                CHITIET_PHIEUXUAT ct = new CHITIET_PHIEUXUAT();
                ct.SOPX = txtSPX.Text;
                ct.MAHH = txtMHH.Text;
                ct.SLXUAT = txtSLX.Text;

                if (bllct.InsertCHITIET_PHIEUXUAT(ct))
                    ShowAllCHITIET_PHIEUXUAT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dataGridViewCHITIET_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >=0)
            {
                txtSPX.Text = dataGridViewCHITIET.Rows[index].Cells["SOPX"].Value.ToString();
                txtMHH.Text = dataGridViewCHITIET.Rows[index].Cells["MAHH"].Value.ToString();
                txtSLX.Text = dataGridViewCHITIET.Rows[index].Cells["SLXUAT"].Value.ToString();
                
            }
               
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                CHITIET_PHIEUXUAT ct = new CHITIET_PHIEUXUAT();
                ct.SOPX = txtSPX.Text;
                ct.MAHH = txtMHH.Text;
                ct.SLXUAT = txtSLX.Text;

                if (bllct.UpdateCHITIET_PHIEUXUAT(ct))
                    ShowAllCHITIET_PHIEUXUAT();
                else
                    MessageBox.Show("Đã có lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CHITIET_PHIEUXUAT ct = new CHITIET_PHIEUXUAT();
                ct.SOPX = txtSPX.Text;
                if (bllct.DeleteCHITIET_PHIEUXUAT(ct))
                    ShowAllCHITIET_PHIEUXUAT();
                else
                    MessageBox.Show("Đã xảy ra lỗi xin thử lại sau", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string value = txtTK.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllct.FindCHITIET_PHIEUXUAT(value);
                dataGridViewCHITIET.DataSource = dt;
            }
            else
                ShowAllCHITIET_PHIEUXUAT();
        }
    }
}   

