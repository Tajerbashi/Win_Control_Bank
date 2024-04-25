namespace Presentation
{
    partial class MainFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            SettlemantBtn = new Button();
            ExitBtn = new Button();
            BankBtn = new Button();
            OnlineExchangeBtn = new Button();
            label1 = new Label();
            LockBtn = new Button();
            ClockLbl = new Label();
            SettingBtn = new Button();
            BalanceBtn = new Button();
            TaransactionBtn = new Button();
            CashMoneyBtn = new Button();
            CalculateBtn = new Button();
            ReportBtn = new Button();
            UserBtn = new Button();
            CartBtn = new Button();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            MainPanel = new Panel();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(SettlemantBtn);
            groupBox1.Controls.Add(ExitBtn);
            groupBox1.Controls.Add(BankBtn);
            groupBox1.Controls.Add(OnlineExchangeBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LockBtn);
            groupBox1.Controls.Add(ClockLbl);
            groupBox1.Controls.Add(SettingBtn);
            groupBox1.Controls.Add(BalanceBtn);
            groupBox1.Controls.Add(TaransactionBtn);
            groupBox1.Controls.Add(CashMoneyBtn);
            groupBox1.Controls.Add(CalculateBtn);
            groupBox1.Controls.Add(ReportBtn);
            groupBox1.Controls.Add(UserBtn);
            groupBox1.Controls.Add(CartBtn);
            groupBox1.Controls.Add(progressBar2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1162, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 770);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مدیریت";
            // 
            // SettlemantBtn
            // 
            SettlemantBtn.BackColor = Color.Transparent;
            SettlemantBtn.Cursor = Cursors.Hand;
            SettlemantBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            SettlemantBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            SettlemantBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            SettlemantBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            SettlemantBtn.FlatStyle = FlatStyle.Flat;
            SettlemantBtn.ForeColor = Color.White;
            SettlemantBtn.Location = new Point(32, 363);
            SettlemantBtn.Name = "SettlemantBtn";
            SettlemantBtn.Size = new Size(190, 40);
            SettlemantBtn.TabIndex = 5;
            SettlemantBtn.Text = "واریزی های بانکی";
            SettlemantBtn.UseVisualStyleBackColor = false;
            SettlemantBtn.Click += SettlemantBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.OrangeRed;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            ExitBtn.FlatAppearance.BorderSize = 2;
            ExitBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.Red;
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.FromArgb(255, 224, 192);
            ExitBtn.Location = new Point(131, 722);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(114, 39);
            ExitBtn.TabIndex = 12;
            ExitBtn.Text = "خروج";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BankBtn
            // 
            BankBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BankBtn.BackColor = Color.FromArgb(255, 100, 0);
            BankBtn.Cursor = Cursors.Hand;
            BankBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            BankBtn.FlatAppearance.BorderSize = 2;
            BankBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(250, 0, 0);
            BankBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 0, 0);
            BankBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0);
            BankBtn.FlatStyle = FlatStyle.Flat;
            BankBtn.Font = new Font("IRANSansWeb", 12F);
            BankBtn.ForeColor = Color.White;
            BankBtn.Location = new Point(187, 182);
            BankBtn.Name = "BankBtn";
            BankBtn.Size = new Size(57, 63);
            BankBtn.TabIndex = 0;
            BankBtn.Text = "بانک";
            BankBtn.UseVisualStyleBackColor = false;
            BankBtn.Click += BankBtn_Click;
            // 
            // OnlineExchangeBtn
            // 
            OnlineExchangeBtn.BackColor = Color.FromArgb(50, 60, 80);
            OnlineExchangeBtn.Cursor = Cursors.Hand;
            OnlineExchangeBtn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            OnlineExchangeBtn.FlatAppearance.CheckedBackColor = Color.White;
            OnlineExchangeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 40, 80);
            OnlineExchangeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 80, 60);
            OnlineExchangeBtn.FlatStyle = FlatStyle.Flat;
            OnlineExchangeBtn.Font = new Font("IRANSansWeb", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnlineExchangeBtn.ForeColor = Color.White;
            OnlineExchangeBtn.Location = new Point(10, 129);
            OnlineExchangeBtn.Name = "OnlineExchangeBtn";
            OnlineExchangeBtn.Size = new Size(234, 47);
            OnlineExchangeBtn.TabIndex = 0;
            OnlineExchangeBtn.Text = "صرافی آنلاین";
            OnlineExchangeBtn.UseVisualStyleBackColor = false;
            OnlineExchangeBtn.Click += OnlineExchangeBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.SizeAll;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("IRANSansWeb", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(234, 78);
            label1.TabIndex = 8;
            label1.Text = "مدیریت و حسابداری";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // LockBtn
            // 
            LockBtn.BackColor = Color.DodgerBlue;
            LockBtn.Cursor = Cursors.Hand;
            LockBtn.FlatAppearance.BorderColor = Color.RoyalBlue;
            LockBtn.FlatAppearance.BorderSize = 2;
            LockBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            LockBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            LockBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            LockBtn.FlatStyle = FlatStyle.Flat;
            LockBtn.ForeColor = Color.White;
            LockBtn.Location = new Point(9, 722);
            LockBtn.Name = "LockBtn";
            LockBtn.Size = new Size(114, 39);
            LockBtn.TabIndex = 11;
            LockBtn.Text = "قفل";
            LockBtn.UseVisualStyleBackColor = false;
            // 
            // ClockLbl
            // 
            ClockLbl.ForeColor = Color.White;
            ClockLbl.Location = new Point(10, 676);
            ClockLbl.Name = "ClockLbl";
            ClockLbl.Size = new Size(234, 41);
            ClockLbl.TabIndex = 10;
            ClockLbl.Text = "ساعت";
            ClockLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingBtn
            // 
            SettingBtn.BackColor = Color.FromArgb(64, 64, 64);
            SettingBtn.Cursor = Cursors.Hand;
            SettingBtn.FlatAppearance.BorderColor = Color.Gainsboro;
            SettingBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            SettingBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            SettingBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            SettingBtn.FlatStyle = FlatStyle.Flat;
            SettingBtn.ForeColor = Color.White;
            SettingBtn.Location = new Point(32, 633);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(190, 40);
            SettingBtn.TabIndex = 10;
            SettingBtn.Text = "تنظیمات";
            SettingBtn.UseVisualStyleBackColor = false;
            SettingBtn.Click += SettingBtn_Click;
            // 
            // BalanceBtn
            // 
            BalanceBtn.BackColor = Color.Transparent;
            BalanceBtn.Cursor = Cursors.Hand;
            BalanceBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            BalanceBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            BalanceBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            BalanceBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            BalanceBtn.FlatStyle = FlatStyle.Flat;
            BalanceBtn.ForeColor = Color.White;
            BalanceBtn.Location = new Point(32, 498);
            BalanceBtn.Name = "BalanceBtn";
            BalanceBtn.Size = new Size(190, 40);
            BalanceBtn.TabIndex = 7;
            BalanceBtn.Text = "مدیریت موجودی حساب";
            BalanceBtn.UseVisualStyleBackColor = false;
            BalanceBtn.Click += BalanceBtn_Click;
            // 
            // TaransactionBtn
            // 
            TaransactionBtn.BackColor = Color.Transparent;
            TaransactionBtn.Cursor = Cursors.Hand;
            TaransactionBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            TaransactionBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            TaransactionBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            TaransactionBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            TaransactionBtn.FlatStyle = FlatStyle.Flat;
            TaransactionBtn.ForeColor = Color.White;
            TaransactionBtn.Location = new Point(32, 318);
            TaransactionBtn.Name = "TaransactionBtn";
            TaransactionBtn.Size = new Size(190, 40);
            TaransactionBtn.TabIndex = 4;
            TaransactionBtn.Text = "تراکنش ها";
            TaransactionBtn.UseVisualStyleBackColor = false;
            TaransactionBtn.Click += TaransactionBtn_Click;
            // 
            // CashMoneyBtn
            // 
            CashMoneyBtn.BackColor = Color.Transparent;
            CashMoneyBtn.Cursor = Cursors.Hand;
            CashMoneyBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            CashMoneyBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            CashMoneyBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            CashMoneyBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            CashMoneyBtn.FlatStyle = FlatStyle.Flat;
            CashMoneyBtn.ForeColor = Color.White;
            CashMoneyBtn.Location = new Point(32, 408);
            CashMoneyBtn.Name = "CashMoneyBtn";
            CashMoneyBtn.Size = new Size(190, 40);
            CashMoneyBtn.TabIndex = 6;
            CashMoneyBtn.Text = "تراکنش های نقدی";
            CashMoneyBtn.UseVisualStyleBackColor = false;
            CashMoneyBtn.Click += CashMoneyBtn_Click;
            // 
            // CalculateBtn
            // 
            CalculateBtn.BackColor = Color.Transparent;
            CalculateBtn.Cursor = Cursors.Hand;
            CalculateBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            CalculateBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            CalculateBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            CalculateBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            CalculateBtn.FlatStyle = FlatStyle.Flat;
            CalculateBtn.ForeColor = Color.White;
            CalculateBtn.Location = new Point(32, 543);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(190, 40);
            CalculateBtn.TabIndex = 8;
            CalculateBtn.Text = "گردش کارت";
            CalculateBtn.UseVisualStyleBackColor = false;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.BackColor = Color.Transparent;
            ReportBtn.Cursor = Cursors.Hand;
            ReportBtn.FlatAppearance.BorderColor = Color.LightSteelBlue;
            ReportBtn.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            ReportBtn.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            ReportBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.ForeColor = Color.White;
            ReportBtn.Location = new Point(32, 588);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(190, 40);
            ReportBtn.TabIndex = 9;
            ReportBtn.Text = "گزارشات";
            ReportBtn.UseVisualStyleBackColor = false;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // UserBtn
            // 
            UserBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UserBtn.BackColor = Color.FromArgb(255, 100, 0);
            UserBtn.Cursor = Cursors.Hand;
            UserBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            UserBtn.FlatAppearance.BorderSize = 2;
            UserBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(250, 0, 0);
            UserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 0, 0);
            UserBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0);
            UserBtn.FlatStyle = FlatStyle.Flat;
            UserBtn.Font = new Font("IRANSansWeb", 12F);
            UserBtn.ForeColor = Color.White;
            UserBtn.Location = new Point(76, 182);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(105, 63);
            UserBtn.TabIndex = 1;
            UserBtn.Text = "مشترکین";
            UserBtn.UseVisualStyleBackColor = false;
            UserBtn.Click += UserBtn_Click;
            // 
            // CartBtn
            // 
            CartBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CartBtn.BackColor = Color.FromArgb(255, 100, 0);
            CartBtn.Cursor = Cursors.Hand;
            CartBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            CartBtn.FlatAppearance.BorderSize = 2;
            CartBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(250, 0, 0);
            CartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 0, 0);
            CartBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 0, 0);
            CartBtn.FlatStyle = FlatStyle.Flat;
            CartBtn.Font = new Font("IRANSansWeb", 12F);
            CartBtn.ForeColor = Color.White;
            CartBtn.Location = new Point(10, 182);
            CartBtn.Name = "CartBtn";
            CartBtn.Size = new Size(60, 63);
            CartBtn.TabIndex = 2;
            CartBtn.Text = "کارت";
            CartBtn.UseVisualStyleBackColor = false;
            CartBtn.Click += CartBtn_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(-10, 110);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(275, 10);
            progressBar2.Step = 1;
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 17;
            progressBar2.Value = 99;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = Color.DarkSlateGray;
            progressBar3.Cursor = Cursors.SizeAll;
            progressBar3.ForeColor = Color.White;
            progressBar3.Location = new Point(-26, 5);
            progressBar3.Name = "progressBar3";
            progressBar3.RightToLeftLayout = true;
            progressBar3.Size = new Size(1472, 5);
            progressBar3.Step = 1;
            progressBar3.Style = ProgressBarStyle.Continuous;
            progressBar3.TabIndex = 18;
            progressBar3.UseWaitCursor = true;
            progressBar3.Value = 99;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Location = new Point(7, 17);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1146, 759);
            MainPanel.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.LightSteelBlue;
            button1.FlatAppearance.CheckedBackColor = Color.CornflowerBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 453);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 18;
            button1.Text = "بدهکاری";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainFRM
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 28);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 780);
            Controls.Add(MainPanel);
            Controls.Add(progressBar3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainFRM";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFORM";
            FormClosing += MainFRM_FormClosing;
            Load += MainFRM_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CartBtn;
        private Label ClockLbl;
        private Button SettingBtn;
        private Button BalanceBtn;
        private Button TaransactionBtn;
        private Button CashMoneyBtn;
        private Button CalculateBtn;
        private Button ReportBtn;
        private Button UserBtn;
        private Button LockBtn;
        private Button ExitBtn;
        private Label label1;
        private Button OnlineExchangeBtn;
        private Button BankBtn;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private Panel MainPanel;
        private Button SettlemantBtn;
        private Button button1;
    }
}
