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
    public partial class danhmucsach : Form
    {
        public danhmucsach()
        {
            InitializeComponent();
        }
        //Đơn giá bán trong bảng Sách được tự động cập nhật 110% giá nhập
        DataTable tbldms;
        private void DMSach_Load(object sender, EventArgs e)
        {
            txtmas.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            load_datagrid();
            txtsl.Enabled = false;
            txtgianhap.Enabled = false;
            txtgiaban.ReadOnly = true;
        }
        private void ResetValues()
        {
            txtmas.Text = "";
            txttens.Text = "";
            cbomals.Text = "";
            cbomanxb.Text = "";
            txtsl.Text = "0";
            txtgianhap.Text = "0";
            txtgiaban.Text = "0";            
            txtanh.Text = "";
            picanh.Image = null;
            txtsl.Enabled=false;
            txtgianhap.Enabled = false;
        }
        private void load_datagrid()
        {
            string sql;
            sql = "select masach, tensach, soluong, gianhap, giaban, maloaisach, manxb from sach";
            Functions.FillCombo("select maloaisach,tenloaisach from loaisach", cbomals, "maloaisach", "tenloaisach");
            cbomals.SelectedIndex = -1;
            Functions.FillCombo("select manxb,tennxb from nxb", cbomanxb, "manxb", "tennxb");
            cbomanxb.SelectedIndex = -1;
            tbldms = Class.Functions.GetDataToTable(sql);
            datasach.DataSource = tbldms;
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

        private void datasach_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmas.Focus();
                return;
            }
            if (tbldms.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string mas, manxb;
            txtmas.Text = datasach.CurrentRow.Cells["masach"].Value.ToString();
            txttens.Text = datasach.CurrentRow.Cells["tensach"].Value.ToString();
            mas = datasach.CurrentRow.Cells["maloaisach"].Value.ToString();
            cbomals.Text = Functions.GetFieldValues("select tenloaisach from loaisach where maloaisach =N'" + mas + "'");
            manxb = datasach.CurrentRow.Cells["manxb"].Value.ToString();
            cbomanxb.Text = Functions.GetFieldValues("select tennxb from nxb where manxb =N'" + manxb + "'");
            txtsl.Text = datasach.CurrentRow.Cells["soluong"].Value.ToString();
            txtgiaban.Text = datasach.CurrentRow.Cells["giaban"].Value.ToString();
            txtgianhap.Text = datasach.CurrentRow.Cells["gianhap"].Value.ToString();
            txtanh.Text = Functions.GetFieldValues("select anh from sach where masach =N'" + txtmas.Text.Trim() + "'");
            picanh.Image = Image.FromFile(txtanh.Text);
            btnhuy.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmas.Enabled = true;
            txtmas.Focus();
            txtsl.Enabled = true;
            txtgianhap.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmas.Focus();
                return;
            }
            if (txttens.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttens.Focus();
                return;
            }
            if (cbomals.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomals.Focus();
                return;
            }
            if (txtsl.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsl.Focus();
                return;
            }
            if (txtgianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgianhap.Focus();
                return;
            }
            double gianhap = Convert.ToDouble(txtgianhap.Text);
            double giaban = gianhap * 1.1;
            txtgiaban.Text = giaban.ToString();
            sql = "select masach from sach where masach =N'" + txtmas.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmas.Text = "";
                txtmas.Focus();
                return;
            }
            sql = "insert into sach(masach,tensach,soluong,gianhap,giaban,maloaisach,manxb,anh) values(N'" + txtmas.Text.Trim() + "',N'" + txttens.Text.Trim() + "',N'" + txtsl.Text.Trim() + "',N'" + txtgianhap.Text.Trim() + "',N'" + txtgiaban.Text.Trim() + "',N'" + cbomals.SelectedValue.ToString() + "',N'" + cbomanxb.SelectedValue.ToString() + "',N'" + txtanh.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            txtmas.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tbldms.Rows.Count == 0)
            {
                MessageBox.Show("CSDL chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmas.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttens.Text == "")
            {
                MessageBox.Show("Phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttens.Focus();
                return;
            }
            if (cbomals.Text == "")
            {
                MessageBox.Show("Phải chọn loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomals.Focus();
                return;
            }
            if (cbomanxb.Text == "")
            {
                MessageBox.Show("Phải chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanxb.Focus();
                return;
            }
            if (txtsl.Text == "")
            {
                MessageBox.Show("Phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsl.Focus();
                return;
            }
            if (txtgianhap.Text == "")
            {
                MessageBox.Show("Phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgianhap.Focus();
                return;
            }
            if (txtanh.Text == "")
            {
                MessageBox.Show("Phải chọn ảnh minh họa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtanh.Focus();
                return;
            }
            string sql;
            sql = "update sach set tensach=N'" + txttens.Text.Trim() + "',maloaisach=N'" + cbomals.SelectedValue.ToString() + "', manxb=N'" + cbomanxb.SelectedValue.ToString() + "',soluong=N'" + txtsl.Text.Trim() + "',gianhap=N'" + txtgianhap.Text.Trim() + "',giaban=N'" + txtgiaban.Text.Trim() + "',anh=N'" + txtanh.Text.Trim() + "' where masach=N'" + txtmas.Text.Trim() + "'";
            Class.Functions.RunSql(sql);
            load_datagrid();
            ResetValues();
            btnhuy.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbldms.Rows.Count == 0)
            {
                MessageBox.Show("CSDL chưa có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmas.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete sach where masach=N'" + txtmas.Text.Trim() + "'";
                Class.Functions.RunSqlDel(sql);
                load_datagrid();
                ResetValues();
                btnhuy.Enabled = false;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnhuy.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmas.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "PNG(*.png)|*.png|JPEG(*.jpeg)|*.jpeg|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\BTL_Nhóm 3\\Pictures";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chọn ảnh để hiển thị";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picanh.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void txtgiaban_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            double gianhap;
            if (txtgianhap.Text != "")
            {
                gianhap = Convert.ToDouble(txtgianhap.Text);
            }
            else
            {
                gianhap = 0;
            }
            double giaban = gianhap * 1.1;
            txtgiaban.Text = giaban.ToString();
        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
