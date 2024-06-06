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
    public partial class danhmuckh : Form
    {
        public danhmuckh()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        DataTable tblkh;
        private void load_datagrid()
        {
            string sql;
            sql = "select * from khachhang";
            tblkh = Class.Functions.GetDataToTable(sql);
            datakh.DataSource = tblkh;
            datakh.Columns[0].HeaderText = "Mã khách";
            datakh.Columns[1].HeaderText = "Tên khách";
            datakh.Columns[2].HeaderText = "Điện thoại";
            datakh.Columns[3].HeaderText = "Địa chỉ";
            datakh.AllowUserToAddRows = false;
            datakh.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void danhmuckh_Load(object sender, EventArgs e)
        {
            load_datagrid();
            txtmakh.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false; 
        }

        private void datakh_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông áo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Focus();
                return;
            }
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmakh.Text = datakh.CurrentRow.Cells["makhach"].Value.ToString();
            txttenkh.Text = datakh.CurrentRow.Cells["tenkhach"].Value.ToString();
            mskdt.Text = datakh.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtdc.Text = datakh.CurrentRow.Cells["diachi"].Value.ToString();
            btnhuy.Enabled = true;
        }

        private void ResetValues()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            mskdt.Text = "";
            txtdc.Text = "";
            txtmakh.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmakh.Enabled = true;
            txttenkh.Enabled = true;
            mskdt.Enabled = true;
            txtdc.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakh.Focus();
                return;
            }
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkh.Focus();
                return;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            if (mskdt.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdt.Focus();
                return;
            }
            sql = "select makhach from khachhang where makhach =N'" + txtmakh.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakh.Text = "";
                txtmakh.Focus();
                return;
            }
            sql = "insert into khachhang values (N'" + txtmakh.Text.Trim() + "', N'" + txttenkh.Text.Trim() + "', N'" + mskdt.Text.Trim() + "', N'" + txtdc.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmakh.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("CSDL chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkh.Text == "")
            {
                MessageBox.Show("Phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkh.Focus();
                return;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdc.Focus();
                return;
            }
            if (mskdt.Text == "")
            {
                MessageBox.Show("Phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdt.Focus();
                return;
            }
            string sql;
            sql = "update khachhang set tenkhach =N'"+txttenkh.Text.Trim()+ "',diachi =N'"+txtdc.Text.Trim()+ "',dienthoai =N'"+mskdt.Text.Trim()+ "' where makhach =N'"+txtmakh.Text.Trim()+"'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnhuy.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("CSDL chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete khachhang where makhach=N'" + txtmakh.Text.Trim() + "'";
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
    }
}
