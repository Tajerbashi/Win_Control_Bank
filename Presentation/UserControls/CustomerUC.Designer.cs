namespace Presentation.UserControls
{
    partial class CustomerUS
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
            PageLbl = new Label();
            GridData = new DataGridView();
            NextBtn = new Button();
            PrevBtn = new Button();
            SearchBtn = new Button();
            SearchTxt = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(AddBtn);
            groupBox2.Controls.Add(PageLbl);
            groupBox2.Controls.Add(GridData);
            groupBox2.Controls.Add(NextBtn);
            groupBox2.Controls.Add(PrevBtn);
            groupBox2.Controls.Add(SearchBtn);
            groupBox2.Controls.Add(SearchTxt);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1126, 737);
            groupBox2.TabIndex = 3;
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
            AddBtn.Location = new Point(999, 24);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(121, 32);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "جدید";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // PageLbl
            // 
            PageLbl.ForeColor = Color.White;
            PageLbl.Location = new Point(188, 702);
            PageLbl.Name = "PageLbl";
            PageLbl.Size = new Size(751, 32);
            PageLbl.TabIndex = 11;
            PageLbl.Text = "ساعت";
            PageLbl.TextAlign = ContentAlignment.MiddleCenter;
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
            GridData.Size = new Size(1114, 632);
            GridData.TabIndex = 4;
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
            NextBtn.Location = new Point(6, 699);
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
            PrevBtn.Location = new Point(1064, 699);
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
            // UserUS
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UserUS";
            Size = new Size(1132, 743);
            Load += UserUS_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label PageLbl;
        private DataGridView GridData;
        private Button NextBtn;
        private Button PrevBtn;
        private Button SearchBtn;
        private TextBox SearchTxt;
        private Button AddBtn;
    }
}
