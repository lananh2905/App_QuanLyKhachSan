using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data.Common;
using Microsoft.Office.Interop.Excel;

namespace Code.All_user_control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        string id;
        string Name;
        string Sex;
        string CMND;
        string sdt;
        string diachi;
        string email;
        string ngayBD;
        string ngayKT;
        int priceRentroom;
        string numberCus;
        string typeCus;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut__Load(object sender, EventArgs e)
        {
            query = "select TP.MATP as [Mã TP],KH.HOTEN as [Họ tên KH], KH.CMND as [CMND], TP.MAPH as [Phòng thuê], LP.GHICHU as [Loại phòng], FORMAT(TP.NGTHUE, 'dd/MM/yyyy HH:mm:ss') as [Ngày thuê],  FORMAT(TP.NGTRAPHONG, 'dd/MM/yyyy HH:mm:ss') as [Ngày trả phòng],TP.SOLUONGKH as [Số lượng KH], KH.LOAIKH as[Loại KH], TP.TRANGTHAI as [Trạng thái] " +
                "from KHACHHANG KH " +
                "inner join THUEPHONG TP on KH.MAKH = TP.MAKH " +
                "inner join PHONG PH on PH.MAPH = TP.MAPH " +
                "inner join LOAIPHONG LP on LP.MALPH = PH.MALPH";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            // Tính tỷ lệ phần trăm chiều rộng cho mỗi cột
            float[] columnWidths = { 7, 10, 8, 8, 12, 12, 10, 5, 10, 8 };
            float totalWidth = guna2DataGridView1.Width - guna2DataGridView1.RowHeadersWidth;

            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                guna2DataGridView1.Columns[i].Width = (int)(totalWidth * (columnWidths[i] / 100));
            }
        }


        public void clearAll()
        {
            txtCName.Clear();
            txtRoom.Clear();
            txtName.Clear();
            txtCheckOutDate.ResetText();
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Name = txtCName.Text;
                ngayBD = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ngayKT = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                CMND = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                numberCus = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                typeCus = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                query = "select GIOITINH, SDT, EMAIL, DIACHI  from KHACHHANG inner join THUEPHONG on KHACHHANG.MAKH = THUEPHONG.MAKH and THUEPHONG.MATP = '" + id + "';";
                DataSet ds = fn.getData(query);

                Sex = ds.Tables[0].Rows[0]["GIOITINH"].ToString();
                sdt = ds.Tables[0].Rows[0]["SDT"].ToString();
                email = ds.Tables[0].Rows[0]["EMAIL"].ToString();
                diachi = ds.Tables[0].Rows[0]["DIACHI"].ToString();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            String name = txtName.Text;

            query = "select TP.MATP as [Mã TP],KH.HOTEN as [Họ tên KH], KH.CMND as [CMND], TP.MAPH as [Phòngthuê], LP.GHICHU as [Loại phòng], FORMAT(TP.NGTHUE, 'dd/MM/yyyy HH:mm:ss') as [Ngày thuê],  FORMAT(TP.NGTRAPHONG, 'dd/MM/yyyy HH:mm:ss') as [Ngày trả phòng],TP.SOLUONGKH as [Số lượng KH], KH.LOAIKH as[Loại KH], TP.TRANGTHAI as [Trạng thái] " +
                    "from KHACHHANG KH " +
                    "inner join THUEPHONG TP on KH.MAKH = TP.MAKH and KH.HOTEN = N'" + name + "'" +
                    "inner join PHONG PH on PH.MAPH = TP.MAPH " +
                    "inner join LOAIPHONG LP on LP.MALPH = PH.MALPH";


            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            // Tính tỷ lệ phần trăm chiều rộng cho mỗi cột
            float[] columnWidths = { 7, 10, 8, 8, 12, 12, 10, 5, 10, 8, 8, 6 };
            float totalWidth = guna2DataGridView1.Width - guna2DataGridView1.RowHeadersWidth;

            for (int i = 0; i < guna2DataGridView1.Columns.Count; i++)
            {
                guna2DataGridView1.Columns[i].Width = (int)(totalWidth * (columnWidths[i] / 100));
            }

            if (name == "")
            {
                UC_CheckOut__Load(this, null);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "" && txtRoom.Text != "")
            {
                if (Checked() == false)
                {
                    if (MessageBox.Show("Bạn có chắc chắn thanh toán không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {

                        string name = txtCName.Text;
                        string roomno = txtRoom.Text;
                        string checkoutdate = txtCheckOutDate.Text;

                        // Update status Room
                        query = "update PHONG set TRANGTHAI = N'Trống' where MAPH = '" + roomno + "'";
                        fn.setData(query, null);

                        // Update ngày lập hoá đơn
                        query = "update HOADON set NGLAP = CONVERT(DATETIME, '" + checkoutdate + "', 103) where MATP = '" + id + "'";
                        fn.setData(query, null);

                        // Update tổng tiền
                        int priceDV = PriceDV();

                        query = "update HOADON set TONGTIEN = TONGTIEN + " + priceDV + " where MATP = '" + id + "'";
                        fn.setData(query, null);

                        // Update status THUEPHONG
                        query = "update THUEPHONG set TRANGTHAI = N'Đã thanh toán' where MATP = '" + id + "';";
                        fn.setData(query, null);

                        int totalPrice = TotalPrice();

                        string sucess = "Vui lòng thanh toán : " + totalPrice.ToString() + " đồng";

                        MessageBox.Show(sucess, "Total Price", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show("Thanh toán thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UC_CheckOut__Load(this, null);
                    }
                }
                else
                {
                    MessageBox.Show("Phòng này đã được thanh toán", "Status", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    clearAll();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng để thanh toán", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public bool Checked()
        {
            query = "select MATP from THUEPHONG where TRANGTHAI = N'Đã thanh toán' and MATP = '"+ id +"'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public int TotalPrice()
        {
            query = "select TONGTIEN from HOADON where MATP = '" + id + "'";
            DataSet ds = fn.getData(query);

            return Convert.ToInt32(Convert.ToDecimal(ds.Tables[0].Rows[0]["TONGTIEN"]));
        }

        public int PriceDV()
        {
            int priceDV = 0;
            query = "select sum(TONGTIENDV) as tongdv from DICHVU where MATP = '" + id + "';";
            DataSet ds = fn.getData(query);


            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["tongdv"] != DBNull.Value)
            {
                priceDV = Convert.ToInt32(Convert.ToDecimal(ds.Tables[0].Rows[0]["tongdv"]));
            }

            return priceDV;
        }


        public double DonGia()
        {
            string loaiKH;
            double heso = 1;
            string loaiPH;
            query = "select LOAIKH from KHACHHANG inner join THUEPHONG on KHACHHANG.MAKH = THUEPHONG.MAKH and THUEPHONG.MATP = '" + id + "'";
            DataSet ds = fn.getData(query);

            loaiKH = (ds.Tables[0].Rows[0]["LOAIKH"]).ToString();

            if (loaiKH == "Khách nước ngoài")
            {
                heso = 1.5; 
            }

            query = "select MALPH from PHONG where MAPH in (select MAPH from THUEPHONG where MATP = '" + id + "')";
            ds = fn.getData(query);
            loaiPH = (ds.Tables[0].Rows[0]["MALPH"]).ToString();

            int soluongKH;
            query = "select SOLUONGKH from THUEPHONG where MATP = '" + id + "' ";
            ds = fn.getData(query);
            soluongKH = int.Parse(ds.Tables[0].Rows[0]["SOLUONGKH"].ToString());

            
            if(loaiPH == "LP01")
            {
                if (soluongKH == 3) return 150000 * heso * 1.25;
                return 150000 * heso;
            }

            if(loaiPH == "LP02")
            {
                if (soluongKH == 3) return 170000 * heso * 1.25;
                return 170000 * heso;
            }
            if(loaiPH == "LP03")
            {
                if (soluongKH == 3) return 200000 * heso * 1.25;    
            }
            return 200000 * heso;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "" && txtRoom.Text != "")
            {
                // Tạo dữ liệu mẫu để xuất ra Excel
                query = "select LOAIDICHVU.TENDV, FORMAT(DICHVU.NGBATDAUDV, 'dd/MM/yyyy HH:mm:ss') as [BATDAUDV], FORMAT(DICHVU.NGKETTHUCDV, 'dd/MM/yyyy HH:mm:ss') as [KETTHUC], LOAIDICHVU.DONGIA, DICHVU.SOLUONGDV, DICHVU.TONGTIENDV from DICHVU inner join LOAIDICHVU on DICHVU.MALDV = LOAIDICHVU.MALDV and DICHVU.MATP = '" + id + "';";
                DataSet ds = fn.getData(query);
                System.Data.DataTable dt = ds.Tables[0];

                // Gọi phương thức để xuất file Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                saveFileDialog.Title = "Save an Excel File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(dt, saveFileDialog.FileName);
                }

                clearAll();

            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng để lập hoá đơn", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public int CalNumberDate()
        {
            string monthS = ngayBD.Substring(3, 4);
            int yearStart = 2024;
            int monthStart = int.Parse(monthS.Substring(0, 2));
            int dayStart = int.Parse(ngayBD.Substring(0,2));
            int yearEnd = 2024;
            string monthE = ngayKT.Substring(3, 4);
            int monthEnd = int.Parse(monthE.Substring(0, 2));
            int dayEnd = int.Parse(ngayKT.Substring(0, 2));

            if (yearStart == yearEnd)
            {
                if (monthStart == monthEnd)
                {
                    return dayEnd - dayStart;
                }
                else
                {
                    if (monthStart == 1 || monthStart == 3 || monthStart == 5 || monthStart == 7 || monthStart == 8 || monthStart == 10 || monthStart == 12)
                    {
                        return (31 - dayStart) + dayEnd;
                    }
                    else
                    {
                        return (30 - dayStart) + dayEnd;
                    }
                }
            }
            else
            {
                return (31 - dayStart) + dayEnd;
            }

        }


        private void ExportToExcel(System.Data.DataTable dt, string filePath)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Sử dụng EPPlus để tạo file Excel
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Dòng 1: Tiêu đề
                worksheet.Cells["A1"].Value = "HOÁ ĐƠN THANH TOÁN CHI TIẾT";
                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A1"].Style.Font.Size = 13;
                worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Row(1).Height = 20; // Tăng chiều cao dòng để rõ hơn

                // Merge các ô để tiêu đề nằm giữa
                worksheet.Cells["A1:G1"].Merge = true;

                // Dòng 2: Thông tin khách hàng
                worksheet.Cells["A2"].Value = "* Thông tin khách hàng";
                worksheet.Cells["A2"].Style.Font.Bold = true;
                worksheet.Cells["A2"].Style.Font.Size = 11;
                worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                // Dòng 3 - 5: Thông tin khách hàng
                worksheet.Cells["A3"].Value = "Họ tên khác hàng : " + Name;
                worksheet.Cells["D3"].Value = "Giới tính : " + Sex;
                worksheet.Cells["A4"].Value = "CMND : " + CMND;
                worksheet.Cells["A5"].Value = "SĐT :" + sdt;
                worksheet.Cells["D4"].Value = "Địa chỉ : " + diachi;
                worksheet.Cells["D5"].Value = "Email : " + email;
                worksheet.Cells["F3"].Value = "Sô lượng KH : " + numberCus;
                worksheet.Cells["F4"].Value = "Loại KH : " + typeCus;
                

                worksheet.Cells["A4:A7"].Style.Font.Size = 11;
                worksheet.Cells["A4:A7"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                

                //Dòng 7
                //Thông tin hoá đơn
                worksheet.Cells["A7"].Value = "* Tính tiền";
                worksheet.Cells["A7"].Style.Font.Bold = true;


                // Dòng 12
                // Tạo header từ tên các cột của DataTable
                worksheet.Cells["A8"].Value = "STT";
                worksheet.Cells["B8"].Value = "Tên";
                worksheet.Cells["C8"].Value = "Ngày bắt đầu thuê";
                worksheet.Cells["D8"].Value = "Ngày kết thúc thuê";
                worksheet.Cells["E8"].Value = "Đơn giá";
                worksheet.Cells["F8"].Value = "Số lượng";
                worksheet.Cells["G8"].Value = "Tổng tiền";


                worksheet.Cells["A8:G8"].Style.Font.Size = 11;
                worksheet.Cells["A8:G8"].Style.Font.Bold = true;
                worksheet.Cells["A8:G8"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells["A8:G8"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                worksheet.Cells["A8:G8"].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);



                //Dòng 9
                //Tạo hàng tiền phòng

                worksheet.Cells["A9"].Value = 1;
                worksheet.Cells["B9"].Value = "Tiền phòng";
                worksheet.Cells["C9"].Value = ngayBD;
                worksheet.Cells["D9"].Value = ngayKT;
                int numberdate = CalNumberDate();
                double dongia = DonGia();
                double price = dongia * numberdate;
                worksheet.Cells["E9"].Value = dongia;
                worksheet.Cells["F9"].Value = numberdate;
                worksheet.Cells["G9"].Value = price;

                
                //Dòng 10
                //Các loại DICHVU
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    worksheet.Cells[i + 10, 1].Value = i + 2;
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 10, j + 2].Value = dt.Rows[i][j];
                    }
                }
                
                
                //Tổng cộng
                int size = dt.Rows.Count;
                worksheet.Cells[11 + size, 6].Value = "Tổng cộng : ";
                worksheet.Cells[11 + size, 6].Style.Font.Size = 11;
                worksheet.Cells[11 + size, 6].Style.Font.Bold = true;

                int totalprice = TotalPrice();
                worksheet.Cells[11 + size, 7].Value = totalprice;

                int so = 9 + size;
                string bang = "A8:G" + so.ToString();

                var range = worksheet.Cells[bang];

                // Thêm đường viền cho toàn bộ vùng dữ liệu
                range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                so = 11 + size;
                bang = "A8:G" + so.ToString();
                // Định dạng bảng
                worksheet.Cells[bang].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(1).Width = 5;
                worksheet.Column(2).Width = 18;
                worksheet.Column(3).Width = 20;
                worksheet.Column(4).Width = 20;
                worksheet.Column(5).Width = 10;
                worksheet.Column(6).Width = 10;

                // Mô tả
                worksheet.Cells[12 + size, 1].Value = "* Mô tả : ";
                worksheet.Cells[12 + size, 1].Style.Font.Size = 11;
                worksheet.Cells[12 + size, 1].Style.Font.Bold = true;

                //Dòng mô tả tiền phòng
                worksheet.Cells[13 + size, 1].Value = "Tiền phòng:   Nếu số lượng KH là 3, *1.25. Nếu là 'Khách nước ngoài', *1.5.";
                worksheet.Cells[13 + size, 1].Style.Font.Size = 11;

                //Dòng mô tả DV
                query = "select MOTA from LOAIDICHVU";
                DataSet ds = fn.getData(query);
                worksheet.Cells[14 + size, 1].Value = "Giặt ủi quần áo:   " + ds.Tables[0].Rows[0]["MOTA"];
                worksheet.Cells[15 + size, 1].Value = "Cho thuê xe máy:   " + ds.Tables[0].Rows[1]["MOTA"];
                worksheet.Cells[16 + size, 1].Value = "Thu đổi ngoại tệ:   " + ds.Tables[0].Rows[2]["MOTA"];
                worksheet.Cells[17 + size, 1].Value = "Đón khách:   " + ds.Tables[0].Rows[3]["MOTA"];
                worksheet.Cells[18 + size, 1].Value = "Buffet sáng:   " + ds.Tables[0].Rows[4]["MOTA"];

                // Lưu file Excel
                FileInfo file = new FileInfo(filePath);
                excelPackage.SaveAs(file);
            }

            // Hiển thị thông báo sau khi xuất thành công
            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
