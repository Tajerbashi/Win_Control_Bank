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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            PanelCartBlance = new Panel();
            CartCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            groupBox2.SuspendLayout();
            TableLayout.SuspendLayout();
            FlowLayout.SuspendLayout();
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
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(TableLayout);
            groupBox2.Controls.Add(FlowLayout);
            groupBox2.Controls.Add(PanelCartBlance);
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
            FlowLayout.Controls.Add(button3);
            FlowLayout.Controls.Add(button4);
            FlowLayout.Controls.Add(button5);
            FlowLayout.Controls.Add(button6);
            FlowLayout.Controls.Add(button7);
            FlowLayout.Controls.Add(button8);
            FlowLayout.Location = new Point(6, 60);
            FlowLayout.Name = "FlowLayout";
            FlowLayout.Size = new Size(582, 236);
            FlowLayout.TabIndex = 19;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button3.FlatAppearance.MouseDownBackColor = Color.Green;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(187, 32);
            button3.TabIndex = 20;
            button3.Text = "جدید";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.MouseDownBackColor = Color.Green;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(196, 3);
            button4.Name = "button4";
            button4.Size = new Size(187, 32);
            button4.TabIndex = 21;
            button4.Text = "جدید";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button5.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button5.FlatAppearance.MouseDownBackColor = Color.Green;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(389, 3);
            button5.Name = "button5";
            button5.Size = new Size(187, 32);
            button5.TabIndex = 22;
            button5.Text = "جدید";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button6.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button6.FlatAppearance.MouseDownBackColor = Color.Green;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 41);
            button6.Name = "button6";
            button6.Size = new Size(187, 32);
            button6.TabIndex = 23;
            button6.Text = "جدید";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button7.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button7.FlatAppearance.MouseDownBackColor = Color.Green;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(196, 41);
            button7.Name = "button7";
            button7.Size = new Size(187, 32);
            button7.TabIndex = 24;
            button7.Text = "جدید";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button8.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            button8.FlatAppearance.MouseDownBackColor = Color.Green;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(389, 41);
            button8.Name = "button8";
            button8.Size = new Size(187, 32);
            button8.TabIndex = 25;
            button8.Text = "جدید";
            button8.UseVisualStyleBackColor = true;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TableLayout.ResumeLayout(false);
            FlowLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private GroupBox groupBox2;
        private ComboBox CartCombo;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private TableLayoutPanel TableLayout;
        private FlowLayoutPanel FlowLayout;
        private Panel PanelCartBlance;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button9;
        private Button button1;
        private Button button2;
    }
}
