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
    public partial class timkiemsach : Form
    {
        public timkiemsach()
        {
            InitializeComponent();
        }
        DataTable tbltks;
        private void timkiemsach_Load(object sender, EventArgs e)
        {
            ResetValues();
            datasach.DataSource = null;
            Functions.FillCombo("select maloaisach,tenloaisach from loaisach", cbols, "maloaisach", "tenloaisach");
            cbols.SelectedIndex = -1;
            Functions.FillCombo("select manxb,tennxb from nxb", cbonxb, "manxb", "tennxb");
            cbonxb.SelectedIndex = -1;
        }
        private void ResetValues()
        {
            txttens.Text = "";
            cbols.Text = "";
            cbonxb.Text = "";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txttens.Text == "") && (cbonxb.Text == "") && (cbols.Text == ""))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select masach, tensach, soluong, gianhap, giaban, maloaisach, manxb from sach where 1=1";
            if (txttens.Text != "")
                sql = sql + " and tensach Like N'%" + txttens.Text + "%'";
            if (cbonxb.Text != "")
                sql = sql + " AND manxb Like N'%" + cbonxb.SelectedValue.ToString() + "%'";
            if (cbols.Text != "")
                sql = sql + " AND maloaisach Like N'%" + cbols.SelectedValue.ToString() + "%'";
            tbltks = Functions.GetDataToTable(sql);
            if (tbltks.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltks.Rows.Count + " bản ghi thỏa mãn điều kiện!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            datasach.DataSource = tbltks;
            load_datagrid();
        }
        private void load_datagrid()
        {
            datasach.Columns[0].HeaderText = "Mã sách";
            datasach.Columns[1].HeaderText = "Tên sách";
            datasach.Columns[2].HeaderText = "Số lượng";
            datasach.Columns[3].HeaderText = "Đơn giá nhập";
            datasach.Columns[4].HeaderText = "Đơn giá bán";
            datasach.Columns[5].HeaderText = "Loại sách";
            datasach.Columns[6].HeaderText = "NXB";
            datasach.AllowUserToAddRows = false;
            datasach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            datasach.DataSource = null;
        }
    }
}
