using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Code.All_user_control
{
    public partial class UC_Service : UserControl
    {
        function fn = new function();
        string query;
        public UC_Service()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtStart.Text != "" && txtFinish.Text != "" && txtNumber.Text != "" && txtService.Text != "")
            {
                String name = txtName.Text;
                String service = txtService.Text;
                Int64 number = Int64.Parse(txtNumber.Text);
                String start = txtStart.Text;
                String end = txtFinish.Text;
                double price = 0;
                string serviceno = "";

                if (txtService.Text == "Giặt ủi quần áo")
                {
                    serviceno = "LDV1";
                    if (number <= 2)
                    {
                        price = 40000;
                    }
                    else
                    {
                        price = 65000;
                    }
                }
                if (txtService.Text == "Cho thuê xe máy")
                {
                    serviceno = "LDV2";
                    int daystart = int.Parse(start.Substring(0,2));
                    int dayend = int.Parse(end.Substring(0,2));
                    int numberday = dayend - daystart + 1;
                    price = number * 150000 * numberday;
                }
                if (txtService.Text == "Thu đổi ngoại tệ")
                {
                    serviceno = "LDV3";
                    price = number * 1000000;
                    price = price * 1.02;
                }
                if (txtService.Text == "Đón khách")
                {
                    serviceno = "LDV4";
                    if (number <= 5)
                    {
                        price = 0;
                    }
                    else
                    {
                        price = (number - 5) * 10000;
                    }
                }
                if (txtService.Text == "Buffet sáng")
                {
                    serviceno = "LDV5";
                    price = number * 50000;
                }

                string MATP = Find_MATP(name);

                query = "insert into DICHVU (MALDV, MATP, NGBATDAUDV, NGKETTHUCDV, SOLUONGDV, TONGTIENDV) values ('" + serviceno + "','" + MATP + "', '" + start + "', '" + end + "', " + number + ", " + price + ")";
                fn.setData(query, "Đã thuê dịch vụ thành công");

                UC_Service_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public string Find_MATP(string name)
        {
            string MATP = "";
            query = "select THUEPHONG.MATP " +
                    "from THUEPHONG " +
                    "inner join KHACHHANG " +
                    "on THUEPHONG.MAKH = KHACHHANG.MAKH and KHACHHANG.HOTEN = 'a';";
            DataSet ds = fn.getData(query);
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        MATP = item.ToString();
                    }
                }
            }

            return MATP;
        }
        
        public void clearAll()
        {
            txtName.Clear();
            txtService.SelectedIndex = -1;
            txtNumber.Clear();
        }

        private void UC_Service_Load(object sender, EventArgs e)
        {
            query = "select LOAIDICHVU.TENDV as [Tên loại DV],  KHACHHANG.HOTEN as [Họ tên KH], NGBATDAUDV as [Ngày bắt đầu], NGKETTHUCDV as [Ngày kết thúc], SOLUONGDV as [ Số lượng ], TONGTIENDV as [Tổng tiền] from DICHVU inner join LOAIDICHVU on DICHVU.MALDV = LOAIDICHVU.MALDV inner join THUEPHONG on THUEPHONG.MATP = DICHVU.MATP inner join KHACHHANG on KHACHHANG.MAKH = THUEPHONG.MAKH;";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            // Tính tỷ lệ phần trăm chiều rộng cho mỗi cột
            float[] columnWidths = { 15, 15, 20, 20, 10, 20};
            float totalWidth = dataGridView1.Width - dataGridView1.RowHeadersWidth;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = (int)(totalWidth * (columnWidths[i] / 100));
            }
        }
    }
}
