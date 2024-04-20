using System;
using System.Data;
using System.Windows.Forms;

namespace HeThongBaiGiuXe
{
    public partial class HeThongQuanLi : Form
    {
        public HeThongQuanLi()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan f = new ThongTinTaiKhoan();
            f.ShowDialog();
        }

        private void HeThongQuanLi_Load(object sender, EventArgs e)
        {

        }

        private void đơnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonGia f = new DonGia();
            f.ShowDialog();
            
        }

        private void thẻGiữXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheGuiXe f = new TheGuiXe();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThu f = new DoanhThu();
            f.ShowDialog();
        }

        private void lượtGửiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuotGuiXe f = new LuotGuiXe();
            f.ShowDialog();
        }

        private void lợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoiNhuan f = new LoiNhuan();
            f.ShowDialog();
        }
    }
}
