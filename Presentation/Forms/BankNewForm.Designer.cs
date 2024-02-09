namespace Presentation.Forms
{
    partial class BankNewForm
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
            MSG = new Label();
            PageLbl = new Label();
            BankNameTxt = new TextBox();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 10);
            label3.Name = "label3";
            label3.Size = new Size(718, 35);
            label3.TabIndex = 27;
            label3.Text = "ثبت اطلاعات بانک";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(BankNameTxt);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.Black;
            MSG.Location = new Point(10, 20);
            MSG.Name = "MSG";
            MSG.Size = new Size(600, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            MSG.Visible = false;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(616, 22);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(95, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "نام بانک";
            PageLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BankNameTxt
            // 
            BankNameTxt.BackColor = Color.FromArgb(240, 236, 229);
            BankNameTxt.BorderStyle = BorderStyle.FixedSingle;
            BankNameTxt.Location = new Point(265, 57);
            BankNameTxt.Name = "BankNameTxt";
            BankNameTxt.Size = new Size(441, 32);
            BankNameTxt.TabIndex = 0;
            BankNameTxt.TextAlign = HorizontalAlignment.Center;
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
            CloseBtn.Location = new Point(10, 57);
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
            SaveBtn.Location = new Point(138, 57);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BankNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(741, 161);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "BankNewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankNewForm";
            Load += BankNewForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private GroupBox groupBox1;
        private Label MSG;
        private Label PageLbl;
        private TextBox BankNameTxt;
        private Button CloseBtn;
        private Button SaveBtn;
    }
}