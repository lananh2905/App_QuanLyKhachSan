namespace Code
{
    partial class UC_SearchRoom
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtType = new Guna.UI2.WinForms.Guna2ComboBox();
            txtStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(445, 94);
            guna2HtmlLabel1.Margin = new Padding(2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(100, 30);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Loại phòng";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel2.ForeColor = Color.Black;
            guna2HtmlLabel2.Location = new Point(49, 40);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(240, 43);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Tìm kiếm phòng";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            guna2HtmlLabel3.Location = new Point(864, 94);
            guna2HtmlLabel3.Margin = new Padding(2);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(154, 30);
            guna2HtmlLabel3.TabIndex = 4;
            guna2HtmlLabel3.Text = "Trạng thái phòng";
            // 
            // txtType
            // 
            txtType.BackColor = Color.Transparent;
            txtType.CustomizableEdges = customizableEdges11;
            txtType.DrawMode = DrawMode.OwnerDrawFixed;
            txtType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtType.FocusedColor = Color.FromArgb(94, 148, 255);
            txtType.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtType.ForeColor = Color.FromArgb(68, 88, 112);
            txtType.ItemHeight = 30;
            txtType.Items.AddRange(new object[] { "Tất cả phòng", "Phòng đơn", "Phòng đôi", "Phòng gia đình" });
            txtType.Location = new Point(445, 139);
            txtType.Name = "txtType";
            txtType.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtType.Size = new Size(282, 36);
            txtType.TabIndex = 5;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.Transparent;
            txtStatus.CustomizableEdges = customizableEdges9;
            txtStatus.DrawMode = DrawMode.OwnerDrawFixed;
            txtStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            txtStatus.FocusedColor = Color.FromArgb(94, 148, 255);
            txtStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.ForeColor = Color.FromArgb(68, 88, 112);
            txtStatus.ItemHeight = 30;
            txtStatus.Items.AddRange(new object[] { "Tất cả phòng", "Trống", "Không trống" });
            txtStatus.Location = new Point(864, 139);
            txtStatus.Name = "txtStatus";
            txtStatus.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtStatus.Size = new Size(282, 36);
            txtStatus.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            btnSearch.CustomizableEdges = customizableEdges7;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.Gainsboro;
            btnSearch.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1364, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSearch.Size = new Size(225, 56);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "TÌM KIẾM";
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.WhiteSmoke;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.InfoText;
            dataGridView2.Location = new Point(82, 213);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.Size = new Size(1507, 600);
            dataGridView2.TabIndex = 14;
            // 
            // UC_SearchRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(btnSearch);
            Controls.Add(txtStatus);
            Controls.Add(txtType);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            Margin = new Padding(2);
            Name = "UC_SearchRoom";
            Size = new Size(1800, 850);
            Load += UC_SearchRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox txtStatus;
        private Guna.UI2.WinForms.Guna2ComboBox txtType;
        private DataGridView dataGridView2;
    }
}
