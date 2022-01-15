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
    public partial class frmTaoPN : Form
    {
        SqlConnection connection;
        SqlCommand command, command1;
        String str = @"Data Source=DESKTOP-899RGU8\CUONGSQL;Initial Catalog=CNPM;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        public frmTaoPN()
        {
            InitializeComponent();
        }

        void loaddataCTPN()
        {
            command = connection.CreateCommand();
            command.CommandText = "select SanPham.MaSP, SanPham.TenSP, SanPham.MaLH, SanPham.DonVi, ChiTietPN.SLNhap, ChiTietPN.DGNhap FROM ChiTietPN INNER JOIN SanPham ON ChiTietPN.MaSP = SanPham.MaSP AND ChiTietPN.MaPN= '"+tbMaPN.Text+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCTPN.DataSource = table;
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            
            command = connection.CreateCommand();
            command.CommandText = "insert into PhieuNhap values ('" + tbMaPN.Text + "','" + dtNgayNhap.Text + "','" + tbMaKT.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Tạo Thành Công! Hãy thêm sản phẩm");
        }

        private void frmTaoPN_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

            if(tbMaPN.Text == "")
            {
                MessageBox.Show("Please Enter Mã Phiếu Nhập!");
            }
            else
            {
               
                command = connection.CreateCommand();
                command1 = connection.CreateCommand();
                command.CommandText = "insert into ChiTietPN values ('" +tbMaPN.Text+ "','" +tbMaSP.Text+"','"+tbSoLuong.Text+"','"+tbDonGia.Text+"')";
                command1.CommandText = "insert into SanPham values ('" +tbMaSP.Text+ "','" + tbTenSP.Text + "','" + tbMaLH.Text+"','"+tbDonVi.Text+ "')";
                command1.ExecuteNonQuery();
                command.ExecuteNonQuery();
                loaddataCTPN();
                tbMaSP.Text = "";
                tbTenSP.Text = "";
                tbSoLuong.Text = "";
                tbMaLH.Text = "";
                tbDonVi.Text = "";
                tbDonGia.Text = "";
            }
        }
    }
}
