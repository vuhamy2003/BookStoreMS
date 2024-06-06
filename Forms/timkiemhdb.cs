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
    public partial class timkiemhdb : Form
    {
        public timkiemhdb()
        {
            InitializeComponent();
        }
        DataTable tbltkhd;
        private void timkiemhdb_Load(object sender, EventArgs e)
        {
            ResetValues();
            datatkhd.DataSource = null;
            Functions.FillCombo("select manhanvien,tennhanvien from nhanvien WHERE macongviec IN ('CV01', 'CV04')", cbonv, "manhanvien", "tennhanvien");
            cbonv.SelectedIndex = -1;
            Functions.FillCombo("select makhach,tenkhach from khachhang", cbokh, "makhach", "tenkhach");
            cbokh.SelectedIndex = -1;
        }
        private void ResetValues()
        {
            txtshd.Text = "";
            txtthang.Text = "";
            txtnam.Text = "";
            txttong.Text = "";
            cbonv.Text = "";
            cbokh.Text = "";
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
            if ((txtshd.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") && (txttong.Text == "") && (cbokh.Text == "") && (cbonv.Text == ""))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from hdb where 1=1";
            if (txtshd.Text != "")
                sql = sql + " and sohdb like N'%" + txtshd.Text + "%'";
            if (txttong.Text != "")
                sql = sql + " and tongtien like N'%" + txttong.Text + "%'";
            if (txtthang.Text != "")
                sql = sql + " and month(ngayban) =" + txtthang.Text;
            if (txtnam.Text != "")
                sql = sql + " and year(ngayban) =" + txtnam.Text;
            if (cbonv.Text != "")
                sql = sql + " AND manhanvien like N'%" + cbonv.SelectedValue.ToString() + "%'";
            if (cbokh.Text != "")
                sql = sql + " AND makhach like N'%" + cbokh.SelectedValue.ToString() + "%'";
            tbltkhd = Functions.GetDataToTable(sql);
            if (tbltkhd.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltkhd.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            datatkhd.DataSource = tbltkhd;
            load_datagrid();
        }
        private void load_datagrid()
        {
            datatkhd.Columns[0].HeaderText = "Số hóa đơn";
            datatkhd.Columns[1].HeaderText = "Nhân viên";
            datatkhd.Columns[2].HeaderText = "Ngày bán";
            datatkhd.Columns[3].HeaderText = "Khách hàng";
            datatkhd.Columns[4].HeaderText = "Tổng tiền";
            datatkhd.AllowUserToAddRows = false;
            datatkhd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            datatkhd.DataSource = null;
        }

        private void datatkhd_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = datatkhd.CurrentRow.Cells["sohdb"].Value.ToString();
                hoadonban frm = new hoadonban();
                frm.txtsohdb.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
