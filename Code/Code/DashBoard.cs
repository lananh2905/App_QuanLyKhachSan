using Code.All_user_control;
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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnAddRoom.Left + 50;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_RentRoom1.Visible = false;
            uC_MonthlyReport1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void panelMoving_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnCheckOut.Left + 60;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnRoomRental_Click(object sender, EventArgs e)
        {
            panelMoving.Left = btnRoomRental.Left + 60;
            uC_RentRoom1.Visible = true;
            uC_RentRoom1.BringToFront();
        
    }
}
}