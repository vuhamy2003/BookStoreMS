using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTL.Forms
{
    public partial class baocaokhachhang : Form
    {
        public baocaokhachhang()
        {
            InitializeComponent();
        }
        DataTable bckh;
        private void baocaokhachhang_Load(object sender, EventArgs e)
        {
            cbothang.Enabled = false;
            txtnam.Enabled = false;
            btntao.Enabled = true;
            btndong.Enabled = true;
            btnin.Enabled = false;
            btnhienthi.Enabled = false;

            //đổ 12 tháng vào combobox
            cbothang.Items.Add("1");
            cbothang.Items.Add("2");
            cbothang.Items.Add("3");
            cbothang.Items.Add("4");
            cbothang.Items.Add("5");
            cbothang.Items.Add("6");
            cbothang.Items.Add("7");
            cbothang.Items.Add("8");
            cbothang.Items.Add("9");
            cbothang.Items.Add("10");
            cbothang.Items.Add("11");
            cbothang.Items.Add("12");
        }
        private void ResetValue()
        {
            cbothang.Text = "";
            txtnam.Text = "";
        }
        private void load_datagrid()
        {
            databc.Columns[0].HeaderText = "Mã khách";
            databc.Columns[1].HeaderText = "Tên khách";
            databc.Columns[2].HeaderText = "Số lượng đã mua";
            databc.Columns[3].HeaderText = "Tổng tiền";
            databc.AllowUserToAddRows = false;
            databc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btntao_Click(object sender, EventArgs e)
        {
            cbothang.Enabled = true;
            txtnam.Enabled = true;
            cbothang.Focus();
            btnhienthi.Enabled = true;
            databc.DataSource = null;
            ResetValue();
        }

        private void cbothang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 13) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 13) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (txtnam.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnam.Focus();
                return;
            }
            if (cbothang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbothang.Focus();
                return;
            }
            string sql;

            sql = "SELECT TOP 5 a.makhach, c.tenkhach, SUM(b.soluong) AS tong_so_luong_sach_mua, SUM(b.soluong * b.giaban) AS tong_tien FROM hdb a JOIN chitiethdb b ON a.sohdb = b.sohdb JOIN khachhang c ON a.makhach = c.makhach WHERE MONTH(a.ngayban) = N'"+cbothang.SelectedItem+"' AND YEAR(a.ngayban) = N'"+txtnam.Text+"' GROUP BY a.makhach, c.tenkhach ORDER BY SUM(b.soluong) DESC";
            bckh = BTL.Class.Functions.GetDataToTable(sql);
            databc.DataSource = bckh;
            load_datagrid();
            btnhienthi.Enabled = false;
            cbothang.Enabled = false;
            txtnam.Enabled = false;
            btnin.Enabled = true;
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable danhsach;


            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 11;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;//đặt màu cho chữ
            exRange.Range["A1:A1"].ColumnWidth = 10;//độ rộng cột
            exRange.Range["B1:B1"].ColumnWidth = 16;
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "MYHUYENMY BOOK";
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Hà Nội";
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = "Điện thoại: 0812021203";
            exRange.Range["D2:F2"].Font.Size = 16;
            exRange.Range["D2:F2"].Font.Bold = true;
            exRange.Range["D2:F2"].Font.ColorIndex = 3;
            exRange.Range["D2:F2"].MergeCells = true;
            exRange.Range["D2:F2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:F2"].Value = "Báo cáo 5 khách hàng mua nhiều nhất";
            exRange.Range["D3:F3"].Font.Size = 14;
            exRange.Range["D3:F3"].Font.Bold = true;
            exRange.Range["D3:F3"].Font.ColorIndex = 3;
            exRange.Range["D3:F3"].MergeCells = true;
            exRange.Range["D3:F3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D3:F3"].Value = "Tháng " + cbothang.SelectedItem + " Năm " + txtnam.Text;
            sql = "SELECT TOP 5 a.makhach, c.tenkhach, SUM(b.soluong) AS tong_so_luong_sach_mua, SUM(b.soluong * b.giaban) AS tong_tien FROM hdb a JOIN chitiethdb b ON a.sohdb = b.sohdb JOIN khachhang c ON a.makhach = c.makhach WHERE MONTH(a.ngayban) = N'" + cbothang.SelectedItem + "' AND YEAR(a.ngayban) = N'" + txtnam.Text + "' GROUP BY a.makhach, c.tenkhach ORDER BY SUM(b.soluong) DESC";
            danhsach = Class.Functions.GetDataToTable(sql);//đổ dữ liệu từ lệnh sql vào biến "danhsach"

            exRange.Range["B5:F5"].Font.Bold = true;//In đậm các chữ 
            exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 14;
            exRange.Range["C5:C5"].ColumnWidth = 13;
            exRange.Range["D5:D5"].ColumnWidth = 26;
            exRange.Range["E5:E5"].ColumnWidth = 26;
            exRange.Range["F5:F5"].ColumnWidth = 26;
            exRange.Range["G9:G9"].ColumnWidth = 26;


            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã khách";
            exRange.Range["D5:D5"].Value = "Tên khách";
            exRange.Range["E5:E5"].Value = "Số lượng đã mua";
            exRange.Range["F5:F5"].Value = "Tổng tiền";

            //vòng lặp để đổ dữ liệu từ biến "danhsach" vào excel
            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;//điền số thứ tự vào cột 2 bắt đầu từ hàng 6 (mở excel ra hình dung)
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();//điền thông tin các cột còn lại từ dữ liệu đã đc đổ vào từ biến "danhsach" bắt đầu từ cột 3, hàng 6
                }
            }

            exRange = exSheet.Cells[2][hang + 8];//chỗ này là đánh dấu vị trí viết cái dòng "Hà Nội, ngày..."
            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }
    }
}
