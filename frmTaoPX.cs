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
    public partial class frmTaoPX : Form
    {

        SqlConnection connection;
        SqlCommand command, command1;
        String str = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        private void btnTaoPX_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
            conn.Open();
            String sql = "SELECT MaDH FROM DonHang WHERE MaDH='" + tbMaDH.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                connection = new SqlConnection(str);
                connection.Open();
                command = connection.CreateCommand();
                command1 = connection.CreateCommand();
                command1.CommandText = "insert into PhieuXuat values ('" + tbMaPX.Text + "','" + tbMaDH.Text + "','" + dtNgayXuat.Text + "','" + tbMaKT.Text + "')";
                command.CommandText = "insert into ChiTietPX values ('" + tbMaPX.Text + "','" + tbMaSP.Text + "','" + tbSoLuong.Text + "')";
                command1.ExecuteNonQuery();
                command.ExecuteNonQuery();
                tbMaSP.Text = "";
                tbMaPX.Text = "";
                tbSoLuong.Text = "";
                tbMaKT.Text = "";
                tbMaDH.Text = "";
                MessageBox.Show("Tạo Thành Công!");
            }
            else
            {
                MessageBox.Show("Đơn Hàng Không Tồn Tại!");
            }
           
        }

        private void frmTaoPX_Load(object sender, EventArgs e)
        {

        }

        public frmTaoPX()
        {
            InitializeComponent();
        }

    }
}
