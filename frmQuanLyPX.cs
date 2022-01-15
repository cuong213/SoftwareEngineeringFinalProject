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
    public partial class frmQuanLyPX : Form
    {

        SqlConnection connection;
        SqlCommand command, command1;
        String str = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        void loaddataDSPX()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PhieuXuat";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvPX.DataSource = table;
        }

        void loaddataCTPX()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaSP, SoLuong from ChiTietPX where MaPX = '" + txtMaPX.Text + "'";
            adapter1.SelectCommand = command;
            table1.Clear();
            adapter1.Fill(table1);
            dgvCTPX.DataSource = table1;
        }

        public frmQuanLyPX()
        {
            InitializeComponent();
        }

        private void dgvPX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPX.CurrentRow.Index;
            txtMaPX.Text = dgvPX.Rows[i].Cells[0].Value.ToString();
            tbNgayXuat.Text = dgvPX.Rows[i].Cells[2].Value.ToString();
            tbNguoiXuat.Text = dgvPX.Rows[i].Cells[3].Value.ToString();
            connection = new SqlConnection(str);
            connection.Open();
            loaddataCTPX();
        }

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command1 = connection.CreateCommand();
            command.CommandText = "delete from PhieuXuat where MaPX= '" + txtMaPX.Text + "'";
            command1.CommandText = "delete from ChiTietPX where MaPX= '" + txtMaPX.Text + "'";
            command1.ExecuteNonQuery();
            command.ExecuteNonQuery();
            loaddataDSPX();
            loaddataCTPX();
            tbNgayXuat.Text = "";
            tbNguoiXuat.Text = "";
            txtMaPX.Text = "";
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PhieuXuat set NgayXuat = '" + tbNgayXuat.Text + "', MaKT ='" + tbNguoiXuat.Text + "' where MaPX ='" + txtMaPX.Text + "'";
            command.ExecuteNonQuery();
            loaddataDSPX();
        }

        private void btnTaoPX_Click(object sender, EventArgs e)
        {
            frmTaoPX f = new frmTaoPX();
            f.ShowDialog();
        }

        private void frmQuanLyPX_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddataDSPX();
        }
    }
}
