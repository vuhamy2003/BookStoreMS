using BTL.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Forms
{
    public partial class timkiemnv : Form
    {
        public timkiemnv()
        {
            InitializeComponent();
        }
        DataTable tbltknv;
        private void timkiemnv_Load(object sender, EventArgs e)
        {
            ResetValues();
            datanv.DataSource = null;
            Functions.FillCombo("select macongviec,tencongviec from congviec", cbomacv, "macongviec", "tencongviec");
            cbomacv.SelectedIndex = -1;           
        }
        private void ResetValues()
        {
            txttennv.Text = "";
            cbomacv.Text = "";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txttennv.Text == "") && (cbomacv.Text == ""))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from nhanvien where 1=1";
            if (txttennv.Text != "")
                sql = sql + " and tennhanvien like N'%" + txttennv.Text + "%'";
            if (cbomacv.Text != "")
                sql = sql + " AND macongviec like N'%" + cbomacv.SelectedValue.ToString() + "%'";
            tbltknv = Functions.GetDataToTable(sql);
            if (tbltknv.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltknv.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            datanv.DataSource = tbltknv;
            load_datagrid();
        }
        private void load_datagrid()
        {
            datanv.Columns[0].HeaderText = "Mã nhân viên";
            datanv.Columns[1].HeaderText = "Tên nhân viên";
            datanv.Columns[2].HeaderText = "Điện thoại";
            datanv.Columns[3].HeaderText = "Địa chỉ";
            datanv.Columns[4].HeaderText = "Công việc";
            datanv.AllowUserToAddRows = false;
            datanv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            datanv.DataSource = null;
        }
    }
}
