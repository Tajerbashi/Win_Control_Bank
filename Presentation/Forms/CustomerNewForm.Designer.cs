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
            DescriptionTxt = new RichTextBox();
            UserPicture = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            PageLbl = new Label();
            TitleTxt = new TextBox();
            FullNameTxt = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicture).BeginInit();
            SuspendLayout();
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
            CloseBtn.Location = new Point(175, 298);
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
            SaveBtn.BackColor = Color.LimeGreen;
            SaveBtn.Cursor = Cursors.Hand;
            SaveBtn.FlatAppearance.BorderColor = Color.Green;
            SaveBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            SaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(434, 298);
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
            groupBox1.Controls.Add(DescriptionTxt);
            groupBox1.Controls.Add(UserPicture);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PageLbl);
            groupBox1.Controls.Add(TitleTxt);
            groupBox1.Controls.Add(FullNameTxt);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(5, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 340);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.Black;
            MSG.Location = new Point(150, 22);
            MSG.Name = "MSG";
            MSG.Size = new Size(431, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.BackColor = Color.White;
            DescriptionTxt.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTxt.Location = new Point(253, 195);
            DescriptionTxt.MaxLength = 5000;
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.RightToLeft = RightToLeft.Yes;
            DescriptionTxt.Size = new Size(451, 87);
            DescriptionTxt.TabIndex = 2;
            DescriptionTxt.Text = "";
            // 
            // UserPicture
            // 
            UserPicture.BorderStyle = BorderStyle.FixedSingle;
            UserPicture.Cursor = Cursors.Hand;
            UserPicture.Location = new Point(26, 57);
            UserPicture.Name = "UserPicture";
            UserPicture.Size = new Size(195, 225);
            UserPicture.TabIndex = 21;
            UserPicture.TabStop = false;
            // 
            // label2
            // 
            label2.ForeColor = Color.Black;
            label2.Location = new Point(609, 160);
            label2.Name = "label2";
            label2.Size = new Size(95, 32);
            label2.TabIndex = 19;
            label2.Text = "توضیحات";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Location = new Point(609, 90);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 18;
            label1.Text = "عنوان";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.Black;
            PageLbl.Location = new Point(609, 22);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(95, 32);
            PageLbl.TabIndex = 17;
            PageLbl.Text = "نام کامل";
            PageLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TitleTxt
            // 
            TitleTxt.BackColor = Color.White;
            TitleTxt.BorderStyle = BorderStyle.FixedSingle;
            TitleTxt.Location = new Point(253, 125);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(451, 32);
            TitleTxt.TabIndex = 1;
            TitleTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // FullNameTxt
            // 
            FullNameTxt.BackColor = Color.White;
            FullNameTxt.BorderStyle = BorderStyle.FixedSingle;
            FullNameTxt.Location = new Point(253, 57);
            FullNameTxt.Name = "FullNameTxt";
            FullNameTxt.Size = new Size(451, 32);
            FullNameTxt.TabIndex = 0;
            FullNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = Color.DeepSkyBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 9);
            label3.Name = "label3";
            label3.Size = new Size(718, 35);
            label3.TabIndex = 24;
            label3.Text = "ثبت اطلاعات مشترک";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerNewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(741, 395);
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
        private TextBox TitleTxt;
        private Label label2;
        private Label label1;
        private Label PageLbl;
        private PictureBox UserPicture;
        private RichTextBox DescriptionTxt;
        private Label MSG;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}