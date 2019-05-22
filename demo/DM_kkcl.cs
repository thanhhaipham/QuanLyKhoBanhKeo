using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom;

namespace demo
{
    public partial class DM_kkcl : Form
    {
        public DM_kkcl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKKCL cl = new FormKKCL();
            cl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCT_KKCL ccl = new FormCT_KKCL();
            ccl.ShowDialog();
        }
    }
}
