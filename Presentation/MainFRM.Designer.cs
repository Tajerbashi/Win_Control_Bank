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
            OnlineExchangeBtn = new Button();
            label1 = new Label();
            LockBtn = new Button();
            ExitBtn = new Button();
            ClockLbl = new Label();
            SettingBtn = new Button();
            ExternalTransferBtn = new Button();
            TransferMoneyBtn = new Button();
            BalanceBtn = new Button();
            TaransactionBtn = new Button();
            CashMoneyBtn = new Button();
            CalculateBtn = new Button();
            ReportBtn = new Button();
            UserBtn = new Button();
            CartBtn = new Button();
            groupBox2 = new GroupBox();
            MainPanel = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(OnlineExchangeBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LockBtn);
            groupBox1.Controls.Add(ExitBtn);
            groupBox1.Controls.Add(ClockLbl);
            groupBox1.Controls.Add(SettingBtn);
            groupBox1.Controls.Add(ExternalTransferBtn);
            groupBox1.Controls.Add(TransferMoneyBtn);
            groupBox1.Controls.Add(BalanceBtn);
            groupBox1.Controls.Add(TaransactionBtn);
            groupBox1.Controls.Add(CashMoneyBtn);
            groupBox1.Controls.Add(CalculateBtn);
            groupBox1.Controls.Add(ReportBtn);
            groupBox1.Controls.Add(UserBtn);
            groupBox1.Controls.Add(CartBtn);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(1162, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 763);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مدیریت";
            // 
            // OnlineExchangeBtn
            // 
            OnlineExchangeBtn.Cursor = Cursors.Hand;
            OnlineExchangeBtn.FlatAppearance.BorderColor = Color.Salmon;
            OnlineExchangeBtn.FlatAppearance.BorderSize = 2;
            OnlineExchangeBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            OnlineExchangeBtn.FlatAppearance.MouseDownBackColor = Color.White;
            OnlineExchangeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            OnlineExchangeBtn.FlatStyle = FlatStyle.Flat;
            OnlineExchangeBtn.Font = new Font("IRANSansWeb", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnlineExchangeBtn.ForeColor = Color.Red;
            OnlineExchangeBtn.Location = new Point(6, 95);
            OnlineExchangeBtn.Name = "OnlineExchangeBtn";
            OnlineExchangeBtn.Size = new Size(234, 47);
            OnlineExchangeBtn.TabIndex = 14;
            OnlineExchangeBtn.Text = "صرافی آنلاین";
            OnlineExchangeBtn.UseVisualStyleBackColor = true;
            OnlineExchangeBtn.Click += OnlineExchangeBtn_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Cursor = Cursors.SizeAll;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("IRANSansWeb", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(234, 64);
            label1.TabIndex = 13;
            label1.Text = "مدیریت و حسابداری";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            // 
            // LockBtn
            // 
            LockBtn.Cursor = Cursors.Hand;
            LockBtn.FlatAppearance.BorderColor = Color.White;
            LockBtn.FlatAppearance.BorderSize = 2;
            LockBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            LockBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            LockBtn.FlatAppearance.MouseOverBackColor = Color.Black;
            LockBtn.FlatStyle = FlatStyle.Flat;
            LockBtn.ForeColor = Color.White;
            LockBtn.Location = new Point(6, 710);
            LockBtn.Name = "LockBtn";
            LockBtn.Size = new Size(114, 39);
            LockBtn.TabIndex = 12;
            LockBtn.Text = "قفل";
            LockBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.White;
            ExitBtn.FlatAppearance.BorderSize = 2;
            ExitBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.Red;
            ExitBtn.Location = new Point(126, 710);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(114, 39);
            ExitBtn.TabIndex = 11;
            ExitBtn.Text = "خروج";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ClockLbl
            // 
            ClockLbl.ForeColor = Color.White;
            ClockLbl.Location = new Point(6, 666);
            ClockLbl.Name = "ClockLbl";
            ClockLbl.Size = new Size(234, 41);
            ClockLbl.TabIndex = 10;
            ClockLbl.Text = "ساعت";
            ClockLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingBtn
            // 
            SettingBtn.Cursor = Cursors.Hand;
            SettingBtn.FlatAppearance.BorderColor = Color.White;
            SettingBtn.FlatAppearance.BorderSize = 2;
            SettingBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            SettingBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            SettingBtn.FlatAppearance.MouseOverBackColor = Color.Black;
            SettingBtn.FlatStyle = FlatStyle.Flat;
            SettingBtn.ForeColor = Color.FromArgb(192, 255, 255);
            SettingBtn.Location = new Point(29, 624);
            SettingBtn.Name = "SettingBtn";
            SettingBtn.Size = new Size(189, 39);
            SettingBtn.TabIndex = 9;
            SettingBtn.Text = "تنظیمات";
            SettingBtn.UseVisualStyleBackColor = true;
            // 
            // ExternalTransferBtn
            // 
            ExternalTransferBtn.Cursor = Cursors.Hand;
            ExternalTransferBtn.FlatAppearance.BorderColor = Color.Black;
            ExternalTransferBtn.FlatAppearance.BorderSize = 2;
            ExternalTransferBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            ExternalTransferBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            ExternalTransferBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            ExternalTransferBtn.FlatStyle = FlatStyle.Flat;
            ExternalTransferBtn.ForeColor = Color.Black;
            ExternalTransferBtn.Location = new Point(29, 551);
            ExternalTransferBtn.Name = "ExternalTransferBtn";
            ExternalTransferBtn.Size = new Size(189, 39);
            ExternalTransferBtn.TabIndex = 8;
            ExternalTransferBtn.Text = "واریزی خارجی";
            ExternalTransferBtn.UseVisualStyleBackColor = true;
            // 
            // TransferMoneyBtn
            // 
            TransferMoneyBtn.Cursor = Cursors.Hand;
            TransferMoneyBtn.FlatAppearance.BorderColor = Color.Black;
            TransferMoneyBtn.FlatAppearance.BorderSize = 2;
            TransferMoneyBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            TransferMoneyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            TransferMoneyBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            TransferMoneyBtn.FlatStyle = FlatStyle.Flat;
            TransferMoneyBtn.ForeColor = Color.Black;
            TransferMoneyBtn.Location = new Point(29, 505);
            TransferMoneyBtn.Name = "TransferMoneyBtn";
            TransferMoneyBtn.Size = new Size(189, 39);
            TransferMoneyBtn.TabIndex = 7;
            TransferMoneyBtn.Text = "حواله";
            TransferMoneyBtn.UseVisualStyleBackColor = true;
            // 
            // BalanceBtn
            // 
            BalanceBtn.Cursor = Cursors.Hand;
            BalanceBtn.FlatAppearance.BorderColor = Color.Black;
            BalanceBtn.FlatAppearance.BorderSize = 2;
            BalanceBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            BalanceBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            BalanceBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            BalanceBtn.FlatStyle = FlatStyle.Flat;
            BalanceBtn.ForeColor = Color.Black;
            BalanceBtn.Location = new Point(29, 459);
            BalanceBtn.Name = "BalanceBtn";
            BalanceBtn.Size = new Size(189, 39);
            BalanceBtn.TabIndex = 6;
            BalanceBtn.Text = "موجودی";
            BalanceBtn.UseVisualStyleBackColor = true;
            // 
            // TaransactionBtn
            // 
            TaransactionBtn.Cursor = Cursors.Hand;
            TaransactionBtn.FlatAppearance.BorderColor = Color.Black;
            TaransactionBtn.FlatAppearance.BorderSize = 2;
            TaransactionBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            TaransactionBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            TaransactionBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            TaransactionBtn.FlatStyle = FlatStyle.Flat;
            TaransactionBtn.ForeColor = Color.Black;
            TaransactionBtn.Location = new Point(29, 413);
            TaransactionBtn.Name = "TaransactionBtn";
            TaransactionBtn.Size = new Size(189, 39);
            TaransactionBtn.TabIndex = 5;
            TaransactionBtn.Text = "تراکنش ها";
            TaransactionBtn.UseVisualStyleBackColor = true;
            TaransactionBtn.Click += TaransactionBtn_Click;
            // 
            // CashMoneyBtn
            // 
            CashMoneyBtn.Cursor = Cursors.Hand;
            CashMoneyBtn.FlatAppearance.BorderColor = Color.Black;
            CashMoneyBtn.FlatAppearance.BorderSize = 2;
            CashMoneyBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            CashMoneyBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            CashMoneyBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            CashMoneyBtn.FlatStyle = FlatStyle.Flat;
            CashMoneyBtn.ForeColor = Color.Black;
            CashMoneyBtn.Location = new Point(29, 367);
            CashMoneyBtn.Name = "CashMoneyBtn";
            CashMoneyBtn.Size = new Size(189, 39);
            CashMoneyBtn.TabIndex = 4;
            CashMoneyBtn.Text = "نقدی";
            CashMoneyBtn.UseVisualStyleBackColor = true;
            CashMoneyBtn.Click += CashMoneyBtn_Click;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Cursor = Cursors.Hand;
            CalculateBtn.FlatAppearance.BorderColor = Color.Black;
            CalculateBtn.FlatAppearance.BorderSize = 2;
            CalculateBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            CalculateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            CalculateBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            CalculateBtn.FlatStyle = FlatStyle.Flat;
            CalculateBtn.ForeColor = Color.Black;
            CalculateBtn.Location = new Point(29, 321);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(189, 39);
            CalculateBtn.TabIndex = 3;
            CalculateBtn.Text = "محاسبات";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ReportBtn
            // 
            ReportBtn.Cursor = Cursors.Hand;
            ReportBtn.FlatAppearance.BorderColor = Color.Black;
            ReportBtn.FlatAppearance.BorderSize = 2;
            ReportBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            ReportBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            ReportBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            ReportBtn.FlatStyle = FlatStyle.Flat;
            ReportBtn.ForeColor = Color.Black;
            ReportBtn.Location = new Point(29, 275);
            ReportBtn.Name = "ReportBtn";
            ReportBtn.Size = new Size(189, 39);
            ReportBtn.TabIndex = 2;
            ReportBtn.Text = "گزارشات";
            ReportBtn.UseVisualStyleBackColor = true;
            ReportBtn.Click += ReportBtn_Click;
            // 
            // UserBtn
            // 
            UserBtn.Cursor = Cursors.Hand;
            UserBtn.FlatAppearance.BorderColor = Color.Black;
            UserBtn.FlatAppearance.BorderSize = 2;
            UserBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            UserBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            UserBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            UserBtn.FlatStyle = FlatStyle.Flat;
            UserBtn.ForeColor = Color.Black;
            UserBtn.Location = new Point(29, 229);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(189, 39);
            UserBtn.TabIndex = 1;
            UserBtn.Text = "مشترکین";
            UserBtn.UseVisualStyleBackColor = true;
            UserBtn.Click += UserBtn_Click;
            // 
            // CartBtn
            // 
            CartBtn.Cursor = Cursors.Hand;
            CartBtn.FlatAppearance.BorderColor = Color.Black;
            CartBtn.FlatAppearance.BorderSize = 2;
            CartBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(192, 255, 255);
            CartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            CartBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            CartBtn.FlatStyle = FlatStyle.Flat;
            CartBtn.ForeColor = Color.Black;
            CartBtn.Location = new Point(29, 183);
            CartBtn.Name = "CartBtn";
            CartBtn.Size = new Size(189, 39);
            CartBtn.TabIndex = 0;
            CartBtn.Text = "کارت";
            CartBtn.UseVisualStyleBackColor = true;
            CartBtn.Click += CartBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(MainPanel);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(12, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1144, 770);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(6, 20);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1132, 743);
            MainPanel.TabIndex = 0;
            // 
            // MainFRM
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1420, 780);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainFRM";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFORM";
            Load += MainFRM_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button CartBtn;
        private GroupBox groupBox2;
        private Label ClockLbl;
        private Button SettingBtn;
        private Button ExternalTransferBtn;
        private Button TransferMoneyBtn;
        private Button BalanceBtn;
        private Button TaransactionBtn;
        private Button CashMoneyBtn;
        private Button CalculateBtn;
        private Button ReportBtn;
        private Button UserBtn;
        private Panel MainPanel;
        private Button LockBtn;
        private Button ExitBtn;
        private Label label1;
        private Button OnlineExchangeBtn;
    }
}
