namespace Presentation.UserControls
{
    partial class BlanceUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            AddBtn = new Button();
            GridData = new DataGridView();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            label1 = new Label();
            AccountCombo = new ComboBox();
            CustomerCombo = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CustomerCombo);
            groupBox2.Controls.Add(AccountCombo);
            groupBox2.Controls.Add(AddBtn);
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(PageLbl);
            groupBox2.Controls.Add(NextBtn);
            groupBox2.Controls.Add(PrevBtn);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTxt);
            groupBox2.Location = new Point(3, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1126, 695);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            AddBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            AddBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(355, 21);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(121, 32);
            AddBtn.TabIndex = 14;
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // GridData
            // 
            GridData.AllowUserToAddRows = false;
            GridData.AllowUserToOrderColumns = true;
            GridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GridData.BackgroundColor = Color.White;
            GridData.BorderStyle = BorderStyle.Fixed3D;
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.EditMode = DataGridViewEditMode.EditProgrammatically;
            GridData.GridColor = Color.FromArgb(255, 224, 192);
            GridData.Location = new Point(6, 62);
            GridData.Name = "GridData";
            GridData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            GridData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridData.Size = new Size(1114, 589);
            GridData.TabIndex = 12;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(188, 657);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(751, 32);
            PageLbl.TabIndex = 11;
            PageLbl.Text = "ساعت";
            PageLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NextBtn
            // 
            NextBtn.Cursor = Cursors.Hand;
            NextBtn.FlatAppearance.BorderColor = Color.Black;
            NextBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            NextBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            NextBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(6, 657);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(56, 32);
            NextBtn.TabIndex = 3;
            NextBtn.Text = "بعدی";
            NextBtn.UseVisualStyleBackColor = true;
            // 
            // PrevBtn
            // 
            PrevBtn.Cursor = Cursors.Hand;
            PrevBtn.FlatAppearance.BorderColor = Color.Black;
            PrevBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            PrevBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            PrevBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            PrevBtn.FlatStyle = FlatStyle.Flat;
            PrevBtn.ForeColor = Color.White;
            PrevBtn.Location = new Point(1064, 657);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(56, 32);
            PrevBtn.TabIndex = 2;
            PrevBtn.Text = "قبلی";
            PrevBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBtn
            // 
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatAppearance.BorderColor = Color.White;
            SearchBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(6, 21);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 32);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(87, 21);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(262, 32);
            SearchTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(1114, 32);
            label1.TabIndex = 14;
            label1.Text = "اطلاعات موجودی مشترکین و حساب بانکی ها های سامانه";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountCombo
            // 
            AccountCombo.Cursor = Cursors.Hand;
            AccountCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            AccountCombo.FormattingEnabled = true;
            AccountCombo.Location = new Point(823, 23);
            AccountCombo.Name = "AccountCombo";
            AccountCombo.RightToLeft = RightToLeft.Yes;
            AccountCombo.Size = new Size(297, 33);
            AccountCombo.TabIndex = 25;
            // 
            // CustomerCombo
            // 
            CustomerCombo.Cursor = Cursors.Hand;
            CustomerCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerCombo.FormattingEnabled = true;
            CustomerCombo.Location = new Point(520, 23);
            CustomerCombo.Name = "CustomerCombo";
            CustomerCombo.RightToLeft = RightToLeft.Yes;
            CustomerCombo.Size = new Size(297, 33);
            CustomerCombo.TabIndex = 26;
            // 
            // BlanceUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BlanceUC";
            Size = new Size(1132, 743);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button AddBtn;
        private DataGridView GridData;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Label label1;
        private ComboBox CustomerCombo;
        private ComboBox AccountCombo;
    }
}
