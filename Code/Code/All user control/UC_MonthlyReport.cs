using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data.Common;
using Microsoft.Office.Interop.Excel;
using static Guna.UI2.Native.WinApi;

namespace Code.All_user_control
{
    public partial class UC_MonthlyReport : UserControl
    {


        function fn = new function();
        string query;
        public UC_MonthlyReport()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_MonthlyReport_Load(object sender, EventArgs e)
        {
            // Lấy tháng và năm từ txtMonthlyReportDate và tải dữ liệu
            int year = txtMonthlyReportDate.Value.Year;
            int month = txtMonthlyReportDate.Value.Month;
            LoadDataForMonth(year, month);
        }

        private void LoadDataForMonth(int year, int month)
        {
            query = $@"
                WITH RevenueData AS (
                    SELECT 
                        LP.GHICHU AS LoaiPhong, 
                        COUNT(TP.MAPH) AS SoLuotThue, 
                        SUM(HD.TONGTIEN) AS DoanhThu
                    FROM dbo.THUEPHONG TP
                    JOIN dbo.PHONG P ON TP.MAPH = P.MAPH
                    JOIN dbo.LOAIPHONG LP ON P.MALPH = LP.MALPH
                    INNER JOIN HOADON HD ON HD.MATP = TP.MATP
                    WHERE YEAR(TP.NGTHUE) = {year} AND MONTH(TP.NGTHUE) = {month}
                    GROUP BY LP.GHICHU
                )
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY LoaiPhong) AS [STT],
                    [LoaiPhong],
                    [DoanhThu],
                    ROUND((DoanhThu * 100.0 / (SELECT SUM(DoanhThu) FROM RevenueData)), 2) AS [TyLe]
                FROM RevenueData";

            DataSet ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0)
            {
                guna2DataGridView1.DataSource = ds.Tables[0];



                // Đặt tên tiêu đề cho các cột
                guna2DataGridView1.Columns["LoaiPhong"].HeaderText = "Loại phòng";
                guna2DataGridView1.Columns["DoanhThu"].HeaderText = "Doanh Thu";
                guna2DataGridView1.Columns["TyLe"].HeaderText = "Tỷ lệ";

                // Tính tỷ lệ phần trăm chiều rộng cho mỗi cột
                float[] columnWidths = { 10, 30, 30, 30 };
                float totalWidth = guna2DataGridView1.Width - guna2DataGridView1.RowHeadersWidth;

                for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
                {
                    guna2DataGridView1.Columns[i].Width = (int)(totalWidth * (columnWidths[i] / 100));
                }
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show("Không có dữ liệu cho tháng đã chọn.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private bool CheckDataExists(int year, int month)
        {
            string checkQuery = $@"
                SELECT COUNT(*)
                FROM dbo.THUEPHONG
                WHERE YEAR(NGTHUE) = {year} AND MONTH(NGTHUE) = {month}";

            DataSet ds = fn.getData(checkQuery);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                return count > 0;
            }
            return false;
        }


        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            int year = txtMonthlyReportDate.Value.Year;
            int month = txtMonthlyReportDate.Value.Month;

            if (CheckDataExists(year, month))
            {
                LoadDataForMonth(year, month);
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show("Không có dữ liệu cho tháng đã chọn.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }

        private void ExportToExcel(string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Báo cáo tháng");

                // Title
                string date = txtMonthlyReportDate.Text;
                worksheet.Cells["A1"].Value = "Báo cáo tháng " + date;
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.Font.Size = 13;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Row(1).Height = 20; // Tăng chiều cao dòng để rõ hơn
                worksheet.Cells["A1:D1"].Merge = true;

                // Xuất tiêu đề cột
                for (int i = 1; i < guna2DataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[3, i].Value = guna2DataGridView1.Columns[i - 1].HeaderText;
                }

                // Định dạng tiêu đề
                worksheet.Cells["A3:D3"].Style.Font.Bold = true;
                worksheet.Cells["A3:D3"].Style.Font.Size = 11;
                worksheet.Cells["A3:D3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells["A3:D3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A3:D3"].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);


                // Xuất dữ liệu
                for (int i = 0; i < guna2DataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < guna2DataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 4, j + 1].Value = guna2DataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                //Tổng cộng doanh thu
                int number = 3 + guna2DataGridView1.Rows.Count;
                int col = 5 + guna2DataGridView1.Rows.Count;

                worksheet.Cells[col, 2].Value = "Tổng doanh thu : ";
                worksheet.Cells[col, 2].Style.Font.Size = 11;
                worksheet.Cells[col, 2].Style.Font.Bold = true;

                string sum = "C4:C" + number.ToString();
                worksheet.Cells[col, 3].Formula = "SUM(" + sum + ")";
                worksheet.Cells[col, 4].Value = 100;

                //Dịnh dạng sheet
                worksheet.Cells["A3:D50"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(1).Width = 5;
                worksheet.Column(2).Width = 18;
                worksheet.Column(3).Width = 20;
                worksheet.Column(4).Width = 20;


                string table = "A3:D" + number.ToString();

                var range = worksheet.Cells[table];

                // Thêm đường viền cho toàn bộ vùng dữ liệu
                range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                FileInfo file = new FileInfo(filePath);
                excelPackage.SaveAs(file);

                MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
;

        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMonthlyReportDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
