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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập Username", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập Password", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtPass.Focus();
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (txtUsername.Text == "Admin" && txtPass.Text == "1110")
                {
                    MessageBox.Show("Đăng nhập thành công. Welcome to our Shop !");
                    FrmNghiepVu nv = new FrmNghiepVu();
                    nv.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại !");
                    txtUsername.Text = "";
                    txtPass.Text = "";
                    txtUsername.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }
    }
}
