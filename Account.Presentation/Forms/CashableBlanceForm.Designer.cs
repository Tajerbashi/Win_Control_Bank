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
            label4 = new Label();
            UnitCombo = new ComboBox();
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
            MSG = new Label();
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
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(801, 35);
            label3.TabIndex = 28;
            label3.Text = "ثبت اطلاعات بانک";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(UnitCombo);
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
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(6, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(801, 487);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 233);
            label4.Name = "label4";
            label4.Size = new Size(159, 32);
            label4.TabIndex = 78;
            label4.Text = "واحد";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UnitCombo
            // 
            UnitCombo.BackColor = Color.FromArgb(240, 236, 229);
            UnitCombo.Cursor = Cursors.Hand;
            UnitCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitCombo.FormattingEnabled = true;
            UnitCombo.Location = new Point(8, 268);
            UnitCombo.Name = "UnitCombo";
            UnitCombo.RightToLeft = RightToLeft.Yes;
            UnitCombo.Size = new Size(227, 33);
            UnitCombo.TabIndex = 77;
            // 
            // BlanceTypeCombo
            // 
            BlanceTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            BlanceTypeCombo.Cursor = Cursors.Hand;
            BlanceTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BlanceTypeCombo.FormattingEnabled = true;
            BlanceTypeCombo.Location = new Point(287, 268);
            BlanceTypeCombo.Name = "BlanceTypeCombo";
            BlanceTypeCombo.RightToLeft = RightToLeft.Yes;
            BlanceTypeCombo.Size = new Size(227, 33);
            BlanceTypeCombo.TabIndex = 76;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(355, 233);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 75;
            label2.Text = "نوع موجودی";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionTypeCombo
            // 
            TransactionTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            TransactionTypeCombo.Cursor = Cursors.Hand;
            TransactionTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionTypeCombo.FormattingEnabled = true;
            TransactionTypeCombo.Location = new Point(566, 268);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(227, 33);
            TransactionTypeCombo.TabIndex = 74;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(634, 233);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
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
            FromAccountCombo.Location = new Point(8, 197);
            FromAccountCombo.Name = "FromAccountCombo";
            FromAccountCombo.RightToLeft = RightToLeft.Yes;
            FromAccountCombo.Size = new Size(785, 33);
            FromAccountCombo.TabIndex = 72;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(634, 162);
            label6.Name = "label6";
            label6.Size = new Size(159, 32);
            label6.TabIndex = 71;
            label6.Text = "از حساب";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(634, 91);
            label5.Name = "label5";
            label5.Size = new Size(159, 32);
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
            FromCartCombo.Location = new Point(8, 126);
            FromCartCombo.Name = "FromCartCombo";
            FromCartCombo.RightToLeft = RightToLeft.Yes;
            FromCartCombo.Size = new Size(785, 33);
            FromCartCombo.TabIndex = 69;
            FromCartCombo.SelectedIndexChanged += FromCartCombo_SelectedIndexChanged;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.FromArgb(240, 236, 150);
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(125, 317);
            CashTxt.MaxLength = 15;
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(550, 32);
            CashTxt.TabIndex = 64;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // DescTxt
            // 
            DescTxt.BackColor = Color.FromArgb(240, 236, 150);
            DescTxt.BorderStyle = BorderStyle.FixedSingle;
            DescTxt.Location = new Point(9, 365);
            DescTxt.MaxLength = 500;
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "توضیحات مورد نظر را وارد کنید";
            DescTxt.Size = new Size(783, 64);
            DescTxt.TabIndex = 63;
            DescTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerAccountCombo
            // 
            CustomerAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerAccountCombo.Cursor = Cursors.Hand;
            CustomerAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerAccountCombo.FormattingEnabled = true;
            CustomerAccountCombo.Location = new Point(8, 55);
            CustomerAccountCombo.Name = "CustomerAccountCombo";
            CustomerAccountCombo.RightToLeft = RightToLeft.Yes;
            CustomerAccountCombo.Size = new Size(785, 33);
            CustomerAccountCombo.TabIndex = 24;
            CustomerAccountCombo.SelectedIndexChanged += CustomerAccountCombo_SelectedIndexChanged;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.Black;
            MSG.Location = new Point(10, 18);
            MSG.Name = "MSG";
            MSG.Size = new Size(620, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            MSG.Visible = false;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(634, 20);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(159, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "نام مالک حساب نقدی";
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
            CloseBtn.Location = new Point(227, 441);
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
            SaveBtn.Location = new Point(452, 441);
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
            ClientSize = new Size(813, 531);
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
        private Label label4;
        private ComboBox UnitCombo;
        private ComboBox BlanceTypeCombo;
        private Label label2;
        private ComboBox TransactionTypeCombo;
        private Label label1;
    }
}