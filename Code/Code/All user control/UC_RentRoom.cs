using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code.All_user_control
{
    public partial class UC_RentRoom : UserControl
    {
        function fn = new function();
        int maKH = 1;
        int maTP = 1;
        int maHD = 1;
        string query;

        public UC_RentRoom()
        {
            InitializeComponent();
        }


        public int CalNumberDate()
        {
            int yearStart = txtCheckIn.Value.Year;
            int monthStart = txtCheckIn.Value.Month;
            int dayStart = txtCheckIn.Value.Day;
            int yearEnd = txtCheckOut.Value.Year;
            int monthEnd = txtCheckOut.Value.Month;
            int dayEnd = txtCheckOut.Value.Day;

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

        private void btnRentRoom_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "" && txtCusCMND.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtCheckOut.Text != "" && txtCheckIn.Text != "" && txtNumberCus.Text != "")
            {
                if(int.Parse(txtNumberCus.Text) > 3 || int.Parse(txtNumberCus.Text) < 1)
                {
                    MessageBox.Show("Số lượng khách hàng không phù hợp. Vui lập nhập lại số lượng khách hàng", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String cusName = txtCusName.Text;
                    bool cusTypeCheck = txtCusType.Checked;
                    Int64 cmnd = Int64.Parse(txtCusCMND.Text);
                    String addr;
                    String phonenumber;
                    String Sex = "Khác";
                    String cusType = "";
                    String Email;
                    String roomType = txtRoomType.Text;
                    String start = txtCheckIn.Text;
                    String end = txtCheckOut.Text;
                    double price = 0;
                    double totalPrice = 0;
                    int numberCus = int.Parse(txtNumberCus.Text);

                    if (txtCusAddr.Text != "")
                    {
                        addr = txtCusAddr.Text;
                    }
                    else
                    {
                        addr = "null";
                    }

                    if (txtPhoneNumber.Text != "")
                    {
                        phonenumber = txtPhoneNumber.Text;
                    }
                    else
                    {
                        phonenumber = "null";
                    }

                    if (txtEmail.Text != "")
                    {
                        Email = txtEmail.Text;
                    }
                    else
                    {
                        Email = "null";
                    }


                    if (txtMale.Checked == true)
                    {
                        Sex = "Nam";
                    }
                    if (txtFemale.Checked == true)
                    {
                        Sex = "Nữ";
                    }

                    if (roomType == "Phòng đơn")
                    {
                        price = 150000;
                    }
                    else if (roomType == "Phòng đôi")
                    {
                        price = 170000;
                    }
                    else
                    {
                        price = 200000;
                    }

                    int numberday = CalNumberDate();


                    if (cusTypeCheck == true)
                    {
                        if (numberCus == 3)
                        {
                            cusType = "Khách nước ngoài";
                            totalPrice = price * 1.5 * numberday * 1.25;
                        }
                        else
                        {
                            cusType = "Khách nước ngoài";
                            totalPrice = price * 1.5 * numberday;
                        }

                    }
                    else
                    {
                        if (numberCus == 3)
                        {
                            cusType = "Khách nội địa";
                            totalPrice = price * numberday * 1.25;
                        }
                        else
                        {
                            cusType = "Khách nội địa";
                            totalPrice = price * numberday;
                        }

                    }
                    String RoomNo = "P" + txtRoomNo.Text;
                    String queryRoomNoItems = "SELECT MAPH FROM PHONG, LOAIPHONG WHERE PHONG.MALPH = LOAIPHONG.MALPH AND PHONG.TRANGTHAI = N'Trống' AND LOAIPHONG.GHICHU = N'" + roomType + "'";
                    bool result = CheckIfRoomExists(queryRoomNoItems, RoomNo);
                    if (result == true)
                    {
                        maKH = increaseMAKH();
                        maTP = increaseMATP();
                        maHD = increaseMAHD();

                        query = "insert into KHACHHANG (MAKH, HOTEN, GIOITINH, CMND, SDT, DIACHI, LOAIKH, EMAIL) values ('KH" + maKH + "', N'" + cusName + "', N'" + Sex + "','" + cmnd + "','" + phonenumber + "',N'" + addr + "',N'" + cusType + "','" + Email + "')";
                        fn.setData(query, null);

                        query = "insert into THUEPHONG (MATP, MAKH, MAPH, NGTHUE, NGTRAPHONG, TRANGTHAI, SOLUONGKH) values ('TP" + maTP + "','KH" + maKH + "','" + RoomNo + "', CONVERT(DATETIME, '" + start + "', 103), CONVERT(DATETIME, '" + end + "', 103), N'Chưa thanh toán', " + numberCus + ")";
                        fn.setData(query, null);

                        query = "insert into HOADON (MAHD, TONGTIEN, MATP) values ('HD" + maHD + "', '" + totalPrice + "', 'TP" + maTP + "')";
                        fn.setData(query, "Đã lưu phiếu thuê phòng thành công");

                        query = "update PHONG set TRANGTHAI = N'Không trống' where MAPH = '" + RoomNo + "';";
                        fn.setData(query, null);

                        clearAll();
                    }
                    else
                    {
                        MessageBox.Show("Phòng không thể chọn!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }      
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public int increaseMAKH()
        {
            int MAKH = 1;
            query = "SELECT TOP 1 MAKH " +
                    "FROM KHACHHANG " +
                    "ORDER BY CAST(SUBSTRING(MAKH, 3, LEN(MAKH) - 2) AS INT) DESC";

            DataSet ds = fn.getData(query);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item.ToString() != "")
                        {
                            string Str = item.ToString();
                            string SubStr = Str.Substring(2);
                            MAKH = int.Parse(SubStr) + 1;
                        }
                    }
                }
            }


            return MAKH;
        }

        public int increaseMATP()
        {
            int MATP = 1;
            query = "SELECT TOP 1 MATP " +
                    "FROM THUEPHONG " +
                    "ORDER BY CAST(SUBSTRING(MATP, 3, LEN(MATP) - 2) AS INT) DESC";

            DataSet ds = fn.getData(query);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item.ToString() != "")
                        {
                            string Str = item.ToString();
                            string SubStr = Str.Substring(2);
                            MATP = int.Parse(SubStr) + 1;
                        }
                    }
                }
            }


            return MATP;
        }

        public int increaseMAHD()
        {
            int MAHD = 1;
            query = "SELECT TOP 1 MAHD " +
                    "FROM HOADON " +
                    "ORDER BY CAST(SUBSTRING(MAHD, 3, LEN(MAHD) - 2) AS INT) DESC";

            DataSet ds = fn.getData(query);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item.ToString() != "")
                        {
                            string Str = item.ToString();
                            string SubStr = Str.Substring(2);
                            MAHD = int.Parse(SubStr) + 1;
                        }
                    }
                }
            }


            return MAHD;
        }

        public void clearAll()
        {
            txtCusName.Clear();
            txtCusType.Checked = false;
            txtCusCMND.Clear();
            txtCusAddr.Clear();
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Clear();
            txtMale.Checked = false;
            txtFemale.Checked = false;
            txtOther.Checked = false;
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtNumberCus.Clear();
        }

        public bool CheckIfRoomExists(string query, string roomText)
        {
            DataSet ds = fn.getData(query);
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        if (item.ToString() == roomText)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtRoomNo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_RentRoom_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}