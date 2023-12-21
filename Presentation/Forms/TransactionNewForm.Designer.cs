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
            UserAccountCombo = new ComboBox();
            label7 = new Label();
            NewUserCheck = new CheckBox();
            PanelNewUser = new Panel();
            SaveNewUserBtn = new Button();
            CustomerNewUserCartTxt = new TextBox();
            CustomerNewUserNameTxt = new TextBox();
            CustomerCombo = new ComboBox();
            ToCartCombo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            CashTxt = new TextBox();
            FromCartCombo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            PanelNewUser.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.DodgerBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(751, 35);
            label3.TabIndex = 27;
            label3.Text = "ثبت اطلاعات کارت بانکی";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.FromArgb(255, 192, 192);
            MSG.Location = new Point(6, 18);
            MSG.Name = "MSG";
            MSG.Size = new Size(638, 32);
            MSG.TabIndex = 0;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(650, 160);
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
            TransactionTypeCombo.Location = new Point(6, 195);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(739, 33);
            TransactionTypeCombo.TabIndex = 2;
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
            CloseBtn.Location = new Point(188, 478);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 6;
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
            SaveBtn.Location = new Point(441, 478);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(UserAccountCombo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(NewUserCheck);
            groupBox1.Controls.Add(PanelNewUser);
            groupBox1.Controls.Add(CustomerCombo);
            groupBox1.Controls.Add(ToCartCombo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(FromCartCombo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TransactionTypeCombo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 519);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // UserAccountCombo
            // 
            UserAccountCombo.Cursor = Cursors.Hand;
            UserAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            UserAccountCombo.FormattingEnabled = true;
            UserAccountCombo.Location = new Point(6, 349);
            UserAccountCombo.Name = "UserAccountCombo";
            UserAccountCombo.RightToLeft = RightToLeft.Yes;
            UserAccountCombo.Size = new Size(338, 33);
            UserAccountCombo.TabIndex = 44;
            UserAccountCombo.Visible = false;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(200, 320);
            label7.Name = "label7";
            label7.Size = new Size(144, 32);
            label7.TabIndex = 43;
            label7.Text = "از حساب کاربری";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Visible = false;
            // 
            // NewUserCheck
            // 
            NewUserCheck.AutoSize = true;
            NewUserCheck.ForeColor = Color.White;
            NewUserCheck.Location = new Point(641, 234);
            NewUserCheck.Name = "NewUserCheck";
            NewUserCheck.RightToLeft = RightToLeft.Yes;
            NewUserCheck.Size = new Size(104, 29);
            NewUserCheck.TabIndex = 42;
            NewUserCheck.Text = "گیرنده جدید";
            NewUserCheck.UseVisualStyleBackColor = true;
            NewUserCheck.Visible = false;
            NewUserCheck.CheckedChanged += NewUserCheck_CheckedChanged;
            // 
            // PanelNewUser
            // 
            PanelNewUser.Controls.Add(SaveNewUserBtn);
            PanelNewUser.Controls.Add(CustomerNewUserCartTxt);
            PanelNewUser.Controls.Add(CustomerNewUserNameTxt);
            PanelNewUser.Location = new Point(6, 263);
            PanelNewUser.Name = "PanelNewUser";
            PanelNewUser.Size = new Size(739, 55);
            PanelNewUser.TabIndex = 41;
            PanelNewUser.Visible = false;
            // 
            // SaveNewUserBtn
            // 
            SaveNewUserBtn.BackColor = Color.LimeGreen;
            SaveNewUserBtn.Cursor = Cursors.Hand;
            SaveNewUserBtn.FlatAppearance.BorderColor = Color.Green;
            SaveNewUserBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveNewUserBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveNewUserBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveNewUserBtn.FlatStyle = FlatStyle.Flat;
            SaveNewUserBtn.ForeColor = Color.White;
            SaveNewUserBtn.Location = new Point(3, 15);
            SaveNewUserBtn.Name = "SaveNewUserBtn";
            SaveNewUserBtn.Size = new Size(73, 32);
            SaveNewUserBtn.TabIndex = 42;
            SaveNewUserBtn.Text = "ذخیره";
            SaveNewUserBtn.UseVisualStyleBackColor = false;
            // 
            // CustomerNewUserCartTxt
            // 
            CustomerNewUserCartTxt.BackColor = Color.White;
            CustomerNewUserCartTxt.BorderStyle = BorderStyle.FixedSingle;
            CustomerNewUserCartTxt.Location = new Point(82, 15);
            CustomerNewUserCartTxt.Name = "CustomerNewUserCartTxt";
            CustomerNewUserCartTxt.PlaceholderText = "شماره کارت مورد نظر را وارد کنید";
            CustomerNewUserCartTxt.Size = new Size(402, 32);
            CustomerNewUserCartTxt.TabIndex = 43;
            CustomerNewUserCartTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerNewUserNameTxt
            // 
            CustomerNewUserNameTxt.BackColor = Color.White;
            CustomerNewUserNameTxt.BorderStyle = BorderStyle.FixedSingle;
            CustomerNewUserNameTxt.Location = new Point(490, 15);
            CustomerNewUserNameTxt.Name = "CustomerNewUserNameTxt";
            CustomerNewUserNameTxt.PlaceholderText = "نام مشترک مورد نظر را وارد کنید";
            CustomerNewUserNameTxt.Size = new Size(246, 32);
            CustomerNewUserNameTxt.TabIndex = 42;
            CustomerNewUserNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerCombo
            // 
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(6, 53);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(739, 33);
            CustomerCombo.TabIndex = 0;
            CustomerCombo.SelectedValueChanged += CustomerCombo_SelectedValueChanged;
            // 
            // ToCartCombo
            // 
            ToCartCombo.Cursor = Cursors.Hand;
            ToCartCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToCartCombo.FormattingEnabled = true;
            ToCartCombo.Location = new Point(407, 349);
            ToCartCombo.Name = "ToCartCombo";
            ToCartCombo.RightToLeft = RightToLeft.Yes;
            ToCartCombo.Size = new Size(338, 33);
            ToCartCombo.TabIndex = 3;
            ToCartCombo.Visible = false;
            // 
            // label5
            // 
            label5.ForeColor = Color.White;
            label5.Location = new Point(650, 320);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 38;
            label5.Text = "به کارت";
            label5.TextAlign = ContentAlignment.MiddleRight;
            label5.Visible = false;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(650, 385);
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
            CashTxt.Location = new Point(6, 420);
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(739, 32);
            CashTxt.TabIndex = 4;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // FromCartCombo
            // 
            FromCartCombo.Cursor = Cursors.Hand;
            FromCartCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromCartCombo.FormattingEnabled = true;
            FromCartCombo.Location = new Point(6, 124);
            FromCartCombo.Name = "FromCartCombo";
            FromCartCombo.RightToLeft = RightToLeft.Yes;
            FromCartCombo.Size = new Size(739, 33);
            FromCartCombo.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(650, 89);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 34;
            label2.Text = "از کارت";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(650, 18);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 32;
            label1.Text = "از مشترک";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(775, 578);
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
            PanelNewUser.ResumeLayout(false);
            PanelNewUser.PerformLayout();
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
        private ComboBox FromCartCombo;
        private Label label2;
        private Label label1;
        private ComboBox ToCartCombo;
        private Label label5;
        private Label label4;
        private TextBox CashTxt;
        private ComboBox CustomerCombo;
        private Panel PanelNewUser;
        private Button SaveNewUserBtn;
        private TextBox CustomerNewUserCartTxt;
        private TextBox CustomerNewUserNameTxt;
        private CheckBox NewUserCheck;
        private Label label7;
        private ComboBox UserAccountCombo;
    }
}