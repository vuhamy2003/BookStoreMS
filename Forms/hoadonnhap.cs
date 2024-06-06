using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using BTL.Class;


namespace BTL.Forms
{
    public partial class hoadonnhap : Form
    {
        public hoadonnhap()
        {
            InitializeComponent();
        }
        DataTable tblhdnh;
        private void hoadonnhap_Load(object sender, EventArgs e)
        {
            btntaohd.Enabled = true;
            btnluu.Enabled = false;
            btnhuyhd.Enabled = false;
            btninhd.Enabled = false;

            txtsohdn.ReadOnly = true;
            txttennv.ReadOnly = true;
            txttenncc.ReadOnly = true;

            txtdc.ReadOnly = true;
            txtdt.ReadOnly = true;
            txttens.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtkm.Text = "0";
            txttongtien.Text = "0";
            Functions.FillCombo("SELECT mancc, tenncc FROM ncc", cbomancc, "mancc", "mancc");
            cbomancc.SelectedIndex = -1;
            Functions.FillCombo("SELECT manhanvien, tennhanvien FROM nhanvien WHERE macongviec IN ('CV01', 'CV02')", cbomanv, "manhanvien", "manhanvien");
            cbomanv.SelectedIndex = -1;
            Functions.FillCombo("SELECT masach, tensach FROM sach", cbomas, "masach", "masach");
            cbomas.SelectedIndex = -1;
            Functions.FillCombo("SELECT sohdn FROM chitiethdn", cbosohdn, "sohdn", "sohdn");
            cbosohdn.SelectedIndex = -1;

            if (txtsohdn.Text != "")
            {
                Load_ThongtinHD();
                btnhuyhd.Enabled = true;
                btninhd.Enabled = true;
            }
            load_datagrid();
        }
        private void load_datagrid()
        {
            string sql;
            //sql = "SELECT a.masach, b.tensach, a.soluong, a.gianhap, a.khuyenmai, a.thanhtien FROM chitiethdn AS a, sach AS b WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.masach=b.masach";
            sql = "SELECT a.masach, b.tensach, a.soluong, a.gianhap, a.khuyenmai, a.thanhtien FROM chitiethdn AS a, sach AS b WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.masach=b.masach";
            tblhdnh = Functions.GetDataToTable(sql);
            datahdn.DataSource = tblhdnh;
            datahdn.Columns[0].HeaderText = "Mã sách";
            datahdn.Columns[1].HeaderText = "Tên sách";
            datahdn.Columns[2].HeaderText = "Số lượng";
            datahdn.Columns[3].HeaderText = "Giá nhập";
            datahdn.Columns[4].HeaderText = "Khuyến mãi";
            datahdn.Columns[5].HeaderText = "Thành tiền";
            datahdn.AllowUserToAddRows = false;
            datahdn.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Load_ThongtinHD()
        {
            string str;
            str = "SELECT ngaynhap FROM hdn WHERE sohdn = N'" + txtsohdn.Text + "'";
            txtngaynhap.Text = Functions.ConvertDateTime(Functions.GetFieldValues(str));

            str = "SELECT manhanvien FROM hdn WHERE sohdn = N'" + txtsohdn.Text + "'";
            cbomanv.Text = Functions.GetFieldValues(str);

            str = "SELECT mancc FROM hdn WHERE sohdn = N'" + txtsohdn.Text + "'";
            cbomancc.Text = Functions.GetFieldValues(str);

            str = "SELECT tongtien FROM hdn WHERE sohdn = N'" + txtsohdn.Text + "'";
            txttongtien.Text = Functions.GetFieldValues(str);

            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txttongtien.Text);
        }

        private void btntaohd_Click(object sender, EventArgs e)
        {
            btnhuyhd.Enabled = false;
            btnluu.Enabled = true;
            btninhd.Enabled = false;
            btntaohd.Enabled = false;
            ResetValues();
            txtsohdn.Text = Functions.CreateKey("HDB");
            txtgianhap.Enabled = true;
            load_datagrid();
        }
        private void ResetValues()
        {
            txtsohdn.Text = "";
            txtngaynhap.Text = DateTime.Now.ToString();
            cbomanv.Text = "";
            cbomancc.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomas.Text = "";
            txtsl.Text = "";
            txtkm.Text = "0";
            txtgianhap.Text = "";
            txtthanhtien.Text = "0";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, slcon, tong, tongmoi, giamoi;
            sql = "SELECT sohdn FROM hdn WHERE sohdn=N'" + txtsohdn.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtngaynhap.Text.Trim().Length > 0)
                {
                    try
                    {
                        DateTime ngaynhap = Convert.ToDateTime(txtngaynhap.Text.Trim());

                        sql = "INSERT INTO hdn(sohdn, ngaynhap, manhanvien, mancc, tongtien) VALUES(N'" + txtsohdn.Text.Trim() + "', '" + ngaynhap.ToString("MM-dd-yyyy") + "',N'" + cbomanv.SelectedValue + "',N'" + cbomancc.SelectedValue + "'," + txttongtien.Text + ")";
                        Functions.RunSql(sql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu ngày nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (cbomancc.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomancc.Focus();
                    return;
                }
                if (cbomanv.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomanv.Focus();
                    return;
                }
                //lưu thông tin chung vào bảng hdn    
                sql = "INSERT INTO hdn(sohdn, ngaynhap, manhanvien, mancc, tongtien) VALUES(N'" + txtsohdn.Text.Trim() + "', '" + Functions.ConvertDateTime(txtngaynhap.Text.Trim()) + "',N'" + cbomanv.SelectedValue + "',N'" + cbomancc.SelectedValue + "'," + txttongtien.Text + ")";
                Functions.RunSql(sql);
            }

            // Lưu thông tin của các mặt hàng
            if (cbomas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomas.Focus();
                return;
            }
            if ((txtsl.Text.Trim().Length == 0) || (txtsl.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsl.Text = "";
                txtsl.Focus();
                return;
            }
            if (txtkm.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkm.Focus();
                return;
            }
            sql = "SELECT masach FROM chitiethdn WHERE masach=N'" + cbomas.SelectedValue + "' AND sohdn = N'" + txtsohdn.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesSach();
                cbomas.Focus();
                return;
            }
            sql = "INSERT INTO chitiethdn(sohdn,masach,soluong,gianhap,khuyenmai,thanhtien) VALUES(N'" + txtsohdn.Text.Trim() + "', N'" + cbomas.SelectedValue + "'," + txtsl.Text + "," + txtgianhap.Text + "," + txtkm.Text + "," + txtthanhtien.Text + ")";
            Functions.RunSql(sql);
            load_datagrid();

            giamoi = Convert.ToDouble(txtgianhap.Text);

            //Cập nhật lại đơn giá nhập và đơn giá bán theo giá nhập mới
            sql = "update sach set gianhap = '" + giamoi + "' where masach = N'" + cbomas.SelectedValue + "'";
            Class.Functions.RunSql(sql);

            sql = "update sach set giaban = '" + (giamoi * 1.1) + "' where masach = N'" + cbomas.SelectedValue + "'";
            Class.Functions.RunSql(sql);

            // Cập nhật lại số lượng của mặt hàng vào bảng Sách
            sl = Convert.ToDouble(Class.Functions.GetFieldValues("select soluong from sach where masach=N'" + cbomas.SelectedValue + "'"));

            slcon = sl + Convert.ToDouble(txtsl.Text);

            sql = "update sach set soluong = '" + slcon + "' where masach = N'" + cbomas.SelectedValue + "'";
            Class.Functions.RunSql(sql);

            //Cập nhập tổng tiền cho HĐN
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT tongtien FROM hdn WHERE sohdn = N'" + txtsohdn.Text + "'"));
            tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE hdn SET tongtien =" + tongmoi + " WHERE sohdn = N'" + txtsohdn.Text + "'";
            Functions.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
            ResetValuesSach();
            btnhuyhd.Enabled = true;
            btntaohd.Enabled = true;
            btninhd.Enabled = true;
        }
        private void ResetValuesSach()
        {
            cbomas.Text = "";
            txtsl.Text = "";
            txtkm.Text = "0";
            txtthanhtien.Text = "0";
            txttens.Text = "";
            txtgianhap.Text = "";
        }

        private void datahdn_DoubleClick(object sender, EventArgs e)
        {
            string masach;
            Double thanhtien;
            if (tblhdnh.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                masach = datahdn.CurrentRow.Cells["masach"].Value.ToString();
                Delsach(txtsohdn.Text, masach);
                // Cập nhật lại tổng tiền cho hóa đơn nhập
                thanhtien = Convert.ToDouble(datahdn.CurrentRow.Cells["thanhtien"].Value.ToString());
                DelUpdatetongtien(txtsohdn.Text, thanhtien);
                load_datagrid();
            }
        }
        private void Delsach(string sohdn, string mas)
        {
            Double s, sl, slcon;
            string sql;
            sql = "SELECT soluong FROM chitiethdn WHERE sohdn = N'" + sohdn + "' AND masach = N'" + mas + "'";
            s = Convert.ToDouble(Functions.GetFieldValues(sql));
            sql = "DELETE chitiethdn WHERE sohdn=N'" + sohdn + "' AND masach = N'" + mas + "'";
            Functions.RunSql(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT soluong FROM sach WHERE masach = N'" + mas + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            slcon = sl - s;
            sql = "UPDATE sach SET soluong =" + slcon + " WHERE masach= N'" + mas + "'";
            Functions.RunSql(sql);
        }
        private void DelUpdatetongtien(string sohdn, double Thanhtien)
        {
            Double tong, tongmoi;
            string sql;
            sql = "SELECT tongtien FROM hdn WHERE sohdn = N'" + sohdn + "'";
            tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            tongmoi = tong - Thanhtien;
            sql = "UPDATE hdn SET tongtien =" + tongmoi + " WHERE sohdn = N'" + sohdn + "'";
            Functions.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
        }

        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] masach = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT masach FROM chitiethdn WHERE sohdn = N'" + txtsohdn.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    masach[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    Delsach(txtsohdn.Text, masach[i]);
                //Xóa hóa đơn
                sql = "DELETE hdn WHERE sohdn=N'" + txtsohdn.Text + "'";
                Functions.RunSql(sql);
                ResetValues();
                load_datagrid();
                btnhuyhd.Enabled = false;
                btninhd.Enabled = false;
            }
        }

        private void cbomanv_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanv.Text == "")
                txttennv.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select tennhanvien from nhanvien where macongviec IN ('CV01', 'CV02') and manhanvien =N'" + cbomanv.SelectedValue + "'";
            txttennv.Text = Functions.GetFieldValues(str);
        }

        private void cbomancc_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomancc.Text == "")
            {
                txttenncc.Text = "";
                txtdc.Text = "";
                txtdt.Text = "";
            }
            //Khi kich chon Ma ncc thi ten ncc, dia chi, dien thoai se tu dong hien ra
            str = "Select tenncc from ncc where mancc = N'" + cbomancc.SelectedValue + "'";
            txttenncc.Text = Functions.GetFieldValues(str);
            str = "Select diachi from ncc where mancc = N'" + cbomancc.SelectedValue + "'";
            txtdc.Text = Functions.GetFieldValues(str);
            str = "Select dienthoai from ncc where mancc= N'" + cbomancc.SelectedValue + "'";
            txtdt.Text = Functions.GetFieldValues(str);
        }

        private void cbomas_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomas.Text == "")
            {
                txttens.Text = "";
                txtgianhap.Text = "";
            }
            // Khi kich chon Ma sach thi ten sach va gia nhap se tu dong hien ra
            str = "SELECT tensach FROM sach WHERE masach =N'" + cbomas.SelectedValue + "'";
            txttens.Text = Functions.GetFieldValues(str);
            str = "SELECT gianhap FROM sach WHERE masach =N'" + cbomas.SelectedValue + "'";
            txtgianhap.Text = Functions.GetFieldValues(str);
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            double thanhtien, soluong, gianhap, khuyenmai;
            if (txtsl.Text == "")
                soluong = 0;
            else
                soluong = Convert.ToDouble(txtsl.Text);
            if (txtkm.Text == "")
                khuyenmai = 0;
            else
                khuyenmai = Convert.ToDouble(txtkm.Text);
            if (txtgianhap.Text == "")
                gianhap = 0;
            else
                gianhap = Convert.ToDouble(txtgianhap.Text);
            thanhtien = soluong * gianhap - soluong * gianhap * khuyenmai / 100;
            txtthanhtien.Text = thanhtien.ToString();
        }

        private void txtkm_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, gn, km;
            if (txtsl.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsl.Text);
            if (txtkm.Text == "")
                km = 0;
            else
                km = Convert.ToDouble(txtkm.Text);
            if (txtgianhap.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtgianhap.Text);
            tt = sl * gn - sl * gn * km / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (cbosohdn.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một số hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbosohdn.Focus();
                return;
            }
            txtsohdn.Text = cbosohdn.Text;
            Load_ThongtinHD();
            load_datagrid();
            btnhuyhd.Enabled = true;
            btnluu.Enabled = true;
            btninhd.Enabled = true;
            cbosohdn.SelectedIndex = -1;
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtkm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cbosohdn_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT sohdn FROM hdn", cbosohdn, "sohdn", "sohdn");
            cbosohdn.SelectedIndex = -1;
        }

        private void hoadonnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btninhd_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinSach;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "MYHUYENMY BOOK";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0812021203";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3;
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN NHẬP";

            sql = "SELECT a.sohdn, a.ngaynhap, a.tongtien, b.tenncc, b.diachi, b.dienthoai, c.tennhanvien FROM hdn AS a, ncc AS b, nhanvien AS c WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.mancc = b.mancc AND a.manhanvien = c.manhanvien";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Số hóa đơn nhập:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "NCC:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();

            //sql = "SELECT b.tensach, soluong, gianhap, a.khuyenmai, a.thanhtien " + "FROM chitiethdn AS a , sach AS b WHERE a.sohdn = N'" + txtsohdn.Text + "' AND a.masach = b.masach";
            sql = "SELECT chitiethdn.masach, sach.tensach, chitiethdn.soluong, sach.gianhap, chitiethdn.khuyenmai, chitiethdn.thanhtien FROM chitiethdn INNER JOIN sach ON chitiethdn.masach = sach.masach WHERE chitiethdn.sohdn = N'" + txtsohdn.Text + "'";
            tblThongtinSach = Functions.GetDataToTable(sql);

            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên sách";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Giá nhập";
            exRange.Range["E11:E11"].Value = "Khuyến mãi";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinSach.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinSach.Columns.Count - 1; cot++)
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinSach.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15];
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            double thanhtien, soluong, gianhap, khuyenmai;
            if (txtsl.Text == "")
                soluong = 0;
            else
                soluong = Convert.ToDouble(txtsl.Text);
            if (txtkm.Text == "")
                khuyenmai = 0;
            else
                khuyenmai = Convert.ToDouble(txtkm.Text);
            if (txtgianhap.Text == "")
                gianhap = 0;
            else
                gianhap = Convert.ToDouble(txtgianhap.Text);
            thanhtien = soluong * gianhap - soluong * gianhap * khuyenmai / 100;
            txtthanhtien.Text = thanhtien.ToString();
        }
    }
}
