using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
            conn.Open();
            String sql = "SELECT Username , Password FROM NguoiDung WHERE Username='" + txtUser.Text + "' AND Password= '" + txtPass.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            frmMain f = new frmMain();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful!");
                f.Show();
                conn.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!");
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
