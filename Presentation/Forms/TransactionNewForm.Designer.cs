namespace Presentation.Forms
{
    partial class TransactionNewForm
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
            MSG = new Label();
            label6 = new Label();
            TransactionTypeCombo = new ComboBox();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1 = new GroupBox();
            DescTxt = new TextBox();
            NewDataBtn = new Button();
            NewDataPanel = new Panel();
            SaveNewDataBtn = new Button();
            label12 = new Label();
            label11 = new Label();
            NewCartNumberTxt = new TextBox();
            NewBankNameTxt = new TextBox();
            NewCustomerNameTxt = new TextBox();
            label10 = new Label();
            FromAccountLBL = new Label();
            FromCustomerLBL = new Label();
            TransactionKindCombo = new ComboBox();
            label2 = new Label();
            FromAccountCombo = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            BlanceTypeCombo = new ComboBox();
            ToAccountCombo = new ComboBox();
            label7 = new Label();
            FromCustomerCombo = new ComboBox();
            ToCustomerCombo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            CashTxt = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            NewDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSlateGray;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(1129, 35);
            label3.TabIndex = 27;
            label3.Text = "ثبت تراکنش جدید";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.FromArgb(255, 192, 192);
            MSG.Location = new Point(6, 18);
            MSG.Name = "MSG";
            MSG.Size = new Size(436, 32);
            MSG.TabIndex = 0;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(1022, 18);
            label6.Name = "label6";
            label6.Size = new Size(95, 32);
            label6.TabIndex = 31;
            label6.Text = "نوع تراکنش";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionTypeCombo
            // 
            TransactionTypeCombo.Cursor = Cursors.Hand;
            TransactionTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionTypeCombo.FormattingEnabled = true;
            TransactionTypeCombo.Location = new Point(759, 53);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(358, 33);
            TransactionTypeCombo.TabIndex = 0;
            TransactionTypeCombo.SelectedValueChanged += TransactionTypeCombo_SelectedValueChanged;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.FromArgb(255, 128, 128);
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.FlatAppearance.BorderColor = Color.Red;
            CloseBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            CloseBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            CloseBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.FromArgb(64, 0, 0);
            CloseBtn.Location = new Point(414, 419);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 10;
            CloseBtn.Text = "لغو عملیات";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.LimeGreen;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            SaveBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.FromArgb(0, 64, 0);
            SaveBtn.Location = new Point(593, 417);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 9;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(DescTxt);
            groupBox1.Controls.Add(NewDataBtn);
            groupBox1.Controls.Add(NewDataPanel);
            groupBox1.Controls.Add(FromAccountLBL);
            groupBox1.Controls.Add(FromCustomerLBL);
            groupBox1.Controls.Add(TransactionKindCombo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FromAccountCombo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BlanceTypeCombo);
            groupBox1.Controls.Add(ToAccountCombo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(FromCustomerCombo);
            groupBox1.Controls.Add(ToCustomerCombo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TransactionTypeCombo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // DescTxt
            // 
            DescTxt.BackColor = Color.White;
            DescTxt.BorderStyle = BorderStyle.FixedSingle;
            DescTxt.Location = new Point(11, 347);
            DescTxt.MaxLength = 500;
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "توضیحات مورد نظر را وارد کنید";
            DescTxt.Size = new Size(799, 64);
            DescTxt.TabIndex = 60;
            DescTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewDataBtn
            // 
            NewDataBtn.BackColor = Color.LimeGreen;
            NewDataBtn.Cursor = Cursors.Hand;
            NewDataBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            NewDataBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            NewDataBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            NewDataBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            NewDataBtn.FlatStyle = FlatStyle.Flat;
            NewDataBtn.ForeColor = Color.FromArgb(0, 64, 0);
            NewDataBtn.Location = new Point(11, 194);
            NewDataBtn.Name = "NewDataBtn";
            NewDataBtn.Size = new Size(33, 33);
            NewDataBtn.TabIndex = 59;
            NewDataBtn.Text = "+";
            NewDataBtn.UseVisualStyleBackColor = false;
            NewDataBtn.Visible = false;
            NewDataBtn.Click += NewDataBtn_Click;
            // 
            // NewDataPanel
            // 
            NewDataPanel.Controls.Add(SaveNewDataBtn);
            NewDataPanel.Controls.Add(label12);
            NewDataPanel.Controls.Add(label11);
            NewDataPanel.Controls.Add(NewCartNumberTxt);
            NewDataPanel.Controls.Add(NewBankNameTxt);
            NewDataPanel.Controls.Add(NewCustomerNameTxt);
            NewDataPanel.Controls.Add(label10);
            NewDataPanel.Location = new Point(6, 234);
            NewDataPanel.Name = "NewDataPanel";
            NewDataPanel.Size = new Size(1117, 107);
            NewDataPanel.TabIndex = 0;
            NewDataPanel.Visible = false;
            // 
            // SaveNewDataBtn
            // 
            SaveNewDataBtn.BackColor = Color.LimeGreen;
            SaveNewDataBtn.Cursor = Cursors.Hand;
            SaveNewDataBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            SaveNewDataBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveNewDataBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveNewDataBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveNewDataBtn.FlatStyle = FlatStyle.Flat;
            SaveNewDataBtn.ForeColor = Color.FromArgb(0, 64, 0);
            SaveNewDataBtn.Location = new Point(498, 72);
            SaveNewDataBtn.Name = "SaveNewDataBtn";
            SaveNewDataBtn.Size = new Size(121, 32);
            SaveNewDataBtn.TabIndex = 3;
            SaveNewDataBtn.Text = "ذخیره اطلاعات";
            SaveNewDataBtn.UseVisualStyleBackColor = false;
            SaveNewDataBtn.Click += SaveNewDataBtn_Click;
            // 
            // label12
            // 
            label12.ForeColor = Color.White;
            label12.Location = new Point(240, 2);
            label12.Name = "label12";
            label12.Size = new Size(123, 32);
            label12.TabIndex = 57;
            label12.Text = "شماره کارت";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.ForeColor = Color.White;
            label11.Location = new Point(614, 2);
            label11.Name = "label11";
            label11.Size = new Size(123, 32);
            label11.TabIndex = 56;
            label11.Text = "بانک کارت";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewCartNumberTxt
            // 
            NewCartNumberTxt.BackColor = Color.White;
            NewCartNumberTxt.BorderStyle = BorderStyle.FixedSingle;
            NewCartNumberTxt.Location = new Point(5, 37);
            NewCartNumberTxt.MaxLength = 16;
            NewCartNumberTxt.Name = "NewCartNumberTxt";
            NewCartNumberTxt.PlaceholderText = "شماره کارت را وارد کنید";
            NewCartNumberTxt.Size = new Size(358, 32);
            NewCartNumberTxt.TabIndex = 2;
            NewCartNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewBankNameTxt
            // 
            NewBankNameTxt.BackColor = Color.White;
            NewBankNameTxt.BorderStyle = BorderStyle.FixedSingle;
            NewBankNameTxt.Location = new Point(379, 37);
            NewBankNameTxt.MaxLength = 25;
            NewBankNameTxt.Name = "NewBankNameTxt";
            NewBankNameTxt.PlaceholderText = "نام بانک کارت مقصد را وارد کنید";
            NewBankNameTxt.Size = new Size(358, 32);
            NewBankNameTxt.TabIndex = 1;
            NewBankNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewCustomerNameTxt
            // 
            NewCustomerNameTxt.BackColor = Color.White;
            NewCustomerNameTxt.BorderStyle = BorderStyle.FixedSingle;
            NewCustomerNameTxt.Location = new Point(753, 37);
            NewCustomerNameTxt.MaxLength = 50;
            NewCustomerNameTxt.Name = "NewCustomerNameTxt";
            NewCustomerNameTxt.PlaceholderText = "نام مالک کارت را وارد کنید";
            NewCustomerNameTxt.Size = new Size(358, 32);
            NewCustomerNameTxt.TabIndex = 0;
            NewCustomerNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(992, 2);
            label10.Name = "label10";
            label10.Size = new Size(123, 32);
            label10.TabIndex = 39;
            label10.Text = "نام مالک کارت";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromAccountLBL
            // 
            FromAccountLBL.ForeColor = Color.FromArgb(255, 192, 192);
            FromAccountLBL.Location = new Point(6, 160);
            FromAccountLBL.Name = "FromAccountLBL";
            FromAccountLBL.Size = new Size(409, 32);
            FromAccountLBL.TabIndex = 51;
            FromAccountLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FromCustomerLBL
            // 
            FromCustomerLBL.ForeColor = Color.FromArgb(255, 192, 192);
            FromCustomerLBL.Location = new Point(567, 160);
            FromCustomerLBL.Name = "FromCustomerLBL";
            FromCustomerLBL.Size = new Size(436, 32);
            FromCustomerLBL.TabIndex = 50;
            FromCustomerLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransactionKindCombo
            // 
            TransactionKindCombo.Cursor = Cursors.Hand;
            TransactionKindCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionKindCombo.FormattingEnabled = true;
            TransactionKindCombo.Location = new Point(11, 53);
            TransactionKindCombo.Name = "TransactionKindCombo";
            TransactionKindCombo.RightToLeft = RightToLeft.Yes;
            TransactionKindCombo.Size = new Size(358, 33);
            TransactionKindCombo.TabIndex = 2;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(274, 18);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 49;
            label2.Text = "جنس تراکنش";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromAccountCombo
            // 
            FromAccountCombo.Cursor = Cursors.Hand;
            FromAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromAccountCombo.FormattingEnabled = true;
            FromAccountCombo.Location = new Point(11, 124);
            FromAccountCombo.Name = "FromAccountCombo";
            FromAccountCombo.RightToLeft = RightToLeft.Yes;
            FromAccountCombo.Size = new Size(545, 33);
            FromAccountCombo.TabIndex = 4;
            FromAccountCombo.SelectedValueChanged += FromAccountCombo_SelectedValueChanged;
            // 
            // label9
            // 
            label9.ForeColor = Color.White;
            label9.Location = new Point(390, 89);
            label9.Name = "label9";
            label9.Size = new Size(172, 32);
            label9.TabIndex = 48;
            label9.Text = "از حساب کارت مبداء";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(576, 18);
            label8.Name = "label8";
            label8.Size = new Size(167, 32);
            label8.TabIndex = 46;
            label8.Text = "نوع موجودی مالک کارت";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlanceTypeCombo
            // 
            BlanceTypeCombo.Cursor = Cursors.Hand;
            BlanceTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BlanceTypeCombo.FormattingEnabled = true;
            BlanceTypeCombo.Location = new Point(385, 53);
            BlanceTypeCombo.Name = "BlanceTypeCombo";
            BlanceTypeCombo.RightToLeft = RightToLeft.Yes;
            BlanceTypeCombo.Size = new Size(358, 33);
            BlanceTypeCombo.TabIndex = 1;
            // 
            // ToAccountCombo
            // 
            ToAccountCombo.Cursor = Cursors.Hand;
            ToAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToAccountCombo.FormattingEnabled = true;
            ToAccountCombo.Location = new Point(50, 194);
            ToAccountCombo.Name = "ToAccountCombo";
            ToAccountCombo.RightToLeft = RightToLeft.Yes;
            ToAccountCombo.Size = new Size(506, 33);
            ToAccountCombo.TabIndex = 6;
            ToAccountCombo.Visible = false;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(390, 160);
            label7.Name = "label7";
            label7.Size = new Size(171, 32);
            label7.TabIndex = 43;
            label7.Text = "به حساب کارت مقصد";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Visible = false;
            // 
            // FromCustomerCombo
            // 
            FromCustomerCombo.Cursor = Cursors.Hand;
            FromCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromCustomerCombo.FormattingEnabled = true;
            FromCustomerCombo.Location = new Point(567, 124);
            FromCustomerCombo.Name = "FromCustomerCombo";
            FromCustomerCombo.RightToLeft = RightToLeft.Yes;
            FromCustomerCombo.Size = new Size(550, 33);
            FromCustomerCombo.TabIndex = 3;
            FromCustomerCombo.SelectedIndexChanged += FromCustomerCombo_SelectedIndexChanged;
            // 
            // ToCustomerCombo
            // 
            ToCustomerCombo.Cursor = Cursors.Hand;
            ToCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToCustomerCombo.FormattingEnabled = true;
            ToCustomerCombo.Location = new Point(567, 194);
            ToCustomerCombo.Name = "ToCustomerCombo";
            ToCustomerCombo.RightToLeft = RightToLeft.Yes;
            ToCustomerCombo.Size = new Size(550, 33);
            ToCustomerCombo.TabIndex = 5;
            ToCustomerCombo.Visible = false;
            ToCustomerCombo.SelectedIndexChanged += ToCustomerCombo_SelectedIndexChanged;
            ToCustomerCombo.SelectedValueChanged += ToCustomerCombo_SelectedValueChanged;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(1000, 160);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 38;
            label5.Text = "به کارت مقصد";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Visible = false;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(1028, 344);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 37;
            label4.Text = "مبلغ تراکنش";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.White;
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(816, 379);
            CashTxt.MaxLength = 15;
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(307, 32);
            CashTxt.TabIndex = 7;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(1028, 89);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 32;
            label1.Text = "از کارت مبداء";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1153, 520);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TransactionNewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionNewForm";
            Load += TransactionNewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            NewDataPanel.ResumeLayout(false);
            NewDataPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Atf.UI.DateTimeSelector ExpireDate;
        private Label MSG;
        private Label label6;
        private ComboBox TransactionTypeCombo;
        private Button CloseBtn;
        private Button SaveBtn;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox ToCustomerCombo;
        private Label label5;
        private Label label4;
        private TextBox CashTxt;
        private ComboBox FromCustomerCombo;
        private Label label7;
        private ComboBox ToAccountCombo;
        private Label label8;
        private ComboBox BlanceTypeCombo;
        private ComboBox FromAccountCombo;
        private Label label9;
        private ComboBox TransactionKindCombo;
        private Label label2;
        private Label FromAccountLBL;
        private Label FromCustomerLBL;
        private Panel NewDataPanel;
        private TextBox NewCartNumberTxt;
        private TextBox NewBankNameTxt;
        private TextBox NewCustomerNameTxt;
        private Label label10;
        private Button SaveNewDataBtn;
        private Label label12;
        private Label label11;
        private Button NewDataBtn;
        private TextBox DescTxt;
    }
}