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
    public partial class frmQuanLyPN : Form
    {
        SqlConnection connection;
        SqlCommand command, command1;
        String str = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        void loaddataDSPN()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PhieuNhap";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPN.DataSource = table;
        }

        void loaddataCTPN()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaSP, SLNhap, DGNhap  from ChiTietPN where MaPN = '"+txtMaPN.Text+"'";
            adapter1.SelectCommand = command;
            table1.Clear();
            adapter1.Fill(table1);
            dgvCTPN.DataSource = table1;
        }

        public frmQuanLyPN()
        {
            InitializeComponent();
        }

        private void dgvPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPN.CurrentRow.Index;
            txtMaPN.Text = dgvPN.Rows[i].Cells[0].Value.ToString();
            tbNgayNhap.Text = dgvPN.Rows[i].Cells[1].Value.ToString();
            tbNguoiNhap.Text = dgvPN.Rows[i].Cells[2].Value.ToString();
            connection = new SqlConnection(str);
            connection.Open();
            loaddataCTPN();

        }

        private void frmQuanLyPN_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddataDSPN();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command1 = connection.CreateCommand();
            command.CommandText = "delete from PhieuNhap where MaPN= '" + txtMaPN.Text + "'";
            command1.CommandText = "delete from ChiTietPN where MaPN= '" + txtMaPN.Text + "'";
            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();
            loaddataDSPN();
            loaddataCTPN();
            tbNgayNhap.Text = "";
            tbNguoiNhap.Text = "";
            txtMaPN.Text = "";
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            frmTaoPN f = new frmTaoPN();
            f.ShowDialog();
        }

        private void btnSuaPN_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PhieuNhap set NgayNhap = '" + tbNgayNhap.Text + "', MaKT ='" + tbNguoiNhap.Text + "' where MaPN ='" + txtMaPN.Text + "'";
            command.ExecuteNonQuery();
            loaddataDSPN();
        }
    }
}
