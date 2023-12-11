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
            label8 = new Label();
            BlanceTxt = new TextBox();
            MSG = new Label();
            label6 = new Label();
            TransactionTypeCombo = new ComboBox();
            CloseBtn = new Button();
            SaveBtn = new Button();
            groupBox1 = new GroupBox();
            PanelType2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            PanelType3 = new Panel();
            label5 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            PanelType4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            PanelType1 = new Panel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            PanelType2.SuspendLayout();
            PanelType3.SuspendLayout();
            PanelType4.SuspendLayout();
            PanelType1.SuspendLayout();
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
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(647, 49);
            label8.Name = "label8";
            label8.Size = new Size(95, 32);
            label8.TabIndex = 34;
            label8.Text = "مبلغ تراکنش";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BlanceTxt
            // 
            BlanceTxt.BackColor = Color.White;
            BlanceTxt.BorderStyle = BorderStyle.FixedSingle;
            BlanceTxt.Location = new Point(527, 84);
            BlanceTxt.MaxLength = 15;
            BlanceTxt.Name = "BlanceTxt";
            BlanceTxt.PlaceholderText = "قیمت اولیه را وارد کنید";
            BlanceTxt.Size = new Size(215, 32);
            BlanceTxt.TabIndex = 5;
            BlanceTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // MSG
            // 
            MSG.ForeColor = Color.FromArgb(255, 192, 192);
            MSG.Location = new Point(6, 18);
            MSG.Name = "MSG";
            MSG.Size = new Size(638, 32);
            MSG.TabIndex = 23;
            MSG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.ForeColor = Color.White;
            label6.Location = new Point(650, 18);
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
            TransactionTypeCombo.Location = new Point(6, 53);
            TransactionTypeCombo.Name = "TransactionTypeCombo";
            TransactionTypeCombo.RightToLeft = RightToLeft.Yes;
            TransactionTypeCombo.Size = new Size(739, 33);
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
            CloseBtn.Location = new Point(188, 478);
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
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "ذخیره اطلاعات";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(PanelType2);
            groupBox1.Controls.Add(PanelType3);
            groupBox1.Controls.Add(PanelType4);
            groupBox1.Controls.Add(PanelType1);
            groupBox1.Controls.Add(MSG);
            groupBox1.Controls.Add(CloseBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TransactionTypeCombo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 519);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // PanelType2
            // 
            PanelType2.Controls.Add(label1);
            PanelType2.Controls.Add(label4);
            PanelType2.Controls.Add(textBox1);
            PanelType2.Location = new Point(3, 93);
            PanelType2.Name = "PanelType2";
            PanelType2.Size = new Size(745, 383);
            PanelType2.TabIndex = 36;
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 2);
            label1.Name = "label1";
            label1.Size = new Size(711, 35);
            label1.TabIndex = 28;
            label1.Text = "برداشت نقدی";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.ForeColor = Color.White;
            label4.Location = new Point(647, 49);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 34;
            label4.Text = "مبلغ تراکنش";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(527, 84);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "قیمت اولیه را وارد کنید";
            textBox1.Size = new Size(215, 32);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PanelType3
            // 
            PanelType3.Controls.Add(label5);
            PanelType3.Controls.Add(label7);
            PanelType3.Controls.Add(textBox2);
            PanelType3.Location = new Point(3, 93);
            PanelType3.Name = "PanelType3";
            PanelType3.Size = new Size(745, 383);
            PanelType3.TabIndex = 37;
            // 
            // label5
            // 
            label5.BackColor = Color.DodgerBlue;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 2);
            label5.Name = "label5";
            label5.Size = new Size(711, 35);
            label5.TabIndex = 28;
            label5.Text = "انتقال به کارت دیگر";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.ForeColor = Color.White;
            label7.Location = new Point(647, 49);
            label7.Name = "label7";
            label7.Size = new Size(95, 32);
            label7.TabIndex = 34;
            label7.Text = "مبلغ تراکنش";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(527, 84);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "قیمت اولیه را وارد کنید";
            textBox2.Size = new Size(215, 32);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // PanelType4
            // 
            PanelType4.Controls.Add(label9);
            PanelType4.Controls.Add(label10);
            PanelType4.Controls.Add(textBox3);
            PanelType4.Location = new Point(3, 93);
            PanelType4.Name = "PanelType4";
            PanelType4.Size = new Size(745, 383);
            PanelType4.TabIndex = 38;
            // 
            // label9
            // 
            label9.BackColor = Color.DodgerBlue;
            label9.ForeColor = Color.White;
            label9.Location = new Point(17, 2);
            label9.Name = "label9";
            label9.Size = new Size(711, 35);
            label9.TabIndex = 28;
            label9.Text = "واریز به کارت";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(647, 49);
            label10.Name = "label10";
            label10.Size = new Size(95, 32);
            label10.TabIndex = 34;
            label10.Text = "مبلغ تراکنش";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(527, 84);
            textBox3.MaxLength = 15;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "قیمت اولیه را وارد کنید";
            textBox3.Size = new Size(215, 32);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // PanelType1
            // 
            PanelType1.Controls.Add(label2);
            PanelType1.Controls.Add(label8);
            PanelType1.Controls.Add(BlanceTxt);
            PanelType1.Location = new Point(3, 93);
            PanelType1.Name = "PanelType1";
            PanelType1.Size = new Size(745, 383);
            PanelType1.TabIndex = 35;
            PanelType1.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = Color.DodgerBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 2);
            label2.Name = "label2";
            label2.Size = new Size(711, 35);
            label2.TabIndex = 28;
            label2.Text = "خرید از کارت";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            PanelType2.ResumeLayout(false);
            PanelType2.PerformLayout();
            PanelType3.ResumeLayout(false);
            PanelType3.PerformLayout();
            PanelType4.ResumeLayout(false);
            PanelType4.PerformLayout();
            PanelType1.ResumeLayout(false);
            PanelType1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label1;
        private Atf.UI.DateTimeSelector ExpireDate;
        private Label label8;
        private TextBox BlanceTxt;
        private Label label7;
        private Label MSG;
        private Label label6;
        private Label label5;
        private ComboBox CustomerCombo;
        private Label label4;
        private ComboBox TransactionTypeCombo;
        private Button CloseBtn;
        private Button SaveBtn;
        private GroupBox groupBox1;
        private Panel PanelType1;
        private Label label2;
        private Panel PanelType2;
        private TextBox textBox1;
        private Panel PanelType3;
        private TextBox textBox2;
        private Panel PanelType4;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
    }
}