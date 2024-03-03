namespace Account.Presentation.UserControls
{
    partial class CashMoneyUC
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            label1 = new Label();
            AddBtn = new Button();
            groupBox2 = new GroupBox();
            GridData = new DataGridView();
            CustomerCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            YearCombo = new ComboBox();
            MonthCombo = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 1);
            label1.Name = "label1";
            label1.Size = new Size(909, 32);
            label1.TabIndex = 16;
            label1.Text = "تراکنش های نقدی تمام حساب ها";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            AddBtn.Location = new Point(3, 1);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(225, 32);
            AddBtn.TabIndex = 17;
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(MonthCombo);
            groupBox2.Controls.Add(YearCombo);
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(CustomerCombo);
            groupBox2.Controls.Add(PageLbl);
            groupBox2.Controls.Add(NextBtn);
            groupBox2.Controls.Add(PrevBtn);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTxt);
            groupBox2.Location = new Point(2, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1143, 731);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // GridData
            // 
            GridData.AllowDrop = true;
            GridData.AllowUserToAddRows = false;
            GridData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.Maroon;
            GridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            GridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridData.BackgroundColor = Color.FromArgb(39, 40, 41);
            GridData.BorderStyle = BorderStyle.None;
            GridData.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            GridData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle12.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            GridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.Cursor = Cursors.PanWest;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle13.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            GridData.DefaultCellStyle = dataGridViewCellStyle13;
            GridData.EditMode = DataGridViewEditMode.EditProgrammatically;
            GridData.GridColor = Color.FromArgb(224, 224, 224);
            GridData.Location = new Point(4, 60);
            GridData.Name = "GridData";
            GridData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle14.Font = new Font("IRANSansWeb", 11.25F);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            GridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            GridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(39, 40, 41);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.MidnightBlue;
            GridData.RowsDefaultCellStyle = dataGridViewCellStyle15;
            GridData.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            GridData.RowTemplate.ReadOnly = true;
            GridData.RowTemplate.Resizable = DataGridViewTriState.True;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridData.Size = new Size(1135, 629);
            GridData.TabIndex = 17;
            GridData.VirtualMode = true;
            // 
            // CustomerCombo
            // 
            CustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(724, 20);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(413, 33);
            CustomerCombo.TabIndex = 16;
            CustomerCombo.SelectedIndexChanged += CustomerCombo_SelectedIndexChanged;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(196, 695);
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
            SearchBtn.Location = new Point(6, 21);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 32);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            SearchTxt.BackColor = Color.FromArgb(240, 236, 229);
            SearchTxt.Location = new Point(87, 21);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "جستجو کنید ...";
            SearchTxt.RightToLeft = RightToLeft.Yes;
            SearchTxt.Size = new Size(262, 32);
            SearchTxt.TabIndex = 0;
            // 
            // YearCombo
            // 
            YearCombo.BackColor = Color.FromArgb(240, 236, 229);
            YearCombo.Cursor = Cursors.Hand;
            YearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            YearCombo.FormattingEnabled = true;
            YearCombo.Location = new Point(553, 20);
            YearCombo.Name = "YearCombo";
            YearCombo.RightToLeft = RightToLeft.Yes;
            YearCombo.Size = new Size(165, 33);
            YearCombo.TabIndex = 18;
            YearCombo.SelectedIndexChanged += YearCombo_SelectedIndexChanged;
            // 
            // MonthCombo
            // 
            MonthCombo.BackColor = Color.FromArgb(240, 236, 229);
            MonthCombo.Cursor = Cursors.Hand;
            MonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthCombo.FormattingEnabled = true;
            MonthCombo.Location = new Point(382, 20);
            MonthCombo.Name = "MonthCombo";
            MonthCombo.RightToLeft = RightToLeft.Yes;
            MonthCombo.Size = new Size(165, 33);
            MonthCombo.TabIndex = 19;
            MonthCombo.SelectedIndexChanged += MonthCombo_SelectedIndexChanged;
            // 
            // CashMoneyUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashMoneyUC";
            Size = new Size(1146, 759);
            Load += CashMoneyUC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private GroupBox groupBox2;
        private DataGridView GridData;
        private ComboBox CustomerCombo;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private ComboBox MonthCombo;
        private ComboBox YearCombo;
    }
}
