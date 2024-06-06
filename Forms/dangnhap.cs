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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL.Forms
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();

            // Thiết lập vị trí ban đầu của form là trung tâm của màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {               
                Application.Exit();
            }
        }
        private void btndn_Click(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            string tk = "BTL";
            string mk = "123";
            if(tk.Equals(txttk.Text) && mk.Equals(txtmk.Text))
            {
                this.Hide();
                main a = new main();
                a.StartPosition = FormStartPosition.CenterScreen;
                a.Show();
            }  
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu đã sai, vui lòng nhập lại", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttk.Text = "";
                txtmk.Text = "";
                txttk.Focus();
            }
        }
    }
}

