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
    public partial class DM_kksl : Form
    {
        public DM_kksl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKKSL sl = new FormKKSL();
            sl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCT_KKSL csl = new FormCT_KKSL();
            csl.ShowDialog();
        }
    }
}
