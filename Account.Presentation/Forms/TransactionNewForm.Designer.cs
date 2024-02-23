namespace Account.Presentation.Forms
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
            TCustomerCombo = new ComboBox();
            L6 = new Label();
            FCustomerCombo = new ComboBox();
            L5 = new Label();
            ProgressController = new ProgressBar();
            AccountCheck = new CheckBox();
            DegreeAccountCombo = new ComboBox();
            label11 = new Label();
            ToAccountLBL = new Label();
            ToCustomerLBL = new Label();
            label13 = new Label();
            label4 = new Label();
            CashTxt = new TextBox();
            DescTxt = new TextBox();
            NewDataBtn = new Button();
            NewDataPanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            SaveNewDataBtn = new Button();
            NewCartNumberTxt = new TextBox();
            NewBankNameTxt = new TextBox();
            NewCustomerNameTxt = new TextBox();
            label10 = new Label();
            FromAccountLBL = new Label();
            FromCustomerLBL = new Label();
            TransactionKindCombo = new ComboBox();
            label2 = new Label();
            FromAccountCombo = new ComboBox();
            L2 = new Label();
            label8 = new Label();
            BlanceTypeCombo = new ComboBox();
            ToAccountCombo = new ComboBox();
            L4 = new Label();
            FromCustomerCombo = new ComboBox();
            ToCustomerCombo = new ComboBox();
            L3 = new Label();
            L1 = new Label();
            groupBox1.SuspendLayout();
            NewDataPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(1226, 35);
            label3.TabIndex = 27;
            label3.Text = "تراکنش جدید";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MSG
            // 
            MSG.FlatStyle = FlatStyle.Flat;
            MSG.ForeColor = Color.FromArgb(240, 236, 150);
            MSG.Location = new Point(4, 581);
            MSG.Name = "MSG";
            MSG.Size = new Size(1219, 38);
            MSG.TabIndex = 0;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(1122, 28);
            label6.Name = "label6";
            label6.Size = new Size(95, 32);
            label6.TabIndex = 31;
            label6.Text = "نوع تراکنش";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionTypeCombo
            // 
            TransactionTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            TransactionTypeCombo.Cursor = Cursors.Hand;
            TransactionTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionTypeCombo.FormattingEnabled = true;
            TransactionTypeCombo.Location = new Point(863, 63);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(352, 33);
            TransactionTypeCombo.TabIndex = 0;
            TransactionTypeCombo.SelectedIndexChanged += TransactionTypeCombo_SelectedIndexChanged;
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
            CloseBtn.Location = new Point(338, 542);
            CloseBtn.Margin = new Padding(4, 5, 4, 5);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(121, 32);
            CloseBtn.TabIndex = 11;
            CloseBtn.Text = "لغو عملیات";
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.ForestGreen;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            SaveBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(767, 542);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 10;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(TCustomerCombo);
            groupBox1.Controls.Add(L6);
            groupBox1.Controls.Add(FCustomerCombo);
            groupBox1.Controls.Add(L5);
            groupBox1.Controls.Add(ProgressController);
            groupBox1.Controls.Add(AccountCheck);
            groupBox1.Controls.Add(DegreeAccountCombo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(ToAccountLBL);
            groupBox1.Controls.Add(ToCustomerLBL);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CashTxt);
            groupBox1.Controls.Add(DescTxt);
            groupBox1.Controls.Add(NewDataBtn);
            groupBox1.Controls.Add(NewDataPanel);
            groupBox1.Controls.Add(FromAccountLBL);
            groupBox1.Controls.Add(FromCustomerLBL);
            groupBox1.Controls.Add(TransactionKindCombo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(FromAccountCombo);
            groupBox1.Controls.Add(L2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(BlanceTypeCombo);
            groupBox1.Controls.Add(ToAccountCombo);
            groupBox1.Controls.Add(L4);
            groupBox1.Controls.Add(FromCustomerCombo);
            groupBox1.Controls.Add(ToCustomerCombo);
            groupBox1.Controls.Add(L3);
            groupBox1.Controls.Add(L1);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TransactionTypeCombo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(9, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1226, 624);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TCustomerCombo
            // 
            TCustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            TCustomerCombo.Cursor = Cursors.Hand;
            TCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TCustomerCombo.FormattingEnabled = true;
            TCustomerCombo.Location = new Point(55, 246);
            TCustomerCombo.Name = "TCustomerCombo";
            TCustomerCombo.RightToLeft = RightToLeft.Yes;
            TCustomerCombo.Size = new Size(428, 33);
            TCustomerCombo.TabIndex = 70;
            TCustomerCombo.Visible = false;
            // 
            // L6
            // 
            L6.ForeColor = Color.White;
            L6.Location = new Point(479, 246);
            L6.Name = "L6";
            L6.Size = new Size(121, 32);
            L6.TabIndex = 69;
            L6.Text = "به حساب مشترک";
            L6.TextAlign = ContentAlignment.MiddleRight;
            L6.Visible = false;
            // 
            // FCustomerCombo
            // 
            FCustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            FCustomerCombo.Cursor = Cursors.Hand;
            FCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FCustomerCombo.FormattingEnabled = true;
            FCustomerCombo.Location = new Point(621, 247);
            FCustomerCombo.Name = "FCustomerCombo";
            FCustomerCombo.RightToLeft = RightToLeft.Yes;
            FCustomerCombo.Size = new Size(476, 33);
            FCustomerCombo.TabIndex = 68;
            FCustomerCombo.Visible = false;
            // 
            // L5
            // 
            L5.ForeColor = Color.White;
            L5.Location = new Point(1103, 247);
            L5.Name = "L5";
            L5.Size = new Size(112, 32);
            L5.TabIndex = 67;
            L5.Text = "از حساب مشترک";
            L5.TextAlign = ContentAlignment.MiddleRight;
            L5.Visible = false;
            // 
            // ProgressController
            // 
            ProgressController.Location = new Point(0, 1);
            ProgressController.Name = "ProgressController";
            ProgressController.Size = new Size(1226, 10);
            ProgressController.TabIndex = 28;
            // 
            // AccountCheck
            // 
            AccountCheck.ForeColor = Color.White;
            AccountCheck.Location = new Point(9, 63);
            AccountCheck.Name = "AccountCheck";
            AccountCheck.RightToLeft = RightToLeft.Yes;
            AccountCheck.Size = new Size(109, 33);
            AccountCheck.TabIndex = 4;
            AccountCheck.Text = "حساب اصلی";
            AccountCheck.UseVisualStyleBackColor = true;
            // 
            // DegreeAccountCombo
            // 
            DegreeAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            DegreeAccountCombo.Cursor = Cursors.Hand;
            DegreeAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            DegreeAccountCombo.FormattingEnabled = true;
            DegreeAccountCombo.Location = new Point(120, 63);
            DegreeAccountCombo.Name = "DegreeAccountCombo";
            DegreeAccountCombo.RightToLeft = RightToLeft.Yes;
            DegreeAccountCombo.Size = new Size(237, 33);
            DegreeAccountCombo.TabIndex = 3;
            // 
            // label11
            // 
            label11.ForeColor = Color.White;
            label11.Location = new Point(262, 28);
            label11.Name = "label11";
            label11.Size = new Size(95, 32);
            label11.TabIndex = 66;
            label11.Text = "درجه حساب";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ToAccountLBL
            // 
            ToAccountLBL.ForeColor = Color.FromArgb(240, 236, 150);
            ToAccountLBL.Location = new Point(16, 170);
            ToAccountLBL.Name = "ToAccountLBL";
            ToAccountLBL.Size = new Size(253, 32);
            ToAccountLBL.TabIndex = 61;
            ToAccountLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToCustomerLBL
            // 
            ToCustomerLBL.ForeColor = Color.FromArgb(240, 236, 150);
            ToCustomerLBL.Location = new Point(620, 170);
            ToCustomerLBL.Name = "ToCustomerLBL";
            ToCustomerLBL.Size = new Size(253, 32);
            ToCustomerLBL.TabIndex = 60;
            ToCustomerLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.ForeColor = Color.White;
            label13.Location = new Point(286, 419);
            label13.Name = "label13";
            label13.Size = new Size(47, 32);
            label13.TabIndex = 64;
            label13.Text = "تومان";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(794, 386);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 63;
            label4.Text = "مبلغ تراکنش";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CashTxt
            // 
            CashTxt.BackColor = Color.FromArgb(240, 236, 150);
            CashTxt.BorderStyle = BorderStyle.FixedSingle;
            CashTxt.Location = new Point(339, 421);
            CashTxt.MaxLength = 15;
            CashTxt.Name = "CashTxt";
            CashTxt.PlaceholderText = "مبلغ مورد نظر را وارد کنید";
            CashTxt.Size = new Size(550, 32);
            CashTxt.TabIndex = 8;
            CashTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // DescTxt
            // 
            DescTxt.BackColor = Color.FromArgb(240, 236, 150);
            DescTxt.BorderStyle = BorderStyle.FixedSingle;
            DescTxt.Location = new Point(21, 471);
            DescTxt.MaxLength = 500;
            DescTxt.Multiline = true;
            DescTxt.Name = "DescTxt";
            DescTxt.PlaceholderText = "توضیحات مورد نظر را وارد کنید";
            DescTxt.Size = new Size(1184, 64);
            DescTxt.TabIndex = 9;
            DescTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewDataBtn
            // 
            NewDataBtn.BackColor = Color.ForestGreen;
            NewDataBtn.Cursor = Cursors.Hand;
            NewDataBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            NewDataBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            NewDataBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            NewDataBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            NewDataBtn.FlatStyle = FlatStyle.Flat;
            NewDataBtn.ForeColor = Color.White;
            NewDataBtn.Location = new Point(16, 246);
            NewDataBtn.Name = "NewDataBtn";
            NewDataBtn.Size = new Size(33, 33);
            NewDataBtn.TabIndex = 13;
            NewDataBtn.Text = "+";
            NewDataBtn.UseVisualStyleBackColor = false;
            NewDataBtn.Visible = false;
            NewDataBtn.Click += NewDataBtn_Click;
            // 
            // NewDataPanel
            // 
            NewDataPanel.BorderStyle = BorderStyle.FixedSingle;
            NewDataPanel.Controls.Add(label15);
            NewDataPanel.Controls.Add(label14);
            NewDataPanel.Controls.Add(SaveNewDataBtn);
            NewDataPanel.Controls.Add(NewCartNumberTxt);
            NewDataPanel.Controls.Add(NewBankNameTxt);
            NewDataPanel.Controls.Add(NewCustomerNameTxt);
            NewDataPanel.Controls.Add(label10);
            NewDataPanel.Location = new Point(9, 290);
            NewDataPanel.Name = "NewDataPanel";
            NewDataPanel.Size = new Size(1208, 93);
            NewDataPanel.TabIndex = 14;
            NewDataPanel.Visible = false;
            // 
            // label15
            // 
            label15.ForeColor = Color.White;
            label15.Location = new Point(416, 5);
            label15.Name = "label15";
            label15.Size = new Size(85, 32);
            label15.TabIndex = 59;
            label15.Text = "شماره کارت";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.ForeColor = Color.White;
            label14.Location = new Point(745, 5);
            label14.Name = "label14";
            label14.Size = new Size(104, 32);
            label14.TabIndex = 58;
            label14.Text = "نام بانک کارت";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SaveNewDataBtn
            // 
            SaveNewDataBtn.BackColor = Color.ForestGreen;
            SaveNewDataBtn.Cursor = Cursors.Hand;
            SaveNewDataBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            SaveNewDataBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveNewDataBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveNewDataBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveNewDataBtn.FlatStyle = FlatStyle.Flat;
            SaveNewDataBtn.ForeColor = Color.White;
            SaveNewDataBtn.Location = new Point(13, 40);
            SaveNewDataBtn.Name = "SaveNewDataBtn";
            SaveNewDataBtn.Size = new Size(129, 32);
            SaveNewDataBtn.TabIndex = 3;
            SaveNewDataBtn.Text = "ذخیره اطلاعات";
            SaveNewDataBtn.UseVisualStyleBackColor = false;
            SaveNewDataBtn.Click += SaveNewDataBtn_Click;
            // 
            // NewCartNumberTxt
            // 
            NewCartNumberTxt.BackColor = Color.FromArgb(240, 236, 150);
            NewCartNumberTxt.BorderStyle = BorderStyle.FixedSingle;
            NewCartNumberTxt.Location = new Point(159, 40);
            NewCartNumberTxt.MaxLength = 16;
            NewCartNumberTxt.Name = "NewCartNumberTxt";
            NewCartNumberTxt.PlaceholderText = "شماره کارت را وارد کنید";
            NewCartNumberTxt.Size = new Size(342, 32);
            NewCartNumberTxt.TabIndex = 2;
            NewCartNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewBankNameTxt
            // 
            NewBankNameTxt.BackColor = Color.FromArgb(240, 236, 150);
            NewBankNameTxt.BorderStyle = BorderStyle.FixedSingle;
            NewBankNameTxt.Location = new Point(507, 40);
            NewBankNameTxt.MaxLength = 25;
            NewBankNameTxt.Name = "NewBankNameTxt";
            NewBankNameTxt.PlaceholderText = "نام بانک کارت مقصد را وارد کنید";
            NewBankNameTxt.Size = new Size(342, 32);
            NewBankNameTxt.TabIndex = 1;
            NewBankNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // NewCustomerNameTxt
            // 
            NewCustomerNameTxt.BackColor = Color.FromArgb(240, 236, 150);
            NewCustomerNameTxt.BorderStyle = BorderStyle.FixedSingle;
            NewCustomerNameTxt.Location = new Point(855, 40);
            NewCustomerNameTxt.MaxLength = 50;
            NewCustomerNameTxt.Name = "NewCustomerNameTxt";
            NewCustomerNameTxt.PlaceholderText = "نام مالک کارت را وارد کنید";
            NewCustomerNameTxt.Size = new Size(342, 32);
            NewCustomerNameTxt.TabIndex = 0;
            NewCustomerNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(1093, 5);
            label10.Name = "label10";
            label10.Size = new Size(104, 32);
            label10.TabIndex = 39;
            label10.Text = "نام مالک کارت";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromAccountLBL
            // 
            FromAccountLBL.ForeColor = Color.FromArgb(240, 236, 150);
            FromAccountLBL.Location = new Point(16, 99);
            FromAccountLBL.Name = "FromAccountLBL";
            FromAccountLBL.Size = new Size(253, 32);
            FromAccountLBL.TabIndex = 51;
            FromAccountLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FromCustomerLBL
            // 
            FromCustomerLBL.ForeColor = Color.FromArgb(240, 236, 150);
            FromCustomerLBL.Location = new Point(621, 99);
            FromCustomerLBL.Name = "FromCustomerLBL";
            FromCustomerLBL.Size = new Size(254, 32);
            FromCustomerLBL.TabIndex = 50;
            FromCustomerLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TransactionKindCombo
            // 
            TransactionKindCombo.BackColor = Color.FromArgb(240, 236, 229);
            TransactionKindCombo.Cursor = Cursors.Hand;
            TransactionKindCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            TransactionKindCombo.FormattingEnabled = true;
            TransactionKindCombo.Location = new Point(363, 63);
            TransactionKindCombo.Name = "TransactionKindCombo";
            TransactionKindCombo.RightToLeft = RightToLeft.Yes;
            TransactionKindCombo.Size = new Size(237, 33);
            TransactionKindCombo.TabIndex = 2;
            TransactionKindCombo.SelectedIndexChanged += TransactionKindCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(505, 28);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 49;
            label2.Text = "جنس تراکنش";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FromAccountCombo
            // 
            FromAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            FromAccountCombo.Cursor = Cursors.Hand;
            FromAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromAccountCombo.FormattingEnabled = true;
            FromAccountCombo.Location = new Point(16, 134);
            FromAccountCombo.Name = "FromAccountCombo";
            FromAccountCombo.RightToLeft = RightToLeft.Yes;
            FromAccountCombo.Size = new Size(584, 33);
            FromAccountCombo.TabIndex = 5;
            FromAccountCombo.SelectedIndexChanged += FromAccountCombo_SelectedIndexChanged;
            // 
            // L2
            // 
            L2.ForeColor = Color.White;
            L2.Location = new Point(434, 99);
            L2.Name = "L2";
            L2.Size = new Size(172, 32);
            L2.TabIndex = 48;
            L2.Text = "از حساب کارت مبداء";
            L2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(767, 28);
            label8.Name = "label8";
            label8.Size = new Size(90, 32);
            label8.TabIndex = 46;
            label8.Text = "نوع حساب";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlanceTypeCombo
            // 
            BlanceTypeCombo.BackColor = Color.FromArgb(240, 236, 229);
            BlanceTypeCombo.Cursor = Cursors.Hand;
            BlanceTypeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            BlanceTypeCombo.FormattingEnabled = true;
            BlanceTypeCombo.Location = new Point(620, 63);
            BlanceTypeCombo.Name = "BlanceTypeCombo";
            BlanceTypeCombo.RightToLeft = RightToLeft.Yes;
            BlanceTypeCombo.Size = new Size(237, 33);
            BlanceTypeCombo.TabIndex = 1;
            BlanceTypeCombo.SelectedIndexChanged += BlanceTypeCombo_SelectedIndexChanged;
            // 
            // ToAccountCombo
            // 
            ToAccountCombo.BackColor = Color.FromArgb(240, 236, 229);
            ToAccountCombo.Cursor = Cursors.Hand;
            ToAccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToAccountCombo.FormattingEnabled = true;
            ToAccountCombo.Location = new Point(16, 205);
            ToAccountCombo.Name = "ToAccountCombo";
            ToAccountCombo.RightToLeft = RightToLeft.Yes;
            ToAccountCombo.Size = new Size(585, 33);
            ToAccountCombo.TabIndex = 7;
            ToAccountCombo.Visible = false;
            ToAccountCombo.SelectedIndexChanged += ToAccountCombo_SelectedIndexChanged;
            // 
            // L4
            // 
            L4.ForeColor = Color.White;
            L4.Location = new Point(434, 170);
            L4.Name = "L4";
            L4.Size = new Size(171, 32);
            L4.TabIndex = 43;
            L4.Text = "به حساب کارت مقصد";
            L4.TextAlign = ContentAlignment.MiddleRight;
            L4.Visible = false;
            // 
            // FromCustomerCombo
            // 
            FromCustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            FromCustomerCombo.Cursor = Cursors.Hand;
            FromCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            FromCustomerCombo.FormattingEnabled = true;
            FromCustomerCombo.Location = new Point(621, 134);
            FromCustomerCombo.Name = "FromCustomerCombo";
            FromCustomerCombo.RightToLeft = RightToLeft.Yes;
            FromCustomerCombo.Size = new Size(589, 33);
            FromCustomerCombo.TabIndex = 4;
            FromCustomerCombo.SelectedIndexChanged += FromCustomerCombo_SelectedIndexChanged;
            // 
            // ToCustomerCombo
            // 
            ToCustomerCombo.BackColor = Color.FromArgb(240, 236, 229);
            ToCustomerCombo.Cursor = Cursors.Hand;
            ToCustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            ToCustomerCombo.FormattingEnabled = true;
            ToCustomerCombo.Location = new Point(621, 205);
            ToCustomerCombo.Name = "ToCustomerCombo";
            ToCustomerCombo.RightToLeft = RightToLeft.Yes;
            ToCustomerCombo.Size = new Size(589, 33);
            ToCustomerCombo.TabIndex = 6;
            ToCustomerCombo.Visible = false;
            ToCustomerCombo.SelectedIndexChanged += ToCustomerCombo_SelectedIndexChanged;
            // 
            // L3
            // 
            L3.ForeColor = Color.White;
            L3.Location = new Point(1092, 170);
            L3.Name = "L3";
            L3.Size = new Size(123, 32);
            L3.TabIndex = 38;
            L3.Text = "به کارت مقصد";
            L3.TextAlign = ContentAlignment.MiddleRight;
            L3.Visible = false;
            // 
            // L1
            // 
            L1.ForeColor = Color.White;
            L1.Location = new Point(1120, 99);
            L1.Name = "L1";
            L1.Size = new Size(95, 32);
            L1.TabIndex = 32;
            L1.Text = "از کارت مبداء";
            L1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(1244, 680);
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
        private Label L1;
        private ComboBox ToCustomerCombo;
        private Label L3;
        private ComboBox FromCustomerCombo;
        private Label L4;
        private ComboBox ToAccountCombo;
        private Label label8;
        private ComboBox BlanceTypeCombo;
        private ComboBox FromAccountCombo;
        private Label L2;
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
        private Button NewDataBtn;
        private TextBox DescTxt;
        private Label ToAccountLBL;
        private Label ToCustomerLBL;
        private Label label13;
        private Label label4;
        private TextBox CashTxt;
        private Label label15;
        private Label label14;
        private ComboBox DegreeAccountCombo;
        private Label label11;
        private CheckBox AccountCheck;
        private ProgressBar ProgressController;
        private Label L5;
        private ComboBox FCustomerCombo;
        private ComboBox TCustomerCombo;
        private Label L6;
    }
}