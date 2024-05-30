using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (txtCusName.Text != "" && txtCusType.Text != "" && txtCusCMND.Text != "" && txtCusAddr.Text != "" && txtRoomType.Text != "" && txtRoomNo.Text != "" && txtCheckIn.Text != "" && txtCheckOut.Text != "")
            {
                String cusName = txtCusName.Text;
                bool cusTypeCheck = txtCusType.Checked;
                Int64 cmnd = Int64.Parse(txtCusCMND.Text);
                String addr = txtCusAddr.Text;
                String cusType = "";
                String roomType = txtRoomType.Text;
                String start = txtCheckIn.Text;
                String end = txtCheckOut.Text;
                double price = 0;
                double totalPrice = 0;

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
                String RoomNo = txtRoomNo.Text;
                String queryRoomNoItems = "SELECT MAPH FROM PHONG, LOAIPHONG WHERE PHONG.MALPH = LOAIPHONG.MALPH AND PHONG.TRANGTHAI = 'Trong' AND LOAIPHONG.GHICHU = '" + roomType + "'";
                bool result = CheckIfRoomExists(queryRoomNoItems, RoomNo);
                if (result == true)
                {
                    query = "insert into KHACHHANG (MAKH, HOTEN, CMND, DIACHI, LOAIKH) values ('KH" + maKH + "','" + cusName + "','" + cmnd + "','" + addr + "','" + cusType + "')";
                    fn.setData(query, "");
                    maKH += 1;
                    query = "insert into THUEPHONG (MATP, MAKH, MAPH, NGTHUE, NGTRAPHONG) values ('TP" + maTP + "','KH" + maKH + "','PH" + RoomNo + "','" + start + "','" + end + "')";
                    fn.setData(query, "");
                    query = "insert into HOADON (MAHD, NGLAP, TONGTIEN, MATP) values ('HD" + maHD + "','" + start + "', '" + totalPrice + "', 'TP" + maTP + "')";
                    fn.setData(query, "");
                    maTP += 1;
                    maHD += 1;
                    MessageBox.Show("Đã lưu phiếu thuê phòng thành công");

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

        public void clearAll()
        {
            txtCusName.Clear();
            txtCusType.Checked = false;
            txtCusCMND.Clear();
            txtCusAddr.Clear();
            txtRoomType.SelectedIndex = -1;
            txtRoomNo.Clear();
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
    }
}