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
    public partial class FrmHHTK : Form
    {
        HHTKBLL bllHHTK;
        public FrmHHTK()
        {
            InitializeComponent();
            bllHHTK = new HHTKBLL();
        }
        public void ShowAllHHTK()
        {
            DataTable dt = bllHHTK.getAllHHTK();
            dataGridView1.DataSource = dt;
        }

        private void FrmHHTK_Load(object sender, EventArgs e)
        {
            ShowAllHHTK();
        }
    }
}
