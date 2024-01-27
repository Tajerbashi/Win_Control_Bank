namespace Presentation.UserControls
{
    partial class BankUC
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
            GridData = new DataGridView();
            PageLbl = new Label();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            AddBtn = new Button();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(PageLbl);
            groupBox2.Controls.Add(NextBtn);
            groupBox2.Controls.Add(PrevBtn);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTxt);
            groupBox2.Location = new Point(3, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1134, 695);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
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
            GridData.Size = new Size(1122, 589);
            GridData.TabIndex = 12;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(192, 657);
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
            PrevBtn.Location = new Point(1072, 657);
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
            SearchBtn.Location = new Point(6, 24);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 32);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "جستجو";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(87, 24);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(262, 32);
            SearchTxt.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            AddBtn.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            AddBtn.FlatAppearance.MouseDownBackColor = Color.Green;
            AddBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(3, 9);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(223, 32);
            AddBtn.TabIndex = 14;
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(908, 32);
            label1.TabIndex = 12;
            label1.Text = "اطلاعات بانکی";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BankUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(AddBtn);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BankUC";
            Size = new Size(1140, 741);
            Load += BankUC_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView GridData;
        private Label PageLbl;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Button AddBtn;
        private Label label1;
    }
}
