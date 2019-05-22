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
    public partial class FormKKCL : Form
    {
        PHIEUKKCLBLL bllPKKCL;
        public FormKKCL()
        {
            
            InitializeComponent();
            bllPKKCL = new PHIEUKKCLBLL();
        }
        public void ShowAllPKKCL()
        {
            DataTable dt = bllPKKCL.LayTatCaPKKCL();
            dataGridView1.DataSource = dt;
        }

        private void FormKKCL_Load(object sender, EventArgs e)
        {
            ShowAllPKKCL();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            PHIEUKKCL KKCL = new PHIEUKKCL();
            KKCL.SOPCL = txtSOPCL.Text;
            KKCL.NGAYKK = DateTime.Parse(txtNGAYKK.Text);
            KKCL.MAKHO = txtMAKHO.Text;
            KKCL.MANV = txtMANV.Text;

            if (bllPKKCL.InsertPKKCL(KKCL))
            {
                ShowAllPKKCL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSOPCL.Text = dataGridView1.Rows[index].Cells["SOPCL"].Value.ToString();
                txtNGAYKK.Text = dataGridView1.Rows[index].Cells["NGAYKK"].Value.ToString();
                txtMAKHO.Text = dataGridView1.Rows[index].Cells["MAKHO"].Value.ToString();
                txtMANV.Text = dataGridView1.Rows[index].Cells["MANV"].Value.ToString();

            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            PHIEUKKCL KKCL = new PHIEUKKCL();
            KKCL.SOPCL = txtSOPCL.Text;
            KKCL.NGAYKK = DateTime.Parse(txtNGAYKK.Text);
            KKCL.MAKHO = txtMAKHO.Text;
            KKCL.MANV = txtMANV.Text;

            if (bllPKKCL.UpdatePKKCL(KKCL))
            {
                ShowAllPKKCL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PHIEUKKCL KKCL = new PHIEUKKCL();
                KKCL.SOPCL = txtSOPCL.Text;
                if (bllPKKCL.DeletePKKCL(KKCL))
                {
                    ShowAllPKKCL();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTIMKIEM_KKCL_TextChanged(object sender, EventArgs e)
        {
            string value = txtTIMKIEM_KKCL.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllPKKCL.TimKiem_PKKCL(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllPKKCL();
        }
    }
}
