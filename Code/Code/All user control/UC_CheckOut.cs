using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code.All_user_control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        string id;
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

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
