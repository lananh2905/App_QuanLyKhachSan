using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code.All_user_control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtLau.Text != "" && txtRoomStatus.Text != "" && txtRoomType.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String status = txtRoomStatus.Text;
                Int64 lau = Int64.Parse(txtLau.Text);
                String type = txtRoomType.Text;

                query = "insert into PHONG (MAPH, TRANGTHAI, LAU, MALPH) values ('" + roomno + "','" + status + "', " + lau + ", '" + type + "')";
                fn.setData(query, "Đã Thêm Phòng");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomStatus.SelectedIndex = -1;
            txtLau.SelectedIndex = -1;
            txtRoomType.Clear();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from PHONG";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
