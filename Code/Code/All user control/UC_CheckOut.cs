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
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut__Load(object sender, EventArgs e)
        {
            query = "select TP.MATP as[Mã TP],KH.HOTEN as [Họ tên KH], TP.MAPH as [Phòngthuê], LP.GHICHU as [Loại phòng], TP.NGTHUE as [Ngày thuê], TP.NGTRAPHONG as [Ngày trả phòng], TP.TRANGTHAI as [Trạng thái], KH.GIOITINH as [Giới tính], KH.CMND as[CMND], KH.SDT as[SĐT], KH.DIACHI as [Địa chỉ], KH.EMAIL as[Email] " +
                "from KHACHHANG KH " +
                "inner join THUEPHONG TP on KH.MAKH = TP.MAKH " +
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
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Name = txtCName.Text;
                Sex = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                CMND = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                sdt = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                diachi = guna2DataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                email = guna2DataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                ngayBD = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                ngayKT = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            String name = txtName.Text;

            query = "select TP.MATP as [Mã TP],KH.HOTEN as [Họ tên KH], TP.MAPH as [Phòngthuê], LP.GHICHU as [Loại phòng], TP.NGTHUE as [Ngày thuê], TP.NGTRAPHONG as [Ngày trả phòng], TP.TRANGTHAI as [Trạng thái], KH.GIOITINH as [Giới tính], KH.CMND as [CMND], KH.SDT as [SĐT], KH.DIACHI as [Địa chỉ], KH.EMAIL as [Email] " +
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
                        query = "update HOADON set NGLAP = '" + checkoutdate + "' where MATP = '" + id + "'";
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

                        clearAll();
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
            query = "select MATP from THUEPHONG where TRANGTHAI = N'Đã thanh toán'";
            DataSet ds = fn.getData(query);
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item.ToString() == id)
                        {
                            return true;
                        }
                    }
                }
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


        public int DonGia()
        {
            string loaiKH;
            int heso = 1;
            string loaiPH;
            query = "select LOAIKH from KHACHHANG inner join THUEPHONG on KHACHHANG.MAKH = THUEPHONG.MAKH and THUEPHONG.MATP = '" + id + "'";
            DataSet ds = fn.getData(query);

            loaiKH = (ds.Tables[0].Rows[0]["LOAIKH"]).ToString();

            if (loaiKH == "Khách nước ngoài")
            {
                heso = 2; 
            }

            query = "select MALPH from PHONG where MAPH in (select MAPH from THUEPHONG where MATP = '" + id + "')";
            ds = fn.getData(query);

            loaiPH = (ds.Tables[0].Rows[0]["MALPH"]).ToString();
            if(loaiPH == "LP01")
            {
                return 150000 * heso;
            }

            if(loaiPH == "LP02")
            {
                return 170000 * heso;
            }
            return 200000 * heso;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Tạo dữ liệu mẫu để xuất ra Excel
            DataTable dataTable = CreateSampleData();

            // Gọi phương thức để xuất file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dataTable, saveFileDialog.FileName);
            }
            
        }

        

        private DataTable CreateSampleData()
        {
            // Tạo bảng dữ liệu mẫu
            query = "select LOAIDICHVU.TENDV, DICHVU.NGBATDAUDV, DICHVU.NGKETTHUCDV, LOAIDICHVU.DONGIA, DICHVU.SOLUONGDV, DICHVU.TONGTIENDV from DICHVU inner join LOAIDICHVU on DICHVU.MALDV = LOAIDICHVU.MALDV and DICHVU.MATP = 'TP1';";
            DataSet ds = fn.getData(query);
            DataTable dt = ds.Tables[0];

            return dt;
        }

        private void ExportToExcel(DataTable dataTable, string filePath)
        {

            // Sử dụng EPPlus để tạo file Excel
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Dòng 1: Tiêu đề
                worksheet.Cells["A1"].Value = "BẢNG KÊ THANH TOÁN CHI TIẾT";
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

                
                //Định dạng ngày tháng
                worksheet.Cells["C9:D50"].Style.Numberformat.Format = "dd/MM/yyyy HH:mm:ss";


                //Dòng 9
                //Tạo hàng tiền phòng

                worksheet.Cells["A9"].Value = 1;
                worksheet.Cells["B9"].Value = "Tiền phòng";
                worksheet.Cells["C9"].Value = ngayBD;
                worksheet.Cells["D9"].Value = ngayKT;
                int numberdate = int.Parse(ngayKT.Substring(0, 2)) - int.Parse(ngayBD.Substring(0, 2));
                int dongia = DonGia();
                int price = dongia * numberdate;
                worksheet.Cells["E9"].Value = dongia;
                worksheet.Cells["F9"].Value = numberdate;
                worksheet.Cells["G9"].Value = price;

                

                //Dòng 10
                //Các loại DICHVU
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    worksheet.Cells[i + 10, 1].Value = i + 2;
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 10, j + 2].Value = dataTable.Rows[i][j];
                    }
                }
                

                //Tổng cộng
                int size = dataTable.Rows.Count;
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


                // Định dạng bảng
                worksheet.Cells["A9:G50"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(1).Width = 5;
                worksheet.Column(2).Width = 18;
                worksheet.Column(3).Width = 20;
                worksheet.Column(4).Width = 20;
                worksheet.Column(5).Width = 10;
                worksheet.Column(6).Width = 10;

                
                // Lưu file Excel
                FileInfo file = new FileInfo(filePath);
                excelPackage.SaveAs(file);
            }

            // Hiển thị thông báo sau khi xuất thành công
            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
