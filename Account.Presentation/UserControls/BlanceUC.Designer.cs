namespace Account.Presentation.UserControls
{
    partial class BlanceUC
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
            label1 = new Label();
            AddBtn = new Button();
            groupBox2 = new GroupBox();
            TableLayout = new TableLayoutPanel();
            button10 = new Button();
            button1 = new Button();
            button2 = new Button();
            button9 = new Button();
            FlowLayout = new FlowLayoutPanel();
            PanelCartBlance = new Panel();
            CustomerCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            groupBox2.SuspendLayout();
            TableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 0);
            label1.Name = "label1";
            label1.Size = new Size(912, 32);
            label1.TabIndex = 16;
            label1.Text = "اطلاعات موجودی بر اساس کارت و مشترک";
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
            AddBtn.Text = "تازه سازی";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(TableLayout);
            groupBox2.Controls.Add(FlowLayout);
            groupBox2.Controls.Add(PanelCartBlance);
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
            // TableLayout
            // 
            TableLayout.ColumnCount = 2;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayout.Controls.Add(button10, 0, 1);
            TableLayout.Controls.Add(button1, 0, 0);
            TableLayout.Controls.Add(button2, 1, 0);
            TableLayout.Controls.Add(button9, 1, 1);
            TableLayout.Location = new Point(6, 302);
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 2;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableLayout.Size = new Size(582, 390);
            TableLayout.TabIndex = 20;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button10.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button10.FlatAppearance.MouseDownBackColor = Color.Green;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.White;
            button10.Location = new Point(3, 198);
            button10.Name = "button10";
            button10.Size = new Size(285, 189);
            button10.TabIndex = 28;
            button10.Text = "جدید";
            button10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(285, 189);
            button1.TabIndex = 25;
            button1.Text = "جدید";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button2.FlatAppearance.MouseDownBackColor = Color.Green;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(294, 3);
            button2.Name = "button2";
            button2.Size = new Size(282, 189);
            button2.TabIndex = 26;
            button2.Text = "جدید";
            button2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button9.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button9.FlatAppearance.MouseDownBackColor = Color.Green;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.White;
            button9.Location = new Point(294, 198);
            button9.Name = "button9";
            button9.Size = new Size(282, 189);
            button9.TabIndex = 27;
            button9.Text = "جدید";
            button9.UseVisualStyleBackColor = true;
            // 
            // FlowLayout
            // 
            FlowLayout.Location = new Point(6, 60);
            FlowLayout.Name = "FlowLayout";
            FlowLayout.Size = new Size(582, 236);
            FlowLayout.TabIndex = 19;
            // 
            // PanelCartBlance
            // 
            PanelCartBlance.AutoScroll = true;
            PanelCartBlance.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelCartBlance.Location = new Point(594, 60);
            PanelCartBlance.Name = "PanelCartBlance";
            PanelCartBlance.Size = new Size(543, 629);
            PanelCartBlance.TabIndex = 18;
            // 
            // CustomerCombo
            // 
            CustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(355, 21);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(782, 33);
            CustomerCombo.TabIndex = 16;
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
            // BlanceUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BlanceUC";
            Size = new Size(1146, 759);
            Load += BlanceUC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private GroupBox groupBox2;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private TableLayoutPanel TableLayout;
        private FlowLayoutPanel FlowLayout;
        private Panel PanelCartBlance;
        private Button button10;
        private Button button9;
        private Button button1;
        private Button button2;
        private ComboBox CustomerCombo;
        private Button SearchBtn;
        private TextBox SearchTxt;
    }
}
