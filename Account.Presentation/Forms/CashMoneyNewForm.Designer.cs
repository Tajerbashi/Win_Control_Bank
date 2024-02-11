namespace Account.Presentation.Forms
{
    partial class CashMoneyNewForm
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
            AccountCombo = new ComboBox();
            MSG = new Label();
            DescriptionTxt = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            PageLbl = new Label();
            CashTxt = new TextBox();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(629, 35);
            label3.TabIndex = 28;
            label3.Text = "ثبت اطلاعات برداشت از کارت بصورت نقدی";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(AccountCombo);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(DescriptionTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 346);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // AccountCombo
            // 
            AccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            AccountCombo.Cursor = Cursors.Hand;
            AccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountCombo.FormattingEnabled = true;
            AccountCombo.Location = new Point(9, 57);
            AccountCombo.Name = "AccountCombo";
            AccountCombo.RightToLeft = RightToLeft.Yes;
            AccountCombo.Size = new Size(614, 33);
            AccountCombo.TabIndex = 24;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.Black;
            MSG.Location = new Point(9, 22);
            MSG.Name = "MSG";
            MSG.Size = new Size(513, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            MSG.Visible = false;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.BackColor = Color.FromArgb(240, 236, 229);
            DescriptionTxt.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTxt.Location = new Point(9, 195);
            DescriptionTxt.MaxLength = 5000;
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.RightToLeft = RightToLeft.Yes;
            DescriptionTxt.Size = new Size(614, 105);
            DescriptionTxt.TabIndex = 2;
            DescriptionTxt.Text = "";
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(528, 160);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 19;
            label2.Text = "توضیحات";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(528, 90);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 18;
            label1.Text = "مبلغ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(528, 22);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(95, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "شماره حساب";
            PageLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.FromArgb(240, 236, 229);
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(9, 125);
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ برداشتی";
            CashTxt.Size = new Size(614, 32);
            CashTxt.TabIndex = 1;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            CashTxt.KeyPress += CashTxt_KeyPress;
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
            CloseBtn.Location = new Point(114, 308);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 4;
            CloseBtn.Text = "لفو عملیات";
            CloseBtn.UseVisualStyleBackColor = false;
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
            SaveBtn.Location = new Point(393, 308);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CashMoneyNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(653, 401);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CashMoneyNewForm";
            Text = "CashMoneyNewForm";
            Load += CashMoneyNewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label MSG;
        private RichTextBox DescriptionTxt;
        private Label label2;
        private Label label1;
        private Label PageLbl;
        private TextBox CashTxt;
        private Button CloseBtn;
        private Button SaveBtn;
        private ComboBox AccountCombo;
    }
}