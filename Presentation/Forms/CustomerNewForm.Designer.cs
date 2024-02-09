namespace Presentation.Forms
{
    partial class CustomerNewForm
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
            components = new System.ComponentModel.Container();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1 = new GroupBox();
            MSG = new Label();
            UserPicture = new PictureBox();
            PageLbl = new Label();
            FullNameTxt = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            SuspendLayout();
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
            CloseBtn.Location = new Point(227, 158);
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
            SaveBtn.Location = new Point(381, 158);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(121, 32);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(UserPicture);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(FullNameTxt);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(5, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 209);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.Black;
            MSG.Location = new Point(165, 22);
            MSG.Name = "MSG";
            MSG.Size = new Size(461, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserPicture
            // 
            UserPicture.BorderStyle = BorderStyle.FixedSingle;
            UserPicture.Cursor = Cursors.Hand;
            UserPicture.Location = new Point(10, 22);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(149, 177);
            UserPicture.TabIndex = 21;
            UserPicture.TabStop = false;
            UserPicture.MouseClick += UserPicture_MouseClick;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(531, 54);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(95, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "نام کامل";
            PageLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FullNameTxt
            // 
            FullNameTxt.BackColor = Color.FromArgb(240, 236, 229);
            FullNameTxt.BorderStyle = BorderStyle.FixedSingle;
            FullNameTxt.Location = new Point(165, 89);
            FullNameTxt.Name = "FullNameTxt";
            FullNameTxt.PlaceholderText = "نام مشترک را وارد کنید";
            FullNameTxt.RightToLeft = RightToLeft.Yes;
            FullNameTxt.Size = new Size(461, 32);
            FullNameTxt.TabIndex = 0;
            FullNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(49, 48, 77);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 9);
            label3.Name = "label3";
            label3.Size = new Size(640, 35);
            label3.TabIndex = 24;
            label3.Text = "ثبت اطلاعات مشترک";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 26, 48);
            ClientSize = new Size(651, 256);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("IRANSansWeb", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomerNewForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewUserForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseBtn;
        private Button SaveBtn;
        private GroupBox groupBox1;
        private TextBox FullNameTxt;
        private Label PageLbl;
        private PictureBox UserPicture;
        private Label MSG;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}