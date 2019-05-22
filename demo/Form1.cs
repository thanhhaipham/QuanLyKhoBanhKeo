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
    public partial class Form1 : Form
    {
        NHACUNGCAPBLL bllNCC;
        public Form1()
        {
            InitializeComponent();
            bllNCC = new NHACUNGCAPBLL();
        }
        public void ShowAllNCC()
        {
            DataTable dt = bllNCC.getAllNCC();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllNCC();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MANCC = txtMANCC.Text;
            ncc.TENNCC = txtTENNCC.Text;
            ncc.DIACHINCC = txtDIACHINCC.Text;
            ncc.SDTNCC = int.Parse(txtSDTNCC.Text);

            if (bllNCC.InsertNCC(ncc))
            {
                ShowAllNCC();
            }
            else
            {

                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMANCC.Text = dataGridView1.Rows[index].Cells["MANCC"].Value.ToString();
                txtTENNCC.Text = dataGridView1.Rows[index].Cells["TENNCC"].Value.ToString();
                txtDIACHINCC.Text = dataGridView1.Rows[index].Cells["DIACHINCC"].Value.ToString();
                txtSDTNCC.Text = dataGridView1.Rows[index].Cells["SDTNCC"].Value.ToString();
            }
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MANCC = txtMANCC.Text;
            ncc.TENNCC = txtTENNCC.Text;
            ncc.DIACHINCC = txtDIACHINCC.Text;
            ncc.SDTNCC = int.Parse(txtSDTNCC.Text);

            if (bllNCC.UpdateNCC(ncc))
            {
                ShowAllNCC();
            }
            else
            {

                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.MANCC = txtMANCC.Text;


                if (bllNCC.DeleteNCC(ncc))
                {
                    ShowAllNCC();
                }
                else
                {

                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllNCC.FindNCC(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllNCC();
        }
    }
}
