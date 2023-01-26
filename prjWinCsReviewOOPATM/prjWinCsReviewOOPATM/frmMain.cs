using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsReviewOOPATM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure to quit the program ?";
            string title = "Application Closing";
            if(MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuATM_Click(object sender, EventArgs e)
        {
            frmATM fa = new frmATM();
            fa.MdiParent = this;
            fa.Show();
        }

        private void mnuFunctions_Click(object sender, EventArgs e)
        {
            frmFunctions ff = new frmFunctions();
            ff.MdiParent = this;
            ff.Show();
        }

        private void mnuDataReader_Click(object sender, EventArgs e)
        {
            frmDataReader fdr = new frmDataReader();
            fdr.MdiParent = this;
            fdr.Show();
        }

        private void mnuDataSet_Click(object sender, EventArgs e)
        {
            frmDataSet fds = new frmDataSet();
            fds.MdiParent = this;
            fds.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

    }
}
