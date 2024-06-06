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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //void setComboBox(String query, ComboBox combo)
        //{
        //    SqlDataReader sdr = fn.getForCombo(query);
        //    while (sdr.Read())
        //    {
        //        for (int i = 0; i < sdr.FieldCount; i++)
        //        {
        //            Debug.WriteLine("===TOT1 + " + sdr.GetString(i) + "");
        //            combo.Items.Add(sdr.GetString(i));
        //        }
        //    }
        //    sdr.Close();
        //}

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunna2textbox_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
        }

        private void txtCustomerAddr_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
        }

        private void txtCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }

        private void txtCustomerCMND_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRentRoom_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text != "" && txtCusCMND.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtCheckOut.Text != "" && txtCheckIn.Text != "")
            {
                String cusName = txtCusName.Text;
                bool cusTypeCheck = txtCusType.Checked;
                Int64 cmnd = Int64.Parse(txtCusCMND.Text);
                String addr = txtCusAddr.Text;
                String phonenumber = txtPhoneNumber.Text;
                String Sex = "Khác";
                String cusType = "";
                String Email = txtEmail.Text;
                String roomType = txtRoomType.Text;
                String start = txtCheckIn.Text;
                String end = txtCheckOut.Text;
                double price = 0;
                double totalPrice = 0;


                if ( txtMale.Checked == true )
                {
                    Sex = "Nam";
                }
                if( txtFemale.Checked == true )
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
                if (cusTypeCheck == true)
                {
                    cusType = "Khách nước ngoài";
                    totalPrice = price * 2;
                }
                else
                {
                    cusType = "Khách nội địa";
                    totalPrice = price;
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

                    query = "insert into THUEPHONG (MATP, MAKH, MAPH, NGTHUE, NGTRAPHONG) values ('TP" + maTP + "','KH" + maKH + "','" + RoomNo + "','" + start + "','" + end + "')";
                    fn.setData(query, null);
        
                    query = "insert into HOADON (MAHD, NGLAP, TONGTIEN, MATP) values ('HD" + maHD + "','" + start + "', '" + totalPrice + "', 'TP" + maTP + "')";
                    fn.setData(query, "Đã lưu phiếu thuê phòng thành công");

                    query = "update PHONG set TRANGTHAI = N'Không trống' where MAPH = '" + RoomNo + "';";
                    fn.setData(query, null);
                         
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Phòng không thể chọn!", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };
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