using BangThuVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class MuonSach : Form
    {
        BUS_BanDoc bd = new BUS_BanDoc();
        BUS_TaiLieu tl = new BUS_TaiLieu();
        BUS_TaiKhoan tk = new BUS_TaiKhoan();
        BUS_PhieuMuon pm = new BUS_PhieuMuon();
        BUS_ChiTietPM ctpm = new BUS_ChiTietPM();
        List<BUS_TaiLieu> listTLMuon = new List<BUS_TaiLieu>();
        public MuonSach()
        {
            InitializeComponent();
        }
        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (txtMaBD.Text == null)
                MessageBox.Show("Chưa có mã bạn đọc!");
            else if (txtMaTL.Text == null)
                MessageBox.Show("Chưa có mã tài liệu!");
            else if (bd.TimKiemBDID(txtMaBD.Text).Rows.Count < 1)
                MessageBox.Show("Mã Bạn Đọc Không Tồn Tại!");
            else if (tl.TimKiemSachID(txtMaTL.Text).Rows.Count < 1)
                MessageBox.Show("Mã Tài Liệu Không Tồn Tại trong CSDL!");
            else
            {
                dgvSachDaMuon.DataSource = bd.ThongKeSachDaMuonTheoID(txtMaBD.Text);
                DataTable dt = tl.TimKiemSoLuongDauSachID(txtMaTL.Text);
                if (dt.Rows.Count > 0)
                {
                    if (int.Parse(dt.Rows[0]["SoLuong"].ToString()) < 1)
                        MessageBox.Show("Tài Liệu Này Hiện Đã Hết!");
                    else
                    {
                        tl = new BUS_TaiLieu();
                        DataTable bangtam = new DataTable();

                        bangtam = tl.TimKiemSachID(txtMaTL.Text);
                        tl.Matl = bangtam.Rows[0]["MaDauSach"].ToString();
                        tl.Nhande = bangtam.Rows[0]["NhanDe"].ToString();
                        tl.Tacgia = bangtam.Rows[0]["TacGia"].ToString();
                        tl.Soluong = int.Parse(bangtam.Rows[0]["SoLuong"].ToString());
                        tl.Domat = int.Parse(bangtam.Rows[0]["DoMat"].ToString());
                        tl.Ngonngu = bangtam.Rows[0]["NgonNgu"].ToString();
                        tl.MaTheLoai = bangtam.Rows[0]["MaTheLoai"].ToString();
                        tl.MaNXB = bangtam.Rows[0]["MaNXB"].ToString();

                        listTLMuon.Add(tl);
                        Show(dgvSachMuon);
                    }
                }
            }
        }
    }
}
