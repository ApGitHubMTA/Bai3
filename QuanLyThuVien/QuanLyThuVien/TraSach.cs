﻿using System;
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
        BUS_BanDoc bd = new BUS_BanDoc();
        BUS_TaiLieu tl = new BUS_TaiLieu();
        BUS_PhieuMuon pm = new BUS_PhieuMuon();
        BUS_ChiTietPM ctpm = new BUS_ChiTietPM();
        List<BUS_TaiLieu> listTLMuon = new List<BUS_TaiLieu>();
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
            //cmd.Parameters.Add("@MaSach", _MaSach);
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

                dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
            }
            con.Close();
        }
        private void txtMaTL_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTra_Click(object sender, EventArgs e)
        {
            //pm.UpdateTrangThaiPM_TraSach(txtMaTL.Text);
            if (tl.UodateSoLuongTLID_TraSach(txtMaTL.Text) == true)
            {
                dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
                if (MessageBox.Show("Trả Sách Hoàn Tất. Bạn có muốn tiếp tục?", "Question", MessageBoxButtons.YesNo) == DialogResult.No)
                    this.Close();
            }
            else
                MessageBox.Show("Trả Sách Thất Bại.");

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
