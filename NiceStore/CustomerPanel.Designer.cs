namespace NiceStore
{
    partial class CustomerPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CuNametxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.CuPhonetxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.AddCuBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuSearchtxt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.customerTBBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CuSearchbtn = new DevComponents.DotNetBar.ButtonX();
            this.niceStoreDBDataSet = new NiceStore.NiceStoreDBDataSet();
            this.customerTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTBTableAdapter = new NiceStore.NiceStoreDBDataSetTableAdapters.CustomerTBTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niceStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // CuNametxt
            // 
            // 
            // 
            // 
            this.CuNametxt.Border.Class = "TextBoxBorder";
            this.CuNametxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CuNametxt.Location = new System.Drawing.Point(400, 25);
            this.CuNametxt.MaxLength = 40;
            this.CuNametxt.Name = "CuNametxt";
            this.CuNametxt.PreventEnterBeep = true;
            this.CuNametxt.Size = new System.Drawing.Size(242, 20);
            this.CuNametxt.TabIndex = 0;
            // 
            // CuPhonetxt
            // 
            // 
            // 
            // 
            this.CuPhonetxt.Border.Class = "TextBoxBorder";
            this.CuPhonetxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CuPhonetxt.Location = new System.Drawing.Point(62, 25);
            this.CuPhonetxt.MaxLength = 11;
            this.CuPhonetxt.Name = "CuPhonetxt";
            this.CuPhonetxt.PreventEnterBeep = true;
            this.CuPhonetxt.Size = new System.Drawing.Size(242, 20);
            this.CuPhonetxt.TabIndex = 1;
            // 
            // AddCuBtn
            // 
            this.AddCuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            this.AddCuBtn.ForeColor = System.Drawing.Color.White;
            this.AddCuBtn.Location = new System.Drawing.Point(118, 51);
            this.AddCuBtn.Name = "AddCuBtn";
            this.AddCuBtn.Size = new System.Drawing.Size(468, 29);
            this.AddCuBtn.TabIndex = 2;
            this.AddCuBtn.Text = "افزودن مشتری";
            this.AddCuBtn.UseVisualStyleBackColor = false;
            this.AddCuBtn.Click += new System.EventHandler(this.AddCuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام مشتری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "شماره تماس";
            // 
            // CuSearchtxt
            // 
            // 
            // 
            // 
            this.CuSearchtxt.Border.Class = "TextBoxBorder";
            this.CuSearchtxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CuSearchtxt.Location = new System.Drawing.Point(88, 86);
            this.CuSearchtxt.MaxLength = 20;
            this.CuSearchtxt.Name = "CuSearchtxt";
            this.CuSearchtxt.PreventEnterBeep = true;
            this.CuSearchtxt.Size = new System.Drawing.Size(554, 20);
            this.CuSearchtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "جستجو";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToResizeColumns = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MRT_Mitra_3", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MRT_Mitra_3", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.Location = new System.Drawing.Point(3, 112);
            this.DGV1.Name = "DGV1";
            this.DGV1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.Size = new System.Drawing.Size(698, 542);
            this.DGV1.TabIndex = 7;
            this.DGV1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGV1_MouseClick);
            // 
            // customerTBBindingSource1
            // 
            this.customerTBBindingSource1.DataSource = typeof(NiceStore.CustomerTB);
            // 
            // CuSearchbtn
            // 
            this.CuSearchbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CuSearchbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CuSearchbtn.Location = new System.Drawing.Point(62, 86);
            this.CuSearchbtn.Name = "CuSearchbtn";
            this.CuSearchbtn.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.CuSearchbtn.Size = new System.Drawing.Size(20, 20);
            this.CuSearchbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CuSearchbtn.TabIndex = 8;
            this.CuSearchbtn.Click += new System.EventHandler(this.CuSearchbtn_Click);
            // 
            // niceStoreDBDataSet
            // 
            this.niceStoreDBDataSet.DataSetName = "NiceStoreDBDataSet";
            this.niceStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTBBindingSource
            // 
            this.customerTBBindingSource.DataMember = "CustomerTB";
            this.customerTBBindingSource.DataSource = this.niceStoreDBDataSet;
            // 
            // customerTBTableAdapter
            // 
            this.customerTBTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NiceStore.Properties.Resources.sortascend256_25201;
            this.pictureBox1.Location = new System.Drawing.Point(3, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::NiceStore.Properties.Resources.Everaldo_Crystal_Clear_App_Quick_restart;
            this.pictureBox5.Location = new System.Drawing.Point(665, 70);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            this.Column2.Width = 370;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "تلفن";
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.CuSearchbtn);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CuSearchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCuBtn);
            this.Controls.Add(this.CuPhonetxt);
            this.Controls.Add(this.CuNametxt);
            this.Name = "CustomerPanel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(704, 657);
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niceStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTBBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX CuNametxt;
        private DevComponents.DotNetBar.Controls.TextBoxX CuPhonetxt;
        private System.Windows.Forms.Button AddCuBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX CuSearchtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV1;
        private DevComponents.DotNetBar.ButtonX CuSearchbtn;
        private System.Windows.Forms.BindingSource customerTBBindingSource;
        private NiceStoreDBDataSet niceStoreDBDataSet;
        private NiceStoreDBDataSetTableAdapters.CustomerTBTableAdapter customerTBTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource customerTBBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
