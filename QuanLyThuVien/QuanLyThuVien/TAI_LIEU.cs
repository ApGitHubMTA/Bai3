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
    public partial class TAI_LIEU : Form
    {
        BUS_TaiLieu _tailieu = new BUS_TaiLieu();
        int chon = 0;
        TimKiem tk = new TimKiem();
        public TAI_LIEU()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtNhanDe.Text == "" || txtTG.Text == "" || txtSoLuong.Text == "" || cbMaTheLoai.Text == "" || cbMaNXB.Text == "" || txtDoMat.Text == "" || txtNgonNgu.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _tailieu.ThemTaiLieu(txtTG.Text, txtNhanDe.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDoMat.Text), txtNgonNgu.Text, cbMaTheLoai.Text, cbMaNXB.Text);
                    MessageBox.Show("Thêm thành công!");
                    SetNull();
                    TAI_LIEU_Load(sender, e);
                }
            }
            else if (chon == 2)
            {
                if (txtNhanDe.Text == "" || txtTG.Text == "" || txtSoLuong.Text == "" || cbMaTheLoai.Text == "" || cbMaNXB.Text == "" || txtDoMat.Text == "" || txtNgonNgu.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa nhân viên này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    _tailieu.SuaTaiLieu(txtMaTL.Text, txtTG.Text, txtNhanDe.Text, int.Parse(txtSoLuong.Text), int.Parse(txtDoMat.Text), txtNgonNgu.Text, cbMaTheLoai.Text, cbMaNXB.Text);
                    MessageBox.Show("Sửa thành công!");
                    SetNull();
                    TAI_LIEU_Load(sender, e);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TAI_LIEU_Load(object sender, EventArgs e)
        {

        }
        void SetNull()
        {
            txtDoMat.Text = cbMaNXB.Text = txtMaTL.Text = cbMaTheLoai.Text = txtNgonNgu.Text = txtNhanDe.Text = txtSoLuong.Text = txtTG.Text = "";
            txttk_MaTL.Text = txttk_NhanDe.Text = txttk_Tacgia.Text = "";
        }
    }
}
