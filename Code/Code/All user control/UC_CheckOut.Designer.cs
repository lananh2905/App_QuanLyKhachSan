namespace Code.All_user_control
{
    partial class UC_CheckOut
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            txtCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BorderRadius = 18;
            btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnCheckOut.BorderThickness = 1;
            btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnCheckOut.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnCheckOut.CheckedState.ForeColor = Color.White;
            btnCheckOut.CustomizableEdges = customizableEdges1;
            btnCheckOut.DisabledState.BorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckOut.FillColor = Color.White;
            btnCheckOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.Black;
            btnCheckOut.Location = new Point(1248, 572);
            btnCheckOut.Margin = new Padding(2);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCheckOut.Size = new Size(167, 44);
            btnCheckOut.TabIndex = 22;
            btnCheckOut.Text = "Thanh Toán";
            btnCheckOut.Click += btnCheckOut_Click_1;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.Checked = true;
            txtCheckOutDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            txtCheckOutDate.CustomizableEdges = customizableEdges3;
            txtCheckOutDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCheckOutDate.Format = DateTimePickerFormat.Custom;
            txtCheckOutDate.Location = new Point(890, 572);
            txtCheckOutDate.Margin = new Padding(2);
            txtCheckOutDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            txtCheckOutDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtCheckOutDate.Size = new Size(240, 44);
            txtCheckOutDate.TabIndex = 21;
            txtCheckOutDate.Value = new DateTime(2024, 4, 10, 16, 39, 0, 193);
            txtCheckOutDate.ValueChanged += txtCheckOutDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(890, 524);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 28);
            label5.TabIndex = 20;
            label5.Text = "Ngày Thanh Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(88, 524);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 19;
            label4.Text = "Tên";
            // 
            // txtRoom
            // 
            txtRoom.CustomizableEdges = customizableEdges5;
            txtRoom.DefaultText = "";
            txtRoom.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtRoom.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtRoom.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtRoom.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtRoom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoom.ForeColor = Color.Black;
            txtRoom.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoom.Location = new Point(504, 572);
            txtRoom.Margin = new Padding(3, 4, 3, 4);
            txtRoom.Name = "txtRoom";
            txtRoom.PasswordChar = '\0';
            txtRoom.PlaceholderForeColor = Color.DimGray;
            txtRoom.PlaceholderText = "Nhập Số Phòng";
            txtRoom.SelectedText = "";
            txtRoom.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtRoom.Size = new Size(322, 44);
            txtRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtRoom.TabIndex = 18;
            txtRoom.TextChanged += txtRoom_TextChanged;
            // 
            // txtCName
            // 
            txtCName.CustomizableEdges = customizableEdges7;
            txtCName.DefaultText = "";
            txtCName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCName.ForeColor = Color.Black;
            txtCName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCName.Location = new Point(88, 572);
            txtCName.Margin = new Padding(3, 4, 3, 4);
            txtCName.Name = "txtCName";
            txtCName.PasswordChar = '\0';
            txtCName.PlaceholderForeColor = Color.DimGray;
            txtCName.PlaceholderText = "Nhập Tên Khách Hàng";
            txtCName.ReadOnly = true;
            txtCName.SelectedText = "";
            txtCName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCName.Size = new Size(351, 44);
            txtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCName.TabIndex = 17;
            txtCName.TextChanged += txtCName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(504, 524);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 16;
            label3.Text = "Số Phòng";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(72, 195);
            guna2DataGridView1.Margin = new Padding(2);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 62;
            guna2DataGridView1.RowTemplate.Height = 33;
            guna2DataGridView1.Size = new Size(1386, 269);
            guna2DataGridView1.TabIndex = 15;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 33;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick_1;
            // 
            // txtName
            // 
            txtName.CustomizableEdges = customizableEdges9;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(536, 119);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderForeColor = Color.DimGray;
            txtName.PlaceholderText = "Nhập Tên Khách Hàng";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtName.Size = new Size(351, 44);
            txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtName.TabIndex = 14;
            txtName.TextChanged += txtName_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(536, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 13;
            label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 37);
            label1.TabIndex = 12;
            label1.Text = "Thanh Toán";
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnCheckOut;
            // 
            // UC_CheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheckOut);
            Controls.Add(txtCheckOutDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtRoom);
            Controls.Add(txtCName);
            Controls.Add(label3);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UC_CheckOut";
            Size = new Size(1800, 850);
            Load += UC_CheckOut__Load;
            Leave += UC_CheckOut_Leave_1;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOutDate;
        private Label label5;
        private Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
