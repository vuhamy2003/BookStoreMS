using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                Class.Functions.Disconnect();
                Application.Exit();
            }
        }

        private void mnudms_Click(object sender, EventArgs e)
        {
            Forms.danhmucsach a = new Forms.danhmucsach();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudmkh_Click(object sender, EventArgs e)
        {
            Forms.danhmuckh a = new Forms.danhmuckh();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudmncc_Click(object sender, EventArgs e)
        {
            Forms.danhmucncc a = new Forms.danhmucncc();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudmnv_Click(object sender, EventArgs e)
        {
            Forms.danhmucnv a = new Forms.danhmucnv();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }

        private void mnutks_Click(object sender, EventArgs e)
        {
            Forms.timkiemsach a = new Forms.timkiemsach();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnutknv_Click(object sender, EventArgs e)
        {
            Forms.timkiemnv a = new Forms.timkiemnv();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudmhdn_Click(object sender, EventArgs e)
        {
            Forms.hoadonnhap a = new Forms.hoadonnhap();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudmhdb_Click(object sender, EventArgs e)
        {
            Forms.hoadonban a = new Forms.hoadonban();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnutkhdn_Click(object sender, EventArgs e)
        {
            Forms.timkiemhdn a = new Forms.timkiemhdn();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnutkhdb_Click(object sender, EventArgs e)
        {
            Forms.timkiemhdb a = new Forms.timkiemhdb();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnudts_Click(object sender, EventArgs e)
        {
            Forms.baocaodoanhthu a = new Forms.baocaodoanhthu();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnuchay_Click(object sender, EventArgs e)
        {
            Forms.baocaosachbanchay a = new Forms.baocaosachbanchay();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void mnuton_Click(object sender, EventArgs e)
        {
            Forms.baocaotonkhonhieu a = new Forms.baocaotonkhonhieu();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void danhSách5KháchHàngMuaNhiềuNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.baocaokhachhang a = new Forms.baocaokhachhang();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
