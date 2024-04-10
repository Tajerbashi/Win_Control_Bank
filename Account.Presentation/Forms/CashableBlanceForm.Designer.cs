namespace Account.Presentation.Forms
{
    partial class CashableBlanceForm
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
            CashableBlanceLBL = new Label();
            FTLBL = new Label();
            FCCLbl = new Label();
            FACLbl = new Label();
            CACLbl = new Label();
            MSG = new Label();
            label7 = new Label();
            FromCustomerCombo = new ComboBox();
            BlanceTypeCombo = new ComboBox();
            label2 = new Label();
            TransactionTypeCombo = new ComboBox();
            label1 = new Label();
            FromAccountCombo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            FromCartCombo = new ComboBox();
            CashTxt = new TextBox();
            DescTxt = new TextBox();
            CustomerAccountCombo = new ComboBox();
            PageLbl = new Label();
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
            label3.Size = new Size(717, 35);
            label3.TabIndex = 28;
            label3.Text = "ثبت تراکنش نقدی";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(CashableBlanceLBL);
            groupBox1.Controls.Add(FTLBL);
            groupBox1.Controls.Add(FCCLbl);
            groupBox1.Controls.Add(FACLbl);
            groupBox1.Controls.Add(CACLbl);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(FromCustomerCombo);
            groupBox1.Controls.Add(BlanceTypeCombo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TransactionTypeCombo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FromAccountCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(FromCartCombo);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(DescTxt);
            groupBox1.Controls.Add(CustomerAccountCombo);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(5, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 535);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // CashableBlanceLBL
            // 
            CashableBlanceLBL.ForeColor = Color.White;
            CashableBlanceLBL.Location = new Point(170, 91);
            CashableBlanceLBL.Name = "CashableBlanceLBL";
            CashableBlanceLBL.Size = new Size(225, 32);
            CashableBlanceLBL.TabIndex = 85;
            CashableBlanceLBL.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FTLBL
            // 
            FTLBL.ForeColor = Color.White;
            FTLBL.Location = new Point(518, 52);
            FTLBL.Name = "FTLBL";
            FTLBL.Size = new Size(37, 32);
            FTLBL.TabIndex = 84;
            FTLBL.Text = "به";
            FTLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FCCLbl
            // 
            FCCLbl.ForeColor = Color.White;
            FCCLbl.Location = new Point(15, 162);
            FCCLbl.Name = "FCCLbl";
            FCCLbl.Size = new Size(225, 32);
            FCCLbl.TabIndex = 83;
            FCCLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FACLbl
            // 
            FACLbl.ForeColor = Color.White;
            FACLbl.Location = new Point(15, 233);
            FACLbl.Name = "FACLbl";
            FACLbl.Size = new Size(225, 32);
            FACLbl.TabIndex = 82;
            FACLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CACLbl
            // 
            CACLbl.ForeColor = Color.White;
            CACLbl.Location = new Point(15, 18);
            CACLbl.Name = "CACLbl";
            CACLbl.Size = new Size(225, 32);
            CACLbl.TabIndex = 81;
            CACLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MSG
            // 
            MSG.BackColor = Color.Transparent;
            MSG.ForeColor = Color.LightCoral;
            MSG.Location = new Point(20, 436);
            MSG.Name = "MSG";
            MSG.Size = new Size(678, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(639, 91);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 80;
            label7.Text = "از مشترک";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromCustomerCombo
            // 
            FromCustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            FromCustomerCombo.Cursor = Cursors.Hand;
            FromCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromCustomerCombo.FormattingEnabled = true;
            FromCustomerCombo.Location = new Point(163, 126);
            FromCustomerCombo.Name = "FromCustomerCombo";
            FromCustomerCombo.RightToLeft = RightToLeft.Yes;
            FromCustomerCombo.Size = new Size(547, 33);
            FromCustomerCombo.TabIndex = 79;
            FromCustomerCombo.SelectedIndexChanged += FromCustomerCombo_SelectedIndexChanged;
            // 
            // BlanceTypeCombo
            // 
            BlanceTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            BlanceTypeCombo.Cursor = Cursors.Hand;
            BlanceTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BlanceTypeCombo.FormattingEnabled = true;
            BlanceTypeCombo.Location = new Point(8, 126);
            BlanceTypeCombo.Name = "BlanceTypeCombo";
            BlanceTypeCombo.RightToLeft = RightToLeft.Yes;
            BlanceTypeCombo.Size = new Size(149, 33);
            BlanceTypeCombo.TabIndex = 76;
            BlanceTypeCombo.SelectedIndexChanged += BlanceTypeCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 75;
            label2.Text = "نوع حساب";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionTypeCombo
            // 
            TransactionTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            TransactionTypeCombo.Cursor = Cursors.Hand;
            TransactionTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionTypeCombo.FormattingEnabled = true;
            TransactionTypeCombo.Location = new Point(561, 53);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(149, 33);
            TransactionTypeCombo.TabIndex = 74;
            TransactionTypeCombo.SelectedIndexChanged += TransactionTypeCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(613, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 73;
            label1.Text = "جنس تراکنش";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromAccountCombo
            // 
            FromAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            FromAccountCombo.Cursor = Cursors.Hand;
            FromAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromAccountCombo.FormattingEnabled = true;
            FromAccountCombo.Location = new Point(8, 268);
            FromAccountCombo.Name = "FromAccountCombo";
            FromAccountCombo.RightToLeft = RightToLeft.Yes;
            FromAccountCombo.Size = new Size(702, 33);
            FromAccountCombo.TabIndex = 72;
            FromAccountCombo.SelectedIndexChanged += FromAccountCombo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(638, 233);
            label6.Name = "label6";
            label6.Size = new Size(72, 32);
            label6.TabIndex = 71;
            label6.Text = "از حساب";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(638, 162);
            label5.Name = "label5";
            label5.Size = new Size(72, 32);
            label5.TabIndex = 70;
            label5.Text = "از کارت";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromCartCombo
            // 
            FromCartCombo.BackColor = Color.FromArgb(240, 236, 229);
            FromCartCombo.Cursor = Cursors.Hand;
            FromCartCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromCartCombo.FormattingEnabled = true;
            FromCartCombo.Location = new Point(8, 197);
            FromCartCombo.Name = "FromCartCombo";
            FromCartCombo.RightToLeft = RightToLeft.Yes;
            FromCartCombo.Size = new Size(702, 33);
            FromCartCombo.TabIndex = 69;
            FromCartCombo.SelectedIndexChanged += FromCartCombo_SelectedIndexChanged;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.FromArgb(240, 236, 150);
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(123, 313);
            CashTxt.MaxLength = 15;
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(472, 32);
            CashTxt.TabIndex = 64;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            CashTxt.TextChanged += CashTxt_TextChanged;
            CashTxt.KeyPress += CashTxt_KeyPress;
            // 
            // DescTxt
            // 
            DescTxt.BackColor = Color.FromArgb(240, 236, 150);
            DescTxt.BorderStyle = BorderStyle.FixedSingle;
            DescTxt.Location = new Point(65, 351);
            DescTxt.MaxLength = 500;
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "توضیحات مورد نظر را وارد کنید";
            DescTxt.Size = new Size(588, 80);
            DescTxt.TabIndex = 63;
            DescTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerAccountCombo
            // 
            CustomerAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerAccountCombo.Cursor = Cursors.Hand;
            CustomerAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerAccountCombo.FormattingEnabled = true;
            CustomerAccountCombo.Location = new Point(8, 53);
            CustomerAccountCombo.Name = "CustomerAccountCombo";
            CustomerAccountCombo.RightToLeft = RightToLeft.Yes;
            CustomerAccountCombo.Size = new Size(504, 33);
            CustomerAccountCombo.TabIndex = 24;
            CustomerAccountCombo.SelectedIndexChanged += CustomerAccountCombo_SelectedIndexChanged;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(440, 18);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(72, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "مشترک";
            PageLbl.TextAlign = ContentAlignment.MiddleRight;
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
            CloseBtn.Location = new Point(183, 475);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 4;
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
            SaveBtn.Location = new Point(415, 475);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CashableBlanceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(729, 577);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashableBlanceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CashableBlanceForm";
            Load += CashableBlanceForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label MSG;
        private Label PageLbl;
        private Button CloseBtn;
        private Button SaveBtn;
        private ComboBox CustomerAccountCombo;
        private TextBox CashTxt;
        private TextBox DescTxt;
        private Label label5;
        private ComboBox FromCartCombo;
        private ComboBox FromAccountCombo;
        private Label label6;
        private ComboBox BlanceTypeCombo;
        private Label label2;
        private ComboBox TransactionTypeCombo;
        private Label label1;
        private Label label7;
        private ComboBox FromCustomerCombo;
        private Label CACLbl;
        private Label FCCLbl;
        private Label FACLbl;
        private Label FTLBL;
        private Label CashableBlanceLBL;
    }
}