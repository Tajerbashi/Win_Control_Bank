namespace Account.Presentation.Forms
{
    partial class CartNewForm
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            ParentCartCombo = new ComboBox();
            ShabaCartNumber = new TextBox();
            label1 = new Label();
            ExpireDate = new Atf.UI.DateTimeSelector();
            CartPic = new PictureBox();
            label8 = new Label();
            BlanceTxt = new TextBox();
            label7 = new Label();
            MSG = new Label();
            label6 = new Label();
            AccountNumberTxt = new TextBox();
            label5 = new Label();
            CustomerCombo = new ComboBox();
            label4 = new Label();
            BankCombo = new ComboBox();
            CloseBtn = new Button();
            SaveBtn = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CartPic).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(ParentCartCombo);
            groupBox1.Controls.Add(ShabaCartNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ExpireDate);
            groupBox1.Controls.Add(CartPic);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BlanceTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(AccountNumberTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(CustomerCombo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BankCombo);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(8, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 537);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.ForeColor = Color.FromArgb(240, 236, 229);
            label9.Location = new Point(616, 131);
            label9.Name = "label9";
            label9.Size = new Size(95, 32);
            label9.TabIndex = 39;
            label9.Text = "کارت والد";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ParentCartCombo
            // 
            ParentCartCombo.BackColor = Color.FromArgb(240, 236, 229);
            ParentCartCombo.Cursor = Cursors.Hand;
            ParentCartCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ParentCartCombo.FormattingEnabled = true;
            ParentCartCombo.Location = new Point(317, 166);
            ParentCartCombo.Name = "ParentCartCombo";
            ParentCartCombo.RightToLeft = RightToLeft.Yes;
            ParentCartCombo.Size = new Size(394, 33);
            ParentCartCombo.TabIndex = 38;
            ParentCartCombo.SelectedIndexChanged += ParentCartCombo_SelectedIndexChanged;
            // 
            // ShabaCartNumber
            // 
            ShabaCartNumber.BackColor = Color.FromArgb(240, 236, 229);
            ShabaCartNumber.BorderStyle = BorderStyle.FixedSingle;
            ShabaCartNumber.Location = new Point(6, 378);
            ShabaCartNumber.MaxLength = 40;
            ShabaCartNumber.Name = "ShabaCartNumber";
            ShabaCartNumber.PlaceholderText = "IR --------------------------------";
            ShabaCartNumber.Size = new Size(705, 32);
            ShabaCartNumber.TabIndex = 3;
            ShabaCartNumber.TextAlign = HorizontalAlignment.Center;
            ShabaCartNumber.KeyPress += ShabaCartNumber_KeyPress;
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(240, 236, 229);
            label1.Location = new Point(578, 343);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 37;
            label1.Text = "شماره کارت شبا";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExpireDate
            // 
            ExpireDate.BackColor = Color.FromArgb(240, 236, 229);
            ExpireDate.Location = new Point(362, 447);
            ExpireDate.Name = "ExpireDate";
            ExpireDate.Size = new Size(349, 33);
            ExpireDate.TabIndex = 4;
            // 
            // CartPic
            // 
            CartPic.BackColor = Color.FromArgb(240, 236, 229);
            CartPic.Location = new Point(6, 70);
            CartPic.Name = "CartPic";
            CartPic.Size = new Size(305, 139);
            CartPic.TabIndex = 35;
            CartPic.TabStop = false;
            // 
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(203, 413);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 34;
            label8.Text = "موجودی اولیه";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlanceTxt
            // 
            BlanceTxt.BackColor = Color.FromArgb(240, 236, 229);
            BlanceTxt.BorderStyle = BorderStyle.FixedSingle;
            BlanceTxt.Location = new Point(6, 448);
            BlanceTxt.MaxLength = 15;
            BlanceTxt.Name = "BlanceTxt";
            BlanceTxt.PlaceholderText = "قیمت اولیه را وارد کنید";
            BlanceTxt.Size = new Size(349, 32);
            BlanceTxt.TabIndex = 5;
            BlanceTxt.TextAlign = HorizontalAlignment.Center;
            BlanceTxt.KeyPress += BlanceTxt_KeyPress;
            // 
            // label7
            // 
            label7.ForeColor = Color.FromArgb(240, 236, 229);
            label7.Location = new Point(616, 413);
            label7.Name = "label7";
            label7.Size = new Size(95, 32);
            label7.TabIndex = 32;
            label7.Text = "تاریخ انقضاء";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MSG
            // 
            MSG.BackColor = Color.FromArgb(240, 236, 229);
            MSG.ForeColor = Color.Coral;
            MSG.Location = new Point(6, 28);
            MSG.Name = "MSG";
            MSG.Size = new Size(705, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            MSG.Visible = false;
            // 
            // label6
            // 
            label6.ForeColor = Color.FromArgb(240, 236, 229);
            label6.Location = new Point(616, 273);
            label6.Name = "label6";
            label6.Size = new Size(95, 32);
            label6.TabIndex = 31;
            label6.Text = "شماره کارت";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AccountNumberTxt
            // 
            AccountNumberTxt.BackColor = Color.FromArgb(240, 236, 229);
            AccountNumberTxt.BorderStyle = BorderStyle.FixedSingle;
            AccountNumberTxt.Location = new Point(6, 308);
            AccountNumberTxt.MaxLength = 16;
            AccountNumberTxt.Name = "AccountNumberTxt";
            AccountNumberTxt.PlaceholderText = "- - - -     - - - -     - - - -     - - - -";
            AccountNumberTxt.Size = new Size(705, 32);
            AccountNumberTxt.TabIndex = 2;
            AccountNumberTxt.TextAlign = HorizontalAlignment.Center;
            AccountNumberTxt.KeyPress += AccountNumberTxt_KeyPress;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(240, 236, 229);
            label5.Location = new Point(616, 202);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 29;
            label5.Text = "نام مشترک";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomerCombo
            // 
            CustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(6, 237);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(705, 33);
            CustomerCombo.TabIndex = 1;
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(240, 236, 229);
            label4.Location = new Point(616, 60);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 27;
            label4.Text = "نام بانک";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankCombo
            // 
            BankCombo.BackColor = Color.FromArgb(240, 236, 229);
            BankCombo.Cursor = Cursors.Hand;
            BankCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BankCombo.FormattingEnabled = true;
            BankCombo.Location = new Point(317, 95);
            BankCombo.Name = "BankCombo";
            BankCombo.RightToLeft = RightToLeft.Yes;
            BankCombo.Size = new Size(394, 33);
            BankCombo.TabIndex = 0;
            BankCombo.SelectedIndexChanged += BankCombo_SelectedIndexChanged;
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
            CloseBtn.Location = new Point(177, 488);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 7;
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
            SaveBtn.Location = new Point(418, 488);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 9);
            label3.Name = "label3";
            label3.Size = new Size(718, 35);
            label3.TabIndex = 25;
            label3.Text = "ثبت اطلاعات کارت بانکی";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(732, 595);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CartNewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CartNewForm";
            Load += CartNewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CartPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label MSG;
        private RichTextBox DescriptionTxt;
        private PictureBox UserPicture;
        private Label label2;
        private Button CloseBtn;
        private Button SaveBtn;
        private Label label3;
        private Label label4;
        private ComboBox BankCombo;
        private Label label6;
        private TextBox AccountNumberTxt;
        private Label label5;
        private ComboBox CustomerCombo;
        private Label label8;
        private TextBox BlanceTxt;
        private Label label7;
        private PictureBox CartPic;
        private Atf.UI.DateTimeSelector ExpireDate;
        private TextBox ShabaCartNumber;
        private Label label1;
        private Label label9;
        private ComboBox ParentCartCombo;
    }
}