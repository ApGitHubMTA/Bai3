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
    public partial class QLThuVien : Form
    {
        public QLThuVien()
        {
            InitializeComponent();
        }

        private void tàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TAI_LIEU frm = new TAI_LIEU();
            frm.Show();

        }

        private void bạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia frm = new DocGia();
            frm.Show();
        }

        private void mượnTàiLiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuonSach frm = new MuonSach();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Question", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan frm = new HuongDan();
            frm.Show();
        }

        private void trảTàiLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraSach frm = new frmTraSach();
            frm.Show();
        }
    }
}
