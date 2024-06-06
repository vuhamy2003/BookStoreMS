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
    public partial class timkiemhdn : Form
    {
        public timkiemhdn()
        {
            InitializeComponent();
        }
        DataTable tbltkhd;
        private void timkiemhdn_Load(object sender, EventArgs e)
        {
            ResetValues();
            datatkhd.DataSource = null;
            Functions.FillCombo("select manhanvien,tennhanvien from nhanvien WHERE macongviec IN ('CV01', 'CV02')", cbonv, "manhanvien", "tennhanvien");
            cbonv.SelectedIndex = -1;
            Functions.FillCombo("select mancc,tenncc from ncc", cboncc, "mancc", "tenncc");
            cboncc.SelectedIndex = -1;
        }
        private void ResetValues()
        {
            txtshd.Text = "";
            txtthang.Text = "";
            txtnam.Text = "";
            txttong.Text = "";
            cbonv.Text = "";
            cboncc.Text = "";
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
            if ((txtshd.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") && (txttong.Text == "") && (cboncc.Text == "") && (cbonv.Text == ""))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select hdn.sohdn, hdn.tongtien, hdn.ngaynhap, hdn.manhanvien, ncc.tenncc from hdn join ncc on hdn.mancc = ncc.mancc where 1=1";
            if (txtshd.Text != "")
                sql = sql + " and hdn.sohdn like N'%" + txtshd.Text + "%'";
            if (txttong.Text != "")
                sql = sql + " and hdn.tongtien like N'%" + txttong.Text + "%'";
            if (txtthang.Text != "")
                sql = sql + " and month(hdn.ngaynhap) =" + txtthang.Text;
            if (txtnam.Text != "")
                sql = sql + " and year(hdn.ngaynhap) =" + txtnam.Text;
            if (cbonv.Text != "")
                sql = sql + " AND manhanvien like N'%" + cbonv.SelectedValue.ToString() + "%'";
            if (cboncc.Text != "")
                sql = sql + " AND ncc.tenncc like N'%" + cboncc.SelectedValue.ToString() + "%'";
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
            datatkhd.Columns[1].HeaderText = "Tổng tiền";
            datatkhd.Columns[2].HeaderText = "Ngày nhập";
            datatkhd.Columns[3].HeaderText = "Nhân viên";
            datatkhd.Columns[4].HeaderText = "NCC";
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
                mahd = datatkhd.CurrentRow.Cells["sohdn"].Value.ToString();
                hoadonnhap frm = new hoadonnhap();
                frm.txtsohdn.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
