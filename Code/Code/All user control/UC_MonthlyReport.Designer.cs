﻿namespace Code.All_user_control
{
    partial class UC_MonthlyReport
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
            label1 = new Label();
            label5 = new Label();
            txtMonthlyReportDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label2 = new Label();
            txtRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            btnMonthlyReport = new Guna.UI2.WinForms.Guna2Button();
            btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 37);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 13;
            label1.Text = "Báo cáo doanh thu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(60, 110);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 21;
            label5.Text = "Tháng báo cáo";
            label5.Click += label5_Click;
            // 
            // txtMonthlyReportDate
            // 
            txtMonthlyReportDate.Checked = true;
            txtMonthlyReportDate.CustomizableEdges = customizableEdges1;
            txtMonthlyReportDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonthlyReportDate.Format = DateTimePickerFormat.Short;
            txtMonthlyReportDate.Location = new Point(60, 172);
            txtMonthlyReportDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            txtMonthlyReportDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            txtMonthlyReportDate.Name = "txtMonthlyReportDate";
            txtMonthlyReportDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMonthlyReportDate.Size = new Size(341, 48);
            txtMonthlyReportDate.TabIndex = 22;
            txtMonthlyReportDate.Value = new DateTime(2024, 4, 15, 12, 14, 0, 370);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 264);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 23;
            label2.Text = "Loại phòng";
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.Transparent;
            txtRoomType.CustomizableEdges = customizableEdges3;
            txtRoomType.DrawMode = DrawMode.OwnerDrawFixed;
            txtRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRoomType.FocusedColor = Color.FromArgb(94, 148, 255);
            txtRoomType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtRoomType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomType.ForeColor = Color.Black;
            txtRoomType.ItemHeight = 30;
            txtRoomType.Items.AddRange(new object[] { "A", "B", "C" });
            txtRoomType.Location = new Point(60, 315);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtRoomType.Size = new Size(341, 36);
            txtRoomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtRoomType.TabIndex = 24;
            // 
            // btnMonthlyReport
            // 
            btnMonthlyReport.BorderRadius = 18;
            btnMonthlyReport.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnMonthlyReport.BorderThickness = 1;
            btnMonthlyReport.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnMonthlyReport.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnMonthlyReport.CheckedState.ForeColor = Color.White;
            btnMonthlyReport.CustomizableEdges = customizableEdges5;
            btnMonthlyReport.DisabledState.BorderColor = Color.DarkGray;
            btnMonthlyReport.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMonthlyReport.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMonthlyReport.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMonthlyReport.FillColor = Color.White;
            btnMonthlyReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnMonthlyReport.ForeColor = Color.Black;
            btnMonthlyReport.Location = new Point(60, 404);
            btnMonthlyReport.Name = "btnMonthlyReport";
            btnMonthlyReport.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMonthlyReport.Size = new Size(225, 56);
            btnMonthlyReport.TabIndex = 25;
            btnMonthlyReport.Text = "Báo cáo";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BorderRadius = 18;
            btnXuatExcel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            btnXuatExcel.BorderThickness = 1;
            btnXuatExcel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btnXuatExcel.CheckedState.FillColor = Color.FromArgb(0, 118, 221);
            btnXuatExcel.CheckedState.ForeColor = Color.White;
            btnXuatExcel.CustomizableEdges = customizableEdges7;
            btnXuatExcel.DisabledState.BorderColor = Color.DarkGray;
            btnXuatExcel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXuatExcel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXuatExcel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXuatExcel.FillColor = Color.White;
            btnXuatExcel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatExcel.ForeColor = Color.Black;
            btnXuatExcel.Location = new Point(60, 515);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnXuatExcel.Size = new Size(225, 56);
            btnXuatExcel.TabIndex = 26;
            btnXuatExcel.Text = "Xuất ra Excel";
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
            guna2DataGridView1.Location = new Point(499, 136);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 29;
            guna2DataGridView1.Size = new Size(902, 481);
            guna2DataGridView1.TabIndex = 27;
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
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_MonthlyReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2DataGridView1);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnMonthlyReport);
            Controls.Add(txtRoomType);
            Controls.Add(label2);
            Controls.Add(txtMonthlyReportDate);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "UC_MonthlyReport";
            Size = new Size(1506, 682);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtMonthlyReportDate;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtRoomType;
        private Guna.UI2.WinForms.Guna2Button btnMonthlyReport;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}