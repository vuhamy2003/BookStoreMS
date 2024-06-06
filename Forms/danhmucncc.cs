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
    public partial class danhmucncc : Form
    {
        public danhmucncc()
        {
            InitializeComponent();
        }

        private void danhmucncc_Load(object sender, EventArgs e)
        {
            txtmancc.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            load_datagrid();
        }
        DataTable tblncc;
        private void load_datagrid()
        {
            string sql;
            sql = "select * from ncc";
            tblncc = Class.Functions.GetDataToTable(sql);
            datancc.DataSource = tblncc;
            datancc.Columns[0].HeaderText = "Mã NCC";
            datancc.Columns[1].HeaderText = "Tên NCC";
            datancc.Columns[2].HeaderText = "Điện thoại";
            datancc.Columns[3].HeaderText = "Địa chỉ";
            datancc.AllowUserToAddRows = false;
            datancc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            mskdt.Text = "";
            txtdc.Text = "";
            txtmancc.Enabled = false;
        }

        private void datancc_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmancc.Focus();
                return;
            }
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmancc.Text = datancc.CurrentRow.Cells["mancc"].Value.ToString();
            txttenncc.Text = datancc.CurrentRow.Cells["tenncc"].Value.ToString();
            mskdt.Text = datancc.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtdc.Text = datancc.CurrentRow.Cells["diachi"].Value.ToString();
            btnhuy.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmancc.Enabled = true;
            txttenncc.Enabled = true;
            mskdt.Enabled = true;
            txtdc.Enabled = true;
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                return;
            }
            if (txttenncc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
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
            sql = "insert into ncc(mancc,tenncc,diachi,dienthoai)values(N'" + txtmancc.Text.Trim() + "',N'" + txttenncc.Text.Trim() + "',N'" + txtdc.Text.Trim() + "',N'" + mskdt.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmancc.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenncc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenncc.Focus();
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
            sql = "update ncc set tenncc = N'" + txttenncc.Text.Trim() + "', diachi = N'" + txtdc.Text.Trim() + "', dienthoai = N'" + mskdt.Text.Trim() + "' where mancc = N'" + txtmancc.Text.Trim() + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnhuy.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete ncc where mancc=N'" + txtmancc.Text.Trim() + "'";
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

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
