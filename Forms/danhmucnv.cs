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
    public partial class danhmucnv : Form
    {
        public danhmucnv()
        {
            InitializeComponent();
        }

        private void danhmucnv_Load(object sender, EventArgs e)
        {
            txtmanv.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            load_datagrid();
        }
        DataTable tblnv;
        private void load_datagrid()
        {
            string sql;
            sql = "select * from nhanvien";
            Functions.FillCombo("select macongviec, tencongviec from congviec", cbocv, "macongviec", "tencongviec");
            cbocv.SelectedIndex = -1;
            tblnv = Class.Functions.GetDataToTable(sql);
            datanv.DataSource = tblnv;
            datanv.Columns[0].HeaderText = "Mã nhân viên";
            datanv.Columns[1].HeaderText = "Tên nhân viên";
            datanv.Columns[2].HeaderText = "Điện thoại";
            datanv.Columns[3].HeaderText = "Địa chỉ";
            datanv.Columns[4].HeaderText = "Công việc";
            datanv.AllowUserToAddRows = false;
            datanv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void datanv_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Focus();
                return;
            }
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma;
            txtmanv.Text = datanv.CurrentRow.Cells["manhanvien"].Value.ToString();
            txttennv.Text = datanv.CurrentRow.Cells["tennhanvien"].Value.ToString();            
            mskdt.Text = datanv.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtdc.Text = datanv.CurrentRow.Cells["diachi"].Value.ToString();
            ma = datanv.CurrentRow.Cells["macongviec"].Value.ToString();
            cbocv.Text = Functions.GetFieldValues("select tencongviec from congviec where macongviec =N'" + ma + "'");
            btnhuy.Enabled = true;
        }
        private void ResetValues()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            cbocv.Text = "";
            mskdt.Text = "";
            txtdc.Text = "";
            txtmanv.Enabled = false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            cbocv.Enabled = true;
            mskdt.Enabled = true;
            txtdc.Enabled = true;          
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (cbocv.Text == "")
            {
                MessageBox.Show("Bạn phải chọn công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbocv.Focus();
                return;
            }
            if (mskdt.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdt.Focus();
                return;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            sql = "insert into nhanvien(manhanvien,tennhanvien,dienthoai,diachi,macongviec)values(N'" + txtmanv.Text.Trim() + "',N'" + txttennv.Text.Trim() + "',N'" + mskdt.Text.Trim() + "',N'" + txtdc.Text.Trim() + "',N'" + cbocv.SelectedValue.ToString() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmanv.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete nhanvien where manhanvien=N'" + txtmanv.Text.Trim() + "'";
                Class.Functions.RunSqlDel(sql);
                load_datagrid();
                ResetValues();
                btnhuy.Enabled = false;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            ResetValues();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
                return;
            }
            if (cbocv.Text == "")
            {
                MessageBox.Show("Bạn phải nhập công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbocv.Focus();
                return;
            }
            if (mskdt.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdt.Focus();
                return;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            sql = "update nhanvien set tennhanvien = N'" + txttennv.Text.Trim() + "', dienthoai = N'" + mskdt.Text.Trim() + "', diachi = N'" + txtdc.Text.Trim() + "', macongviec = N'" + cbocv.SelectedValue.ToString() + "' where manhanvien = N'" + txtmanv.Text.Trim() + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnhuy.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
