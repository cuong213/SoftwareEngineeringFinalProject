using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyPN_Click(object sender, EventArgs e)
        {
            frmQuanLyPN f = new frmQuanLyPN();
            f.ShowDialog();
        }

        private void btnQuanLyPX_Click(object sender, EventArgs e)
        {
            frmQuanLyPX f = new frmQuanLyPX();
            f.ShowDialog();
        }
    }
}
