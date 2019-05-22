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
    public partial class FormCT_KKSL : Form
    {
        CT_KKSLBLL bllCT_KKSL;
        public FormCT_KKSL()
        {
            InitializeComponent();
            bllCT_KKSL = new CT_KKSLBLL();
        }
        public void ShowAllCT_KKSL()
        {
            DataTable dt = bllCT_KKSL.LayTatCaCT_KKSL();
            dataGridView1.DataSource = dt;
        }

        private void FormCT_KKSL_Load(object sender, EventArgs e)
        {
            ShowAllCT_KKSL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CT_KKSL CTKKSL = new CT_KKSL();
            CTKKSL.SOPSL = txtSOPSL.Text;
            CTKKSL.MAHH = txtMAHH.Text;
            CTKKSL.PHUONGTHUCKK = txtPHUONGTHUCKK.Text;
            CTKKSL.SOLUONGCT = int.Parse(txtSOLUONGCT.Text);
            CTKKSL.SOLUONGTT = int.Parse(txtSOLUONGTT.Text);
            CTKKSL.GHICHU = txtGHICHU.Text;


            if (bllCT_KKSL.InsertCT_KKSL(CTKKSL))
            {
                ShowAllCT_KKSL();
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
                txtMAHH.Text = dataGridView1.Rows[index].Cells["MAHH"].Value.ToString();
                txtPHUONGTHUCKK.Text = dataGridView1.Rows[index].Cells["PHUONGTHUCKK"].Value.ToString();
                txtSOLUONGCT.Text = dataGridView1.Rows[index].Cells["SOLUONGCT"].Value.ToString();
                txtSOLUONGTT.Text = dataGridView1.Rows[index].Cells["SOLUONGTT"].Value.ToString();
                txtGHICHU.Text = dataGridView1.Rows[index].Cells["GHICHU"].Value.ToString();

            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            CT_KKSL CTKKSL = new CT_KKSL();
            CTKKSL.SOPSL = txtSOPSL.Text;
            CTKKSL.MAHH = txtMAHH.Text;
            CTKKSL.PHUONGTHUCKK = txtPHUONGTHUCKK.Text;
            CTKKSL.SOLUONGCT = int.Parse(txtSOLUONGCT.Text);
            CTKKSL.SOLUONGTT = int.Parse(txtSOLUONGTT.Text);
            CTKKSL.GHICHU = txtGHICHU.Text;


            if (bllCT_KKSL.UpdateCT_KKSL(CTKKSL))
            {
                ShowAllCT_KKSL();
            }
            else
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CT_KKSL CTKKSL = new CT_KKSL();
                CTKKSL.SOPSL = txtSOPSL.Text;
                if (bllCT_KKSL.DeleteCT_KKSL(CTKKSL))
                {
                    ShowAllCT_KKSL();
                }
                else
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTIMKIEM_CTKKSL_TextChanged(object sender, EventArgs e)
        {
            string value = txtTIMKIEM_CTKKSL.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllCT_KKSL.TimKiem_CTKKSL(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllCT_KKSL();
        }
    }
}
