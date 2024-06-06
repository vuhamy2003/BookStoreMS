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
    public partial class baocaotonkhonhieu : Form
    {
        public baocaotonkhonhieu()
        {
            InitializeComponent();
        }
        DataTable bctktd;
        private void baocaotonkho_Load(object sender, EventArgs e)
        {
            ResetValues();
            databc.DataSource = null;
            txtnhieu.Enabled = false;
            btntao.Enabled = true;
            btndong.Enabled = true;
            btnin.Enabled = false;
            btnhienthi.Enabled = false;
        }
        private void ResetValues()
        {
            txtnhieu.Text = "";
        }
        private void load_datagrid()
        {
            databc.Columns[0].HeaderText = "Mã sách";
            databc.Columns[1].HeaderText = "Tên sách";
            databc.Columns[2].HeaderText = "Số lượng tồn kho";
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
            txtnhieu.Enabled = true;
            btnhienthi.Enabled = true;
            databc.DataSource = null;
            ResetValues();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (txtnhieu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng tồn tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnhieu.Focus();
                return;
            }
            string sql;

            sql = "SELECT masach, tensach, soluong FROM sach WHERE soluong > N'" + txtnhieu.Text.Trim() + "' ORDER BY soluong DESC";
            bctktd = BTL.Class.Functions.GetDataToTable(sql);
            databc.DataSource = bctktd;
            load_datagrid();
            btnhienthi.Enabled = false;
            txtnhieu.Enabled = false;
            btnin.Enabled = true;
        }

        private void txtnhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 13) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
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
            exRange.Range["D2:F2"].Value = "Báo cáo danh sách sách vượt mức tồn kho tối đa ";
            exRange.Range["D3:F3"].Font.Size = 14;
            exRange.Range["D3:F3"].Font.Bold = true;
            exRange.Range["D3:F3"].Font.ColorIndex = 3;
            exRange.Range["D3:F3"].MergeCells = true;
            exRange.Range["D3:F3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D3:F3"].Value = "Tồn kho tối đa: " + txtnhieu.Text;
            sql = "SELECT masach, tensach, soluong FROM sach WHERE soluong > N'" + txtnhieu.Text.Trim() + "' ORDER BY soluong DESC";
            danhsach = Class.Functions.GetDataToTable(sql);//đổ dữ liệu từ lệnh sql vào biến "danhsach"

            exRange.Range["B5:F5"].Font.Bold = true;//In đậm các chữ 
            exRange.Range["B5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 14;
            exRange.Range["C5:C5"].ColumnWidth = 13;
            exRange.Range["D5:D5"].ColumnWidth = 26;
            exRange.Range["E5:E5"].ColumnWidth = 26;
            exRange.Range["G9:G9"].ColumnWidth = 26;


            exRange.Range["E5:E5"].Font.Bold = true;
            exRange.Range["E5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã sản phẩm";
            exRange.Range["D5:D5"].Value = "Tên sản phẩm";
            exRange.Range["E5:E5"].Value = "Số lượng tồn kho";

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
