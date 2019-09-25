using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KetNoiDB;
using BangThuVien;

namespace QuanLyThuVien
{
    
    public partial class TraSach : Form
    {
        public TraSach()
        {
            InitializeComponent();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
        public void KhoiTaoTxt()
        {
            txtMaBD.Text = txtHoTen.Text = txtCMND.Text = txtDiaChi.Text = txtEmail.Text = txtGT.Text = txtMaLop.Text = txtNS.Text = txtSoDT.Text = "";
        }
        public void TTBanDoc(string _MaSach)
        {
            KhoiTaoTxt();
            DataTable dt = new DataTable();
            string str = string.Format("TTBanDoc");
            SqlConnection con = new SqlConnection(AppConfig.connectionString());
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", _MaSach);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtMaBD.Text = dt.Rows[0]["MaBD"].ToString();
                txtHoTen.Text = dt.Rows[0]["Hoten"].ToString();
                txtGT.Text = dt.Rows[0]["GioiTinh"].ToString();
                txtNS.Text = dt.Rows[0]["NgaySinh"].ToString();
                txtCMND.Text = dt.Rows[0]["CMND"].ToString();
                txtMaLop.Text = dt.Rows[0]["MaLop"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtSoDT.Text = dt.Rows[0]["DienThoai"].ToString();

                //dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
            }
            con.Close();
        }


    }
}
