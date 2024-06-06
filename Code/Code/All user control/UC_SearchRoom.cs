using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code
{
    public partial class UC_SearchRoom : UserControl
    {
        function fn = new function();
        string query;

        public UC_SearchRoom()
        {
            InitializeComponent();
        }

        private void UC_SearchRoom_Load(object sender, EventArgs e)
        {
            query = "select PHONG.MAPH as [Số phòng], PHONG.TRANGTHAI as [Trạng thái], PHONG.LAU as [Lầu], LOAIPHONG.GHICHU as [Loại Phòng], LOAIPHONG.GIA as [Giá] from PHONG inner join LOAIPHONG on PHONG.MALPH = LOAIPHONG.MALPH;";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type, status;


            if( txtType.Text != "" && txtStatus.Text != "")
            {
                type = txtType.Text;
                status = txtStatus.Text;

                if (type == "Tất cả phòng")
                {
                    if( status == "Tất cả phòng")
                    {
                        query = "select PHONG.MAPH as [Số phòng], PHONG.TRANGTHAI as [Trạng thái], PHONG.LAU as [Lầu], LOAIPHONG.GHICHU as [Loại Phòng], LOAIPHONG.GIA as [Giá] from PHONG inner join LOAIPHONG on PHONG.MALPH = LOAIPHONG.MALPH;";
                    }
                    else
                    {
                       query = "select PHONG.MAPH as [Số phòng], PHONG.TRANGTHAI as [Trạng thái], PHONG.LAU as [Lầu], LOAIPHONG.GHICHU as [Loại Phòng], LOAIPHONG.GIA as [Giá] from PHONG inner join LOAIPHONG on PHONG.MALPH = LOAIPHONG.MALPH and PHONG.TRANGTHAI = N'" + status + "';";
                    }
                }
                else
                {
                    if( status == "Tất cả phòng")
                    {
                        query = "select PHONG.MAPH as [Số phòng], PHONG.TRANGTHAI as [Trạng thái], PHONG.LAU as [Lầu], LOAIPHONG.GHICHU as [Loại Phòng], LOAIPHONG.GIA as [Giá] from PHONG inner join LOAIPHONG on PHONG.MALPH = LOAIPHONG.MALPH and LOAIPHONG.GHICHU = N'" + type + "';";
                    }
                    else
                    {
                        query = "select PHONG.MAPH as [Số phòng], PHONG.TRANGTHAI as [Trạng thái], PHONG.LAU as [Lầu], LOAIPHONG.GHICHU as [Loại Phòng], LOAIPHONG.GIA as [Giá] from PHONG inner join LOAIPHONG on PHONG.MALPH = LOAIPHONG.MALPH and LOAIPHONG.GHICHU = N'" + type + "' and PHONG.TRANGTHAI = N'" + status + "';";
                    }
                }

                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
                clear();

                MessageBox.Show("Tìm kiếm thành công", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void clear()
        {
            txtType.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
        }
    }
}
