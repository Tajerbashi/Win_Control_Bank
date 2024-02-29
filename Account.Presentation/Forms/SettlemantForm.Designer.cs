namespace Account.Presentation.Forms
{
    partial class SettlemantForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            AccountCombo = new ComboBox();
            CashTxt = new TextBox();
            DescTxt = new TextBox();
            CustomerCombo = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            DayCombo = new ComboBox();
            MonthCombo = new ComboBox();
            YearCombo = new ComboBox();
            MSG = new Label();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(795, 35);
            label3.TabIndex = 28;
            label3.Text = "ثبت واریزی ها";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(AccountCombo);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(DescTxt);
            groupBox1.Controls.Add(CustomerCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DayCombo);
            groupBox1.Controls.Add(MonthCombo);
            groupBox1.Controls.Add(YearCombo);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(6, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(795, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(477, 18);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 68;
            label5.Text = "حساب";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AccountCombo
            // 
            AccountCombo.BackColor = Color.White;
            AccountCombo.Cursor = Cursors.Hand;
            AccountCombo.DropDownHeight = 100;
            AccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountCombo.ForeColor = Color.Black;
            AccountCombo.FormattingEnabled = true;
            AccountCombo.IntegralHeight = false;
            AccountCombo.Location = new Point(12, 53);
            AccountCombo.Name = "AccountCombo";
            AccountCombo.RightToLeft = RightToLeft.Yes;
            AccountCombo.Size = new Size(530, 33);
            AccountCombo.TabIndex = 1;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.FromArgb(240, 236, 150);
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(231, 180);
            CashTxt.MaxLength = 15;
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(333, 32);
            CashTxt.TabIndex = 5;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            CashTxt.TextChanged += CashTxt_TextChanged;
            // 
            // DescTxt
            // 
            DescTxt.BackColor = Color.FromArgb(240, 236, 150);
            DescTxt.BorderStyle = BorderStyle.FixedSingle;
            DescTxt.Location = new Point(104, 233);
            DescTxt.MaxLength = 500;
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "توضیحات مورد نظر را وارد کنید";
            DescTxt.Size = new Size(587, 54);
            DescTxt.TabIndex = 6;
            DescTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerCombo
            // 
            CustomerCombo.BackColor = Color.White;
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownHeight = 100;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.ForeColor = Color.Black;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.IntegralHeight = false;
            CustomerCombo.Location = new Point(548, 53);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(234, 33);
            CustomerCombo.TabIndex = 0;
            CustomerCombo.SelectedIndexChanged += CustomerCombo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(695, 17);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 31;
            label6.Text = "مشترک";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(179, 89);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 29;
            label4.Text = "روز";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(449, 89);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 28;
            label2.Text = "ماه";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(713, 89);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 27;
            label1.Text = "سال";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DayCombo
            // 
            DayCombo.BackColor = Color.White;
            DayCombo.Cursor = Cursors.Hand;
            DayCombo.DropDownHeight = 100;
            DayCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DayCombo.ForeColor = Color.Black;
            DayCombo.FormattingEnabled = true;
            DayCombo.IntegralHeight = false;
            DayCombo.Location = new Point(12, 124);
            DayCombo.Name = "DayCombo";
            DayCombo.RightToLeft = RightToLeft.Yes;
            DayCombo.Size = new Size(234, 33);
            DayCombo.TabIndex = 4;
            // 
            // MonthCombo
            // 
            MonthCombo.BackColor = Color.White;
            MonthCombo.Cursor = Cursors.Hand;
            MonthCombo.DropDownHeight = 100;
            MonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            MonthCombo.ForeColor = Color.Black;
            MonthCombo.FormattingEnabled = true;
            MonthCombo.IntegralHeight = false;
            MonthCombo.Location = new Point(280, 124);
            MonthCombo.Name = "MonthCombo";
            MonthCombo.RightToLeft = RightToLeft.Yes;
            MonthCombo.Size = new Size(234, 33);
            MonthCombo.TabIndex = 3;
            // 
            // YearCombo
            // 
            YearCombo.BackColor = Color.White;
            YearCombo.Cursor = Cursors.Hand;
            YearCombo.DropDownHeight = 100;
            YearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            YearCombo.ForeColor = Color.Black;
            YearCombo.FormattingEnabled = true;
            YearCombo.IntegralHeight = false;
            YearCombo.Location = new Point(548, 124);
            YearCombo.Name = "YearCombo";
            YearCombo.RightToLeft = RightToLeft.Yes;
            YearCombo.Size = new Size(234, 33);
            YearCombo.TabIndex = 2;
            // 
            // MSG
            // 
            MSG.BackColor = Color.FromArgb(20, 20, 70);
            MSG.ForeColor = Color.LightCoral;
            MSG.Location = new Point(10, 17);
            MSG.Name = "MSG";
            MSG.Size = new Size(461, 32);
            MSG.TabIndex = 1;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Crimson;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.FlatAppearance.BorderColor = Color.Red;
            CloseBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(166, 300);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 8;
            CloseBtn.Text = "لفو عملیات";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.ForestGreen;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatAppearance.BorderColor = Color.Green;
            SaveBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(507, 300);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // SettlemantForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(807, 393);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "SettlemantForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettlemantForm";
            Load += SettlemantForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label MSG;
        private Button CloseBtn;
        private Button SaveBtn;
        private Label label1;
        private ComboBox DayCombo;
        private ComboBox MonthCombo;
        private ComboBox YearCombo;
        private ComboBox CustomerCombo;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox CashTxt;
        private TextBox DescTxt;
        private ComboBox AccountCombo;
        private Label label5;
    }
}