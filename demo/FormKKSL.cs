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
    public partial class FormKKSL : Form
    {
        PHIEUKKSLBLL bllPKKSL;
        public FormKKSL()
        {
            InitializeComponent();
            bllPKKSL = new PHIEUKKSLBLL();
        }
        public void ShowAllPKKSL()
        {
            DataTable dt = bllPKKSL.LayTatCaPKKSL();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllPKKSL();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            PHIEUKKSL KKSL = new PHIEUKKSL();
            KKSL.SOPSL = txtSOPSL.Text;
            KKSL.NGAYKK = DateTime.Parse(txtNGAYKK.Text);
            KKSL.MAKHO = txtMAKHO.Text;
            KKSL.MANV = txtMANV.Text;

            if (bllPKKSL.InsertPKKSL(KKSL))
            {
                ShowAllPKKSL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSOPSL.Text = dataGridView1.Rows[index].Cells["SOPSL"].Value.ToString();
                txtNGAYKK.Text = dataGridView1.Rows[index].Cells["NGAYKK"].Value.ToString();
                txtMAKHO.Text = dataGridView1.Rows[index].Cells["MAKHO"].Value.ToString();
                txtMANV.Text = dataGridView1.Rows[index].Cells["MANV"].Value.ToString();

            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            PHIEUKKSL KKSL = new PHIEUKKSL();
            KKSL.SOPSL = txtSOPSL.Text;
            KKSL.NGAYKK = DateTime.Parse(txtNGAYKK.Text);
            KKSL.MAKHO = txtMAKHO.Text;
            KKSL.MANV = txtMANV.Text;

            if (bllPKKSL.UpdatePKKSL(KKSL))
            {
                ShowAllPKKSL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                PHIEUKKSL KKSL = new PHIEUKKSL();
                KKSL.SOPSL = txtSOPSL.Text;
                if (bllPKKSL.DeletePKKSL(KKSL))
                {
                    ShowAllPKKSL();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTIMKIEM_KKSL_TextChanged(object sender, EventArgs e)
        {
            string value = txtTIMKIEM_KKSL.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllPKKSL.TimKiem_PKKSL(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllPKKSL();
        }
    }
}
