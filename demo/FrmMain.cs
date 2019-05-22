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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            FrmNghiepVu nv = new FrmNghiepVu();
            nv.ShowDialog();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            FrmHangHoa hh = new FrmHangHoa();
            hh.ShowDialog();
        }
    }
}
