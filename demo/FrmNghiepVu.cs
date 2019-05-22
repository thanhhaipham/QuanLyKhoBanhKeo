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
    public partial class FrmNghiepVu : Form
    {
        public FrmNghiepVu()
        {
            InitializeComponent();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.ShowDialog();
            this.Close();
        }
    }
}
