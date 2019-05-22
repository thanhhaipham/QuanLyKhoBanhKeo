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
    public partial class FrmHangHoa : Form
    {
        HANGHOABLL bllHH;
        public FrmHangHoa()
        {
            InitializeComponent();
            bllHH = new HANGHOABLL();
        }
        public void ShowAllHH()
        {
            DataTable dt = bllHH.getAllHH();
            dataGridView1.DataSource = dt;
        }

        private void FrmHangHoa_Load(object sender, EventArgs e)
        {
            ShowAllHH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HANGHOA hh = new HANGHOA();
            hh.MAHH = txtMAHH.Text;
            hh.TENHH = txtTENHH.Text;
            hh.DVT = txtDVT.Text;
            hh.DONGIA = int.Parse(txtDONGIA.Text);
            hh.MANCC = txtMANCC.Text;

            if (bllHH.InsertHangHoa(hh))
            {
                ShowAllHH();
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMAHH.Text = dataGridView1.Rows[index].Cells["MAHH"].Value.ToString();
                txtTENHH.Text = dataGridView1.Rows[index].Cells["TENHH"].Value.ToString();
                txtDVT.Text = dataGridView1.Rows[index].Cells["DVT"].Value.ToString();
                txtDONGIA.Text = dataGridView1.Rows[index].Cells["DONGIA"].Value.ToString();
                txtMANCC.Text = dataGridView1.Rows[index].Cells["MANCC"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HANGHOA hh = new HANGHOA();
            hh.MAHH = txtMAHH.Text;
            hh.TENHH = txtTENHH.Text;
            hh.DVT = txtDVT.Text;
            hh.DONGIA = int.Parse(txtDONGIA.Text);
            hh.MANCC = txtMANCC.Text;

            if (bllHH.UpdateHangHoa(hh))
            {
                ShowAllHH();
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa ?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes){
                HANGHOA hh = new HANGHOA();
                hh.MAHH = txtMAHH.Text;

                if (bllHH.DeleteHangHoa(hh))
                {
                    ShowAllHH();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimKiemHH_TextChanged(object sender, EventArgs e)
        {
            String value = txtTimKiemHH.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllHH.FindHangHoa(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllHH();
        }
    }
}
