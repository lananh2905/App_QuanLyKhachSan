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
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut__Load(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.GIOITINH, KHACHHANG.CMND, KHACHHANG.SDT, KHACHHANG.EMAIL, KHACHHANG.DIACHI, KHACHHANG.LOAIKH, LOAIPHONG.TENLPH, LOAIPHONG.GIA FROM ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) INNER JOIN LOAIPHONG ON LOAIPHONG.MALPH=PHONG.MALPH where PHONG.TRANGTHAI=N'không trống' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        /*
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.GIOITINH, KHACHHANG.CMND, KHACHHANG.SDT, KHACHHANG.EMAIL, KHACHHANG.DIACHI, KHACHHANG.LOAIKH, LOAIPHONG.TENLPH, LOAIPHONG.GIA FROM ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) INNER JOIN LOAIPHONG ON LOAIPHONG.MALPH=PHONG.MALPH where HOTEN like N'" + txtName.Text + "%' and PHONG.TRANGTHAI=N'không trống' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        */
        string id;
        /*
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        */
        public void clearAll()
        {
            txtCName.Clear();
            txtRoom.Clear();
            txtName.Clear();
            txtCheckOutDate.ResetText();
        }
        /*
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update  PHONG set TRANGTHAI=N' trống'";
                    fn.setData(query, "Thanh toán thành công!");
                    UC_CheckOut__Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        
        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        */
        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.GIOITINH, KHACHHANG.CMND, KHACHHANG.SDT, KHACHHANG.EMAIL, KHACHHANG.DIACHI, KHACHHANG.LOAIKH, LOAIPHONG.TENLPH, LOAIPHONG.GIA FROM ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) INNER JOIN LOAIPHONG ON LOAIPHONG.MALPH=PHONG.MALPH where HOTEN like N'" + txtName.Text + "%' and PHONG.TRANGTHAI=N'không trống' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {
            query = "select KHACHHANG.MAKH, KHACHHANG.HOTEN, KHACHHANG.GIOITINH, KHACHHANG.CMND, KHACHHANG.SDT, KHACHHANG.EMAIL, KHACHHANG.DIACHI, KHACHHANG.LOAIKH, LOAIPHONG.TENLPH, LOAIPHONG.GIA FROM ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) INNER JOIN LOAIPHONG ON LOAIPHONG.MALPH=PHONG.MALPH where HOTEN like N'" + txtName.Text + "%' and PHONG.TRANGTHAI=N'không trống' ";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
        //((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) INNER JOIN LOAIPHONG ON LOAIPHONG.MALPH=PHONG.MALPH where HOTEN like N'" + txtName.Text + "%'
        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    String cname = txtCName.Text;

                    // set trạng thái phòng 'trống'
                    query = "update  PHONG set TRANGTHAI=N'trống' where MAPH = (select PHONG.MAPH from ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) where KHACHHANG.HOTEN = N'" + cname + "' and THUEPHONG.TRANGTHAI = N'Đang thuê')";
                    fn.setData(query, null);

                    // cập nhật bảng hoá đơn
                    // cập nhật Ngày lập hoá đơn
                    query = "update HOADON set NGLAP=' + cdate + ' where MATP = (select THUEPHONG.MATP from ((KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) where KHACHHANG.HOTEN = '" + cname + "' and THUEPHONG.TRANGTHAI =  N'Đang thuê')";
                    fn.setData(query, null);

                    // cập nhật tổng tiền
                    //query = "select sum(TONGTIENDV) as tongdv from DICHVU were ";


                    //Cập nhật trạng thái thuê phòng
                    query = "update THUEPHONG set TRANGTHAI = N'Đã thanh toán' where TRANGTHAI =  N'Đang thuê' and MATP = (select THUEPHONG.MATP from ( (KHACHHANG INNER JOIN THUEPHONG ON KHACHHANG.MAKH=THUEPHONG.MAKH) INNER JOIN PHONG ON PHONG.MAPH=THUEPHONG.MAPH) where KHACHHANG.HOTEN = N'" + cname + "')";
                    fn.setData(query, null);

                    UC_CheckOut__Load(this, null);
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void UC_CheckOut_Leave_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtCheckOutDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
