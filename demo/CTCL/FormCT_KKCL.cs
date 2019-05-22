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
    public partial class FormCT_KKCL : Form
    {
        CT_KKCLBLL bllCT_KKCL;
        public FormCT_KKCL()
        {
            InitializeComponent();
            bllCT_KKCL = new CT_KKCLBLL();
        }
        public void ShowAllCT_KKCL()
        {
            DataTable dt = bllCT_KKCL.LayTatCaCT_KKCL();
            dataGridView1.DataSource = dt;
        }

        private void FormCT_KKCL_Load(object sender, EventArgs e)
        {
            ShowAllCT_KKCL();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            CT_KKCL CTKKCL = new CT_KKCL();
            CTKKCL.SOPCL = txtSOPCL.Text;
            CTKKCL.MAHH = txtMAHH.Text;
            CTKKCL.SOLUONGSPKT = int.Parse(txtSOLUONGSPKT.Text);
            CTKKCL.SOLUONGSPL = int.Parse(txtSOLUONGSPL.Text);
            CTKKCL.SOLUONGSPHH = int.Parse(txtSOLUONGSPHH.Text);
            CTKKCL.GHICHU = txtGHICHU.Text;


            if (bllCT_KKCL.InsertCT_KKCL(CTKKCL))
            {
                ShowAllCT_KKCL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtSOPCL.Text = dataGridView1.Rows[index].Cells["SOPCL"].Value.ToString();
                txtMAHH.Text = dataGridView1.Rows[index].Cells["MAHH"].Value.ToString();
                txtSOLUONGSPKT.Text = dataGridView1.Rows[index].Cells["SOLUONGSPKT"].Value.ToString();
                txtSOLUONGSPL.Text = dataGridView1.Rows[index].Cells["SOLUONGSPL"].Value.ToString();
                txtSOLUONGSPHH.Text = dataGridView1.Rows[index].Cells["SOLUONGSPHH"].Value.ToString();
                txtGHICHU.Text = dataGridView1.Rows[index].Cells["GHICHU"].Value.ToString();

            }
        }
     

        private void btnSUA_Click(object sender, EventArgs e)
        {
            CT_KKCL CTKKCL = new CT_KKCL();
            CTKKCL.SOPCL = txtSOPCL.Text;
            CTKKCL.MAHH = txtMAHH.Text;
            CTKKCL.SOLUONGSPKT = int.Parse(txtSOLUONGSPKT.Text);
            CTKKCL.SOLUONGSPL = int.Parse(txtSOLUONGSPL.Text);
            CTKKCL.SOLUONGSPHH = int.Parse(txtSOLUONGSPHH.Text);
            CTKKCL.GHICHU = txtGHICHU.Text;


            if (bllCT_KKCL.UpdateCT_KKCL(CTKKCL))
            {
                ShowAllCT_KKCL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CT_KKCL CTKKCL = new CT_KKCL();
                CTKKCL.SOPCL = txtSOPCL.Text;
                if (bllCT_KKCL.DeleteCT_KKCL(CTKKCL))
                {
                    ShowAllCT_KKCL();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTIMKIEM_CTKKCL_TextChanged(object sender, EventArgs e)
        {
            string value = txtTIMKIEM_CTKKCL.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllCT_KKCL.TimKiem_CTKKCL(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllCT_KKCL();
        }
    }
}
