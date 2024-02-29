namespace Account.Presentation.UserControls
{
    partial class SettlemantUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            GridData = new DataGridView();
            AddBtn = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            MonthCombo = new ComboBox();
            YearCombo = new ComboBox();
            AccountCombo = new ComboBox();
            CustomerCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GridData
            // 
            GridData.AllowDrop = true;
            GridData.AllowUserToAddRows = false;
            GridData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            GridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            GridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridData.BackgroundColor = Color.FromArgb(39, 40, 41);
            GridData.BorderStyle = BorderStyle.None;
            GridData.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            GridData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle2.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            GridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.Cursor = Cursors.PanWest;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle3.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            GridData.DefaultCellStyle = dataGridViewCellStyle3;
            GridData.EditMode = DataGridViewEditMode.EditProgrammatically;
            GridData.GridColor = Color.FromArgb(224, 224, 224);
            GridData.Location = new Point(4, 60);
            GridData.Name = "GridData";
            GridData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle4.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            GridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            GridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.MidnightBlue;
            GridData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            GridData.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            GridData.RowTemplate.ReadOnly = true;
            GridData.RowTemplate.Resizable = DataGridViewTriState.True;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridData.Size = new Size(1135, 629);
            GridData.TabIndex = 17;
            GridData.VirtualMode = true;
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            AddBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            AddBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(0, 0);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(225, 32);
            AddBtn.TabIndex = 20;
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 0);
            label1.Name = "label1";
            label1.Size = new Size(915, 32);
            label1.TabIndex = 19;
            label1.Text = "واریزی های ماهانه";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(MonthCombo);
            groupBox2.Controls.Add(YearCombo);
            groupBox2.Controls.Add(AccountCombo);
            groupBox2.Controls.Add(CustomerCombo);
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(PageLbl);
            groupBox2.Controls.Add(NextBtn);
            groupBox2.Controls.Add(PrevBtn);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTxt);
            groupBox2.Location = new Point(2, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1143, 731);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // MonthCombo
            // 
            MonthCombo.BackColor = Color.FromArgb(240, 236, 229);
            MonthCombo.Cursor = Cursors.Hand;
            MonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthCombo.FormattingEnabled = true;
            MonthCombo.Location = new Point(302, 20);
            MonthCombo.Name = "MonthCombo";
            MonthCombo.RightToLeft = RightToLeft.Yes;
            MonthCombo.Size = new Size(134, 33);
            MonthCombo.TabIndex = 21;
            // 
            // YearCombo
            // 
            YearCombo.BackColor = Color.FromArgb(240, 236, 229);
            YearCombo.Cursor = Cursors.Hand;
            YearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            YearCombo.FormattingEnabled = true;
            YearCombo.Location = new Point(442, 21);
            YearCombo.Name = "YearCombo";
            YearCombo.RightToLeft = RightToLeft.Yes;
            YearCombo.Size = new Size(136, 33);
            YearCombo.TabIndex = 20;
            // 
            // AccountCombo
            // 
            AccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            AccountCombo.Cursor = Cursors.Hand;
            AccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountCombo.FormattingEnabled = true;
            AccountCombo.Location = new Point(584, 20);
            AccountCombo.Name = "AccountCombo";
            AccountCombo.RightToLeft = RightToLeft.Yes;
            AccountCombo.Size = new Size(386, 33);
            AccountCombo.TabIndex = 19;
            // 
            // CustomerCombo
            // 
            CustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(976, 21);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(159, 33);
            CustomerCombo.TabIndex = 18;
            CustomerCombo.SelectedIndexChanged += CustomerCombo_SelectedIndexChanged;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(196, 694);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(751, 32);
            PageLbl.TabIndex = 11;
            PageLbl.Text = "ساعت";
            PageLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextBtn
            // 
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            NextBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            NextBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            NextBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(3, 695);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(56, 32);
            NextBtn.TabIndex = 3;
            NextBtn.Text = "بعدی";
            NextBtn.UseVisualStyleBackColor = true;
            // 
            // PrevBtn
            // 
            PrevBtn.Cursor = Cursors.Hand;
            PrevBtn.FlatAppearance.BorderColor = Color.FromArgb(49, 48, 77);
            PrevBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            PrevBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            PrevBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            PrevBtn.FlatStyle = FlatStyle.Flat;
            PrevBtn.ForeColor = Color.White;
            PrevBtn.Location = new Point(1084, 695);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(56, 32);
            PrevBtn.TabIndex = 2;
            PrevBtn.Text = "قبلی";
            PrevBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatAppearance.BorderColor = Color.White;
            SearchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(6, 20);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 32);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            SearchTxt.BackColor = Color.FromArgb(240, 236, 229);
            SearchTxt.Location = new Point(90, 21);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "جستجو کنید ...";
            SearchTxt.RightToLeft = RightToLeft.Yes;
            SearchTxt.Size = new Size(206, 32);
            SearchTxt.TabIndex = 0;
            // 
            // SettlemantUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SettlemantUC";
            Size = new Size(1146, 759);
            Load += SettlemantUC_Load;
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridData;
        private Button AddBtn;
        private Label label1;
        private GroupBox groupBox2;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private ComboBox CustomerCombo;
        private ComboBox MonthCombo;
        private ComboBox YearCombo;
        private ComboBox AccountCombo;
    }
}
