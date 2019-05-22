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
    public partial class FrmKho : Form
    {
        KHOBLL bllK;
        HHTKBLL bllHHTK;
        public FrmKho()
        {
            InitializeComponent();
            bllK = new KHOBLL();
            bllHHTK = new HHTKBLL();
        }
        public void ShowAllKho()
        {
            DataTable dt = bllK.getAllKho();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllK6ByKho()
        {
            DataTable dt = bllK.getAllK6();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllK7ByKho()
        {
            DataTable dt = bllK.getAllK7();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllK8byKho()
        {
            DataTable dt = bllK.getAllK8();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllK9ByKho()
        {
            DataTable dt = bllK.getAllK9();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllK10ByKho()
        {
            DataTable dt = bllK.getAllK10();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllHHTK()
        { 
            DataTable dt = bllHHTK.getAllHHTK();
            dataGridViewHHTK.DataSource = dt;
        }
        public void ShowAllK6()
        {
            DataTable dt = bllHHTK.getK6();
            dataGridViewHHTK.DataSource = dt;
        }
        public void ShowAllK7()
        {
            DataTable dt = bllHHTK.getK7();
            dataGridViewHHTK.DataSource = dt;
        }
        public void ShowAllK8()
        {
            DataTable dt = bllHHTK.getK8();
            dataGridViewHHTK.DataSource = dt;
        }
        public void ShowAllK9()
        {
            DataTable dt = bllHHTK.getK9();
            dataGridViewHHTK.DataSource = dt;
        }
        public void ShowAllK10()
        {
            DataTable dt = bllHHTK.getK10();
            dataGridViewHHTK.DataSource = dt;
        }
        private void FrmKho_Load(object sender, EventArgs e)
        {
            ShowAllKho();
            ShowAllHHTK();
        }
        private void btnK6_Click(object sender, EventArgs e)
        {
            ShowAllK6();
            ShowAllK6ByKho();
        }
        private void btnK7_Click(object sender, EventArgs e)
        {
            ShowAllK7();
            ShowAllK7ByKho();
        }
        private void btnK8_Click(object sender, EventArgs e)
        {
            ShowAllK8();
            ShowAllK8byKho();
        }
        private void btnK9_Click(object sender, EventArgs e)
        {
            ShowAllK9();
            ShowAllK9ByKho();
        }
        private void btnK10_Click(object sender, EventArgs e)
        {
            ShowAllK10();
            ShowAllK10ByKho();
        }

        private void btnKhoTong_Click(object sender, EventArgs e)
        {
            ShowAllHHTK();
            ShowAllKho();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHO k = new KHO();
            k.MAKHO = txtMAKHO.Text;
            k.TENKHO = txtTENKHO.Text;
            k.DIACHIKHO = txtDIACHIKHO.Text;
            k.MATK = txtMATK.Text;

            if (bllK.InsertKho(k))
            {
                ShowAllKho();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KHO k = new KHO();
            k.MAKHO = txtMAKHO.Text;
            k.TENKHO = txtTENKHO.Text;
            k.DIACHIKHO = txtDIACHIKHO.Text;
            k.MATK = txtMATK.Text;

            if (bllK.UpdateKho(k))
            {
                ShowAllKho();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMAKHO.Text = dataGridView1.Rows[index].Cells["MAKHO"].Value.ToString();
                txtTENKHO.Text = dataGridView1.Rows[index].Cells["TENKHO"].Value.ToString();
                txtDIACHIKHO.Text = dataGridView1.Rows[index].Cells["DIACHIKHO"].Value.ToString();
                txtMATK.Text = dataGridView1.Rows[index].Cells["MATK"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                KHO k = new KHO();
                k.MAKHO = txtMAKHO.Text;

                if (bllK.DeleteKho(k))
                {
                    ShowAllKho();
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
                DataTable dt = bllK.FindKho(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllKho();
        }
    }
}
