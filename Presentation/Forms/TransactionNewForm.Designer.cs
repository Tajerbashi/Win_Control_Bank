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
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.DodgerBlue;
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
            label6.Location = new Point(1028, 18);
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
            TransactionTypeCombo.Location = new Point(844, 53);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(279, 33);
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
            CloseBtn.ForeColor = Color.White;
            CloseBtn.Location = new Point(377, 304);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 9;
            CloseBtn.Text = "لفو عملیات";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.LimeGreen;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatAppearance.BorderColor = Color.Green;
            SaveBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(631, 304);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
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
            groupBox1.Size = new Size(1129, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TransactionKindCombo
            // 
            TransactionKindCombo.Cursor = Cursors.Hand;
            TransactionKindCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionKindCombo.FormattingEnabled = true;
            TransactionKindCombo.Location = new Point(6, 53);
            TransactionKindCombo.Name = "TransactionKindCombo";
            TransactionKindCombo.RightToLeft = RightToLeft.Yes;
            TransactionKindCombo.Size = new Size(555, 33);
            TransactionKindCombo.TabIndex = 2;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(467, 18);
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
            FromAccountCombo.Location = new Point(6, 124);
            FromAccountCombo.Name = "FromAccountCombo";
            FromAccountCombo.RightToLeft = RightToLeft.Yes;
            FromAccountCombo.Size = new Size(556, 33);
            FromAccountCombo.TabIndex = 4;
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
            label8.Location = new Point(743, 18);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 46;
            label8.Text = "موجودیت";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlanceTypeCombo
            // 
            BlanceTypeCombo.Cursor = Cursors.Hand;
            BlanceTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BlanceTypeCombo.FormattingEnabled = true;
            BlanceTypeCombo.Location = new Point(567, 53);
            BlanceTypeCombo.Name = "BlanceTypeCombo";
            BlanceTypeCombo.RightToLeft = RightToLeft.Yes;
            BlanceTypeCombo.Size = new Size(271, 33);
            BlanceTypeCombo.TabIndex = 1;
            // 
            // ToAccountCombo
            // 
            ToAccountCombo.Cursor = Cursors.Hand;
            ToAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToAccountCombo.FormattingEnabled = true;
            ToAccountCombo.Location = new Point(6, 195);
            ToAccountCombo.Name = "ToAccountCombo";
            ToAccountCombo.RightToLeft = RightToLeft.Yes;
            ToAccountCombo.Size = new Size(555, 33);
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
            FromCustomerCombo.Size = new Size(556, 33);
            FromCustomerCombo.TabIndex = 3;
            FromCustomerCombo.SelectedValueChanged += CustomerCombo_SelectedValueChanged;
            // 
            // ToCustomerCombo
            // 
            ToCustomerCombo.Cursor = Cursors.Hand;
            ToCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToCustomerCombo.FormattingEnabled = true;
            ToCustomerCombo.Location = new Point(567, 195);
            ToCustomerCombo.Name = "ToCustomerCombo";
            ToCustomerCombo.RightToLeft = RightToLeft.Yes;
            ToCustomerCombo.Size = new Size(556, 33);
            ToCustomerCombo.TabIndex = 5;
            ToCustomerCombo.Visible = false;
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
            label4.Location = new Point(1028, 231);
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
            CashTxt.Location = new Point(6, 266);
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(1117, 32);
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
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1153, 408);
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
    }
}