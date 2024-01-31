namespace Presentation.UserControls
{
    partial class SettingUC
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
            MainController = new TabControl();
            ConstTab = new TabPage();
            AccessTab = new TabPage();
            RoleTab = new TabPage();
            vScrollBar1 = new VScrollBar();
            UsersTab = new TabPage();
            NewUserBtn = new Button();
            NewRoleBtn = new Button();
            NewConstBtn = new Button();
            button1 = new Button();
            vScrollBar2 = new VScrollBar();
            groupBox2.SuspendLayout();
            MainController.SuspendLayout();
            ConstTab.SuspendLayout();
            AccessTab.SuspendLayout();
            RoleTab.SuspendLayout();
            UsersTab.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MainController);
            groupBox2.Location = new Point(2, -11);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(1134, 746);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // MainController
            // 
            MainController.Alignment = TabAlignment.Bottom;
            MainController.AllowDrop = true;
            MainController.Controls.Add(UsersTab);
            MainController.Controls.Add(RoleTab);
            MainController.Controls.Add(ConstTab);
            MainController.Controls.Add(AccessTab);
            MainController.Location = new Point(6, 17);
            MainController.Multiline = true;
            MainController.Name = "MainController";
            MainController.RightToLeftLayout = true;
            MainController.SelectedIndex = 0;
            MainController.Size = new Size(1122, 723);
            MainController.TabIndex = 12;
            // 
            // ConstTab
            // 
            ConstTab.Controls.Add(NewConstBtn);
            ConstTab.Location = new Point(4, 4);
            ConstTab.Name = "ConstTab";
            ConstTab.Padding = new Padding(3);
            ConstTab.Size = new Size(1114, 685);
            ConstTab.TabIndex = 2;
            ConstTab.Text = "ثابت ها";
            ConstTab.UseVisualStyleBackColor = true;
            // 
            // AccessTab
            // 
            AccessTab.Controls.Add(button1);
            AccessTab.Location = new Point(4, 4);
            AccessTab.Name = "AccessTab";
            AccessTab.Padding = new Padding(3);
            AccessTab.Size = new Size(1114, 685);
            AccessTab.TabIndex = 8;
            AccessTab.Text = "دسترسی";
            AccessTab.UseVisualStyleBackColor = true;
            // 
            // RoleTab
            // 
            RoleTab.Controls.Add(vScrollBar2);
            RoleTab.Controls.Add(NewRoleBtn);
            RoleTab.Location = new Point(4, 4);
            RoleTab.Name = "RoleTab";
            RoleTab.Padding = new Padding(3);
            RoleTab.Size = new Size(1114, 685);
            RoleTab.TabIndex = 1;
            RoleTab.Text = "نقش";
            RoleTab.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1081, 52);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(27, 628);
            vScrollBar1.TabIndex = 0;
            // 
            // UsersTab
            // 
            UsersTab.BackColor = Color.Transparent;
            UsersTab.Controls.Add(NewUserBtn);
            UsersTab.Controls.Add(vScrollBar1);
            UsersTab.Location = new Point(4, 4);
            UsersTab.Name = "UsersTab";
            UsersTab.Padding = new Padding(3);
            UsersTab.Size = new Size(1114, 685);
            UsersTab.TabIndex = 0;
            UsersTab.Text = "کاربران";
            // 
            // NewUserBtn
            // 
            NewUserBtn.BackColor = Color.DodgerBlue;
            NewUserBtn.Cursor = Cursors.Hand;
            NewUserBtn.FlatAppearance.BorderColor = Color.RoyalBlue;
            NewUserBtn.FlatAppearance.BorderSize = 2;
            NewUserBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            NewUserBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            NewUserBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            NewUserBtn.FlatStyle = FlatStyle.Flat;
            NewUserBtn.ForeColor = Color.White;
            NewUserBtn.Location = new Point(985, 10);
            NewUserBtn.Name = "NewUserBtn";
            NewUserBtn.Size = new Size(123, 39);
            NewUserBtn.TabIndex = 13;
            NewUserBtn.Text = "کاربر جدید";
            NewUserBtn.UseVisualStyleBackColor = false;
            // 
            // NewRoleBtn
            // 
            NewRoleBtn.BackColor = Color.DodgerBlue;
            NewRoleBtn.Cursor = Cursors.Hand;
            NewRoleBtn.FlatAppearance.BorderColor = Color.RoyalBlue;
            NewRoleBtn.FlatAppearance.BorderSize = 2;
            NewRoleBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            NewRoleBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            NewRoleBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            NewRoleBtn.FlatStyle = FlatStyle.Flat;
            NewRoleBtn.ForeColor = Color.White;
            NewRoleBtn.Location = new Point(985, 10);
            NewRoleBtn.Name = "NewRoleBtn";
            NewRoleBtn.Size = new Size(123, 39);
            NewRoleBtn.TabIndex = 14;
            NewRoleBtn.Text = "نقش جدید";
            NewRoleBtn.UseVisualStyleBackColor = false;
            // 
            // NewConstBtn
            // 
            NewConstBtn.BackColor = Color.DodgerBlue;
            NewConstBtn.Cursor = Cursors.Hand;
            NewConstBtn.FlatAppearance.BorderColor = Color.RoyalBlue;
            NewConstBtn.FlatAppearance.BorderSize = 2;
            NewConstBtn.FlatAppearance.CheckedBackColor = Color.Gray;
            NewConstBtn.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            NewConstBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            NewConstBtn.FlatStyle = FlatStyle.Flat;
            NewConstBtn.ForeColor = Color.White;
            NewConstBtn.Location = new Point(985, 10);
            NewConstBtn.Name = "NewConstBtn";
            NewConstBtn.Size = new Size(123, 39);
            NewConstBtn.TabIndex = 14;
            NewConstBtn.Text = "ثابت جدید";
            NewConstBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.CheckedBackColor = Color.Gray;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.HotTrack;
            button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(985, 10);
            button1.Name = "button1";
            button1.Size = new Size(123, 39);
            button1.TabIndex = 15;
            button1.Text = "ایجاد دسترسی";
            button1.UseVisualStyleBackColor = false;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Location = new Point(1087, 52);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(21, 630);
            vScrollBar2.TabIndex = 15;
            // 
            // SettingUC
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(groupBox2);
            Font = new Font("IRANSansWeb", 11.25F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SettingUC";
            Size = new Size(1140, 741);
            groupBox2.ResumeLayout(false);
            MainController.ResumeLayout(false);
            ConstTab.ResumeLayout(false);
            AccessTab.ResumeLayout(false);
            RoleTab.ResumeLayout(false);
            UsersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TabControl MainController;
        private TabPage UsersTab;
        private VScrollBar vScrollBar1;
        private TabPage RoleTab;
        private TabPage ConstTab;
        private TabPage AccessTab;
        private Button NewUserBtn;
        private Button NewRoleBtn;
        private Button NewConstBtn;
        private Button button1;
        private VScrollBar vScrollBar2;
    }
}
