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
    public partial class FrmNhanVien : Form
    {
        NHANVIENBLL bllNV;
        public FrmNhanVien()
        {
            InitializeComponent();
            bllNV = new NHANVIENBLL();
        }
        public void ShowAllNV()
        {
            DataTable dt = bllNV.getAllNV();
            dataGridView1.DataSource = dt;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ShowAllNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = txtMANV.Text;
            nv.TENNV = txtTENNV.Text;
            nv.NS = DateTime.Parse(dateTimePicker1.Value.ToString());
            nv.SDTNV = int.Parse(txtSDTNV.Text);
            nv.GT = txtGT.Text;
            nv.LUONG = int.Parse(txtLUONG.Text);
            nv.MAKHO = txtMAKHO.Text;

            if (bllNV.InsertNhanVien(nv))
            {
                ShowAllNV();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMANV.Text = dataGridView1.Rows[index].Cells["MANV"].Value.ToString();
                txtTENNV.Text = dataGridView1.Rows[index].Cells["TENNV"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[index].Cells["NS"].Value.ToString();
                txtGT.Text = dataGridView1.Rows[index].Cells["GT"].Value.ToString();
                txtSDTNV.Text = dataGridView1.Rows[index].Cells["SDTNV"].Value.ToString();
                txtLUONG.Text = dataGridView1.Rows[index].Cells["LUONG"].Value.ToString();
                txtMAKHO.Text = dataGridView1.Rows[index].Cells["MAKHO"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = txtMANV.Text;
            nv.TENNV = txtTENNV.Text;
            nv.NS = DateTime.Parse(dateTimePicker1.Value.ToString());
            nv.SDTNV = int.Parse(txtSDTNV.Text);
            nv.GT = txtGT.Text;
            nv.LUONG = int.Parse(txtLUONG.Text);
            nv.MAKHO = txtMAKHO.Text;

            if (bllNV.UpdateNhanVien(nv))
            {
                ShowAllNV();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = txtMANV.Text;
                if (bllNV.DeleteNhanVien(nv))
                {
                    ShowAllNV();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                ShowAllNV();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllNV.FindNhanVien(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllNV();
        }
    }
}
