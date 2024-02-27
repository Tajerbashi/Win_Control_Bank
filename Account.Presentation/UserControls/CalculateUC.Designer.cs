namespace Account.Presentation.UserControls
{
    partial class CalculateUC
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
            label1 = new Label();
            AddBtn = new Button();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            BlanceSearchBtn = new Button();
            TBlanceTxt = new TextBox();
            FBlanceTxt = new TextBox();
            DateSearchBtn = new Button();
            YMDSearchBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            ToDate = new Atf.UI.DateTimeSelector();
            FromDate = new Atf.UI.DateTimeSelector();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            yearCombo = new ComboBox();
            dayCombo = new ComboBox();
            monthCombo = new ComboBox();
            GridData = new DataGridView();
            CartCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 1);
            label1.Name = "label1";
            label1.Size = new Size(912, 32);
            label1.TabIndex = 16;
            label1.Text = "محاسبات پیشرفته حساب های بانکی";
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
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(CartCombo);
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BlanceSearchBtn);
            panel1.Controls.Add(TBlanceTxt);
            panel1.Controls.Add(FBlanceTxt);
            panel1.Controls.Add(DateSearchBtn);
            panel1.Controls.Add(YMDSearchBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ToDate);
            panel1.Controls.Add(FromDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(yearCombo);
            panel1.Controls.Add(dayCombo);
            panel1.Controls.Add(monthCombo);
            panel1.Location = new Point(6, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(1131, 117);
            panel1.TabIndex = 18;
            // 
            // BlanceSearchBtn
            // 
            BlanceSearchBtn.Cursor = Cursors.Hand;
            BlanceSearchBtn.FlatAppearance.BorderColor = Color.White;
            BlanceSearchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            BlanceSearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            BlanceSearchBtn.FlatStyle = FlatStyle.Flat;
            BlanceSearchBtn.ForeColor = Color.White;
            BlanceSearchBtn.Location = new Point(3, 75);
            BlanceSearchBtn.Name = "BlanceSearchBtn";
            BlanceSearchBtn.Size = new Size(225, 32);
            BlanceSearchBtn.TabIndex = 29;
            BlanceSearchBtn.Text = "تراکنش های بر اساس مبلغ";
            BlanceSearchBtn.UseVisualStyleBackColor = true;
            BlanceSearchBtn.Click += BlanceSearchBtn_Click;
            // 
            // TBlanceTxt
            // 
            TBlanceTxt.BackColor = Color.FromArgb(240, 236, 229);
            TBlanceTxt.Location = new Point(3, 41);
            TBlanceTxt.Name = "TBlanceTxt";
            TBlanceTxt.PlaceholderText = "تا مبلغ تراکنش";
            TBlanceTxt.RightToLeft = RightToLeft.Yes;
            TBlanceTxt.Size = new Size(225, 32);
            TBlanceTxt.TabIndex = 28;
            TBlanceTxt.TextChanged += TBlanceTxt_TextChanged;
            TBlanceTxt.KeyPress += TBlanceTxt_KeyPress;
            // 
            // FBlanceTxt
            // 
            FBlanceTxt.BackColor = Color.FromArgb(240, 236, 229);
            FBlanceTxt.Location = new Point(3, 3);
            FBlanceTxt.Name = "FBlanceTxt";
            FBlanceTxt.PlaceholderText = "از مبلغ تراکنش";
            FBlanceTxt.RightToLeft = RightToLeft.Yes;
            FBlanceTxt.Size = new Size(225, 32);
            FBlanceTxt.TabIndex = 19;
            FBlanceTxt.TextChanged += FBlanceTxt_TextChanged;
            FBlanceTxt.KeyPress += FBlanceTxt_KeyPress;
            // 
            // DateSearchBtn
            // 
            DateSearchBtn.Cursor = Cursors.Hand;
            DateSearchBtn.FlatAppearance.BorderColor = Color.White;
            DateSearchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            DateSearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            DateSearchBtn.FlatStyle = FlatStyle.Flat;
            DateSearchBtn.ForeColor = Color.White;
            DateSearchBtn.Location = new Point(234, 75);
            DateSearchBtn.Name = "DateSearchBtn";
            DateSearchBtn.Size = new Size(376, 32);
            DateSearchBtn.TabIndex = 27;
            DateSearchBtn.Text = "دریافت تراکنش میان دو بازه تعیید شده";
            DateSearchBtn.UseVisualStyleBackColor = true;
            DateSearchBtn.Click += DateSearchBtn_Click;
            // 
            // YMDSearchBtn
            // 
            YMDSearchBtn.Cursor = Cursors.Hand;
            YMDSearchBtn.FlatAppearance.BorderColor = Color.White;
            YMDSearchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            YMDSearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            YMDSearchBtn.FlatStyle = FlatStyle.Flat;
            YMDSearchBtn.ForeColor = Color.White;
            YMDSearchBtn.Location = new Point(616, 75);
            YMDSearchBtn.Name = "YMDSearchBtn";
            YMDSearchBtn.Size = new Size(510, 32);
            YMDSearchBtn.TabIndex = 19;
            YMDSearchBtn.Text = "دریافت تراکنش بر اساس سال ماه روز";
            YMDSearchBtn.UseVisualStyleBackColor = true;
            YMDSearchBtn.Click += YMDSearchBtn_Click;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(348, 1);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 26;
            label6.Text = "تا تاریخ";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(536, 1);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 25;
            label5.Text = "از تاریخ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ToDate
            // 
            ToDate.BackColor = Color.White;
            ToDate.CalendarBackColor = Color.FromArgb(240, 236, 200);
            ToDate.CalendarForeColor = Color.Black;
            ToDate.CalendarRightToLeft = RightToLeft.Yes;
            ToDate.CalendarTitleBackColor = Color.LightCoral;
            ToDate.CalendarTitleForeColor = Color.Black;
            ToDate.Cursor = Cursors.Hand;
            ToDate.ForeColor = Color.Black;
            ToDate.Location = new Point(234, 36);
            ToDate.Name = "ToDate";
            ToDate.RightToLeft = RightToLeft.Yes;
            ToDate.Size = new Size(185, 33);
            ToDate.Style = Atf.UI.DropDownControlStyle.List;
            ToDate.TabIndex = 24;
            // 
            // FromDate
            // 
            FromDate.BackColor = Color.White;
            FromDate.CalendarBackColor = Color.FromArgb(240, 236, 200);
            FromDate.CalendarForeColor = Color.Black;
            FromDate.CalendarRightToLeft = RightToLeft.Yes;
            FromDate.CalendarTitleBackColor = Color.LightCoral;
            FromDate.CalendarTitleForeColor = Color.Black;
            FromDate.Cursor = Cursors.Hand;
            FromDate.ForeColor = Color.Black;
            FromDate.Location = new Point(425, 36);
            FromDate.Name = "FromDate";
            FromDate.RightToLeft = RightToLeft.Yes;
            FromDate.Size = new Size(185, 33);
            FromDate.Style = Atf.UI.DropDownControlStyle.List;
            FromDate.TabIndex = 23;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(708, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 22;
            label4.Text = "روز";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(880, 1);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 21;
            label3.Text = "ماه";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(1052, 1);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 20;
            label2.Text = "سال";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // yearCombo
            // 
            yearCombo.BackColor = Color.FromArgb(240, 236, 229);
            yearCombo.Cursor = Cursors.Hand;
            yearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            yearCombo.FormattingEnabled = true;
            yearCombo.Location = new Point(960, 36);
            yearCombo.Name = "yearCombo";
            yearCombo.RightToLeft = RightToLeft.Yes;
            yearCombo.Size = new Size(166, 33);
            yearCombo.TabIndex = 19;
            // 
            // dayCombo
            // 
            dayCombo.BackColor = Color.FromArgb(240, 236, 229);
            dayCombo.Cursor = Cursors.Hand;
            dayCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            dayCombo.FormattingEnabled = true;
            dayCombo.Location = new Point(616, 36);
            dayCombo.Name = "dayCombo";
            dayCombo.RightToLeft = RightToLeft.Yes;
            dayCombo.Size = new Size(166, 33);
            dayCombo.TabIndex = 18;
            // 
            // monthCombo
            // 
            monthCombo.BackColor = Color.FromArgb(240, 236, 229);
            monthCombo.Cursor = Cursors.Hand;
            monthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            monthCombo.FormattingEnabled = true;
            monthCombo.Location = new Point(788, 36);
            monthCombo.Name = "monthCombo";
            monthCombo.RightToLeft = RightToLeft.Yes;
            monthCombo.Size = new Size(166, 33);
            monthCombo.TabIndex = 17;
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
            GridData.Location = new Point(4, 183);
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
            GridData.Size = new Size(1135, 506);
            GridData.TabIndex = 17;
            GridData.VirtualMode = true;
            // 
            // CartCombo
            // 
            CartCombo.BackColor = Color.FromArgb(240, 236, 229);
            CartCombo.Cursor = Cursors.Hand;
            CartCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CartCombo.FormattingEnabled = true;
            CartCombo.Location = new Point(355, 21);
            CartCombo.Name = "CartCombo";
            CartCombo.RightToLeft = RightToLeft.Yes;
            CartCombo.Size = new Size(782, 33);
            CartCombo.TabIndex = 16;
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
            SearchBtn.Click += SearchBtn_Click;
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
            // CalculateUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateUC";
            Size = new Size(1146, 759);
            Load += CalculateUC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private GroupBox groupBox2;
        private DataGridView GridData;
        private ComboBox CartCombo;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Panel panel1;
        private ComboBox yearCombo;
        private ComboBox dayCombo;
        private ComboBox monthCombo;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox TBlanceTxt;
        private TextBox FBlanceTxt;
        private Button DateSearchBtn;
        private Button YMDSearchBtn;
        private Label label6;
        private Label label5;
        private Atf.UI.DateTimeSelector ToDate;
        private Atf.UI.DateTimeSelector FromDate;
        private Button BlanceSearchBtn;
    }
}
