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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            BankingInfoPanel = new Panel();
            CashableInfoPanel = new Panel();
            CustomInfoPanel = new Panel();
            CustomerCombo = new ComboBox();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(BankingInfoPanel);
            groupBox2.Controls.Add(CashableInfoPanel);
            groupBox2.Controls.Add(CustomInfoPanel);
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
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.CheckedBackColor = Color.PaleGreen;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(766, 65);
            button3.Name = "button3";
            button3.Size = new Size(370, 32);
            button3.TabIndex = 21;
            button3.Text = "وضعیت زیر حساب ها";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.CheckedBackColor = Color.PaleGreen;
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(386, 65);
            button2.Name = "button2";
            button2.Size = new Size(370, 32);
            button2.TabIndex = 20;
            button2.Text = "وضعیت حساب های نقدی هر مشترک";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.CheckedBackColor = Color.PaleGreen;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(6, 65);
            button1.Name = "button1";
            button1.Size = new Size(370, 32);
            button1.TabIndex = 19;
            button1.Text = "وضعیت حساب های بانکی مشترکین";
            button1.UseVisualStyleBackColor = false;
            // 
            // BankingInfoPanel
            // 
            BankingInfoPanel.AutoScroll = true;
            BankingInfoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BankingInfoPanel.Location = new Point(6, 95);
            BankingInfoPanel.Name = "BankingInfoPanel";
            BankingInfoPanel.Size = new Size(370, 594);
            BankingInfoPanel.TabIndex = 19;
            // 
            // CashableInfoPanel
            // 
            CashableInfoPanel.AutoScroll = true;
            CashableInfoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CashableInfoPanel.Location = new Point(386, 95);
            CashableInfoPanel.Name = "CashableInfoPanel";
            CashableInfoPanel.Size = new Size(370, 594);
            CashableInfoPanel.TabIndex = 19;
            // 
            // CustomInfoPanel
            // 
            CustomInfoPanel.AutoScroll = true;
            CustomInfoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomInfoPanel.Location = new Point(766, 95);
            CustomInfoPanel.Name = "CustomInfoPanel";
            CustomInfoPanel.Size = new Size(370, 594);
            CustomInfoPanel.TabIndex = 18;
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
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private GroupBox groupBox2;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Panel CustomInfoPanel;
        private ComboBox CustomerCombo;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Panel BankingInfoPanel;
        private Panel CashableInfoPanel;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
