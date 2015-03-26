namespace Projects
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.พนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ผจดการToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.manPassword = new System.Windows.Forms.TextBox();
            this.manUsername = new System.Windows.Forms.TextBox();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.manLastname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.manYear = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.manVillageNo = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.com_month = new System.Windows.Forms.ComboBox();
            this.com_day = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.manPostalcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.manProvince = new System.Windows.Forms.TextBox();
            this.manDistrict = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.manSubdistrict = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.manVillage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.manHouseNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manNoID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.manName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.com_num = new System.Windows.Forms.ComboBox();
            this.but_add = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.manConfirmPassword = new System.Windows.Forms.TextBox();
            this.com_status = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muneToolStripMenuItem,
            this.พนกงานToolStripMenuItem,
            this.ผจดการToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // muneToolStripMenuItem
            // 
            resources.ApplyResources(this.muneToolStripMenuItem, "muneToolStripMenuItem");
            this.muneToolStripMenuItem.Image = global::Projects.Properties.Resources.home_icon;
            this.muneToolStripMenuItem.Name = "muneToolStripMenuItem";
            this.muneToolStripMenuItem.Click += new System.EventHandler(this.muneToolStripMenuItem_Click);
            // 
            // พนกงานToolStripMenuItem
            // 
            resources.ApplyResources(this.พนกงานToolStripMenuItem, "พนกงานToolStripMenuItem");
            this.พนกงานToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เพมพนกงานToolStripMenuItem,
            this.ขอมลพนกงานToolStripMenuItem});
            this.พนกงานToolStripMenuItem.Image = global::Projects.Properties.Resources.employee_icon;
            this.พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem";
            // 
            // เพมพนกงานToolStripMenuItem
            // 
            resources.ApplyResources(this.เพมพนกงานToolStripMenuItem, "เพมพนกงานToolStripMenuItem");
            this.เพมพนกงานToolStripMenuItem.Name = "เพมพนกงานToolStripMenuItem";
            this.เพมพนกงานToolStripMenuItem.Click += new System.EventHandler(this.เพมพนกงานToolStripMenuItem_Click);
            // 
            // ขอมลพนกงานToolStripMenuItem
            // 
            resources.ApplyResources(this.ขอมลพนกงานToolStripMenuItem, "ขอมลพนกงานToolStripMenuItem");
            this.ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem";
            this.ขอมลพนกงานToolStripMenuItem.Click += new System.EventHandler(this.ขอมลพนกงานToolStripMenuItem_Click);
            // 
            // ผจดการToolStripMenuItem
            // 
            resources.ApplyResources(this.ผจดการToolStripMenuItem, "ผจดการToolStripMenuItem");
            this.ผจดการToolStripMenuItem.Image = global::Projects.Properties.Resources.manager_icon_mini;
            this.ผจดการToolStripMenuItem.Name = "ผจดการToolStripMenuItem";
            this.ผจดการToolStripMenuItem.Click += new System.EventHandler(this.ผจดการToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            resources.ApplyResources(this.ออกจากระบบToolStripMenuItem, "ออกจากระบบToolStripMenuItem");
            this.ออกจากระบบToolStripMenuItem.Image = global::Projects.Properties.Resources.exit_icon;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Name = "label14";
            // 
            // manPassword
            // 
            resources.ApplyResources(this.manPassword, "manPassword");
            this.manPassword.Name = "manPassword";
            // 
            // manUsername
            // 
            resources.ApplyResources(this.manUsername, "manUsername");
            this.manUsername.Name = "manUsername";
            // 
            // but_delete
            // 
            this.but_delete.BackgroundImage = global::Projects.Properties.Resources.delete_icon;
            resources.ApplyResources(this.but_delete, "but_delete");
            this.but_delete.Name = "but_delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_edit
            // 
            this.but_edit.BackgroundImage = global::Projects.Properties.Resources.edit_icon;
            resources.ApplyResources(this.but_edit, "but_edit");
            this.but_edit.Name = "but_edit";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Name = "label13";
            // 
            // manLastname
            // 
            resources.ApplyResources(this.manLastname, "manLastname");
            this.manLastname.Name = "manLastname";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Name = "label12";
            // 
            // manYear
            // 
            resources.ApplyResources(this.manYear, "manYear");
            this.manYear.Name = "manYear";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Name = "label11";
            // 
            // manVillageNo
            // 
            resources.ApplyResources(this.manVillageNo, "manVillageNo");
            this.manVillageNo.Name = "manVillageNo";
            // 
            // but_save
            // 
            this.but_save.BackgroundImage = global::Projects.Properties.Resources.save_icon;
            resources.ApplyResources(this.but_save, "but_save");
            this.but_save.Name = "but_save";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // com_month
            // 
            this.com_month.FormattingEnabled = true;
            this.com_month.Items.AddRange(new object[] {
            resources.GetString("com_month.Items"),
            resources.GetString("com_month.Items1"),
            resources.GetString("com_month.Items2"),
            resources.GetString("com_month.Items3"),
            resources.GetString("com_month.Items4"),
            resources.GetString("com_month.Items5"),
            resources.GetString("com_month.Items6"),
            resources.GetString("com_month.Items7"),
            resources.GetString("com_month.Items8"),
            resources.GetString("com_month.Items9"),
            resources.GetString("com_month.Items10"),
            resources.GetString("com_month.Items11"),
            resources.GetString("com_month.Items12")});
            resources.ApplyResources(this.com_month, "com_month");
            this.com_month.Name = "com_month";
            // 
            // com_day
            // 
            this.com_day.FormattingEnabled = true;
            this.com_day.Items.AddRange(new object[] {
            resources.GetString("com_day.Items"),
            resources.GetString("com_day.Items1"),
            resources.GetString("com_day.Items2"),
            resources.GetString("com_day.Items3"),
            resources.GetString("com_day.Items4"),
            resources.GetString("com_day.Items5"),
            resources.GetString("com_day.Items6"),
            resources.GetString("com_day.Items7"),
            resources.GetString("com_day.Items8"),
            resources.GetString("com_day.Items9"),
            resources.GetString("com_day.Items10"),
            resources.GetString("com_day.Items11"),
            resources.GetString("com_day.Items12"),
            resources.GetString("com_day.Items13"),
            resources.GetString("com_day.Items14"),
            resources.GetString("com_day.Items15"),
            resources.GetString("com_day.Items16"),
            resources.GetString("com_day.Items17"),
            resources.GetString("com_day.Items18"),
            resources.GetString("com_day.Items19"),
            resources.GetString("com_day.Items20"),
            resources.GetString("com_day.Items21"),
            resources.GetString("com_day.Items22"),
            resources.GetString("com_day.Items23"),
            resources.GetString("com_day.Items24"),
            resources.GetString("com_day.Items25"),
            resources.GetString("com_day.Items26"),
            resources.GetString("com_day.Items27"),
            resources.GetString("com_day.Items28"),
            resources.GetString("com_day.Items29"),
            resources.GetString("com_day.Items30"),
            resources.GetString("com_day.Items31")});
            resources.ApplyResources(this.com_day, "com_day");
            this.com_day.Name = "com_day";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // manPostalcode
            // 
            resources.ApplyResources(this.manPostalcode, "manPostalcode");
            this.manPostalcode.Name = "manPostalcode";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // manProvince
            // 
            resources.ApplyResources(this.manProvince, "manProvince");
            this.manProvince.Name = "manProvince";
            // 
            // manDistrict
            // 
            resources.ApplyResources(this.manDistrict, "manDistrict");
            this.manDistrict.Name = "manDistrict";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // manSubdistrict
            // 
            resources.ApplyResources(this.manSubdistrict, "manSubdistrict");
            this.manSubdistrict.Name = "manSubdistrict";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // manVillage
            // 
            resources.ApplyResources(this.manVillage, "manVillage");
            this.manVillage.Name = "manVillage";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // manHouseNo
            // 
            resources.ApplyResources(this.manHouseNo, "manHouseNo");
            this.manHouseNo.Name = "manHouseNo";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // manNoID
            // 
            resources.ApplyResources(this.manNoID, "manNoID");
            this.manNoID.Name = "manNoID";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // manName
            // 
            resources.ApplyResources(this.manName, "manName");
            this.manName.Name = "manName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // com_num
            // 
            this.com_num.FormattingEnabled = true;
            this.com_num.Items.AddRange(new object[] {
            resources.GetString("com_num.Items"),
            resources.GetString("com_num.Items1"),
            resources.GetString("com_num.Items2")});
            resources.ApplyResources(this.com_num, "com_num");
            this.com_num.Name = "com_num";
            // 
            // but_add
            // 
            this.but_add.BackgroundImage = global::Projects.Properties.Resources.add_icon1;
            resources.ApplyResources(this.but_add, "but_add");
            this.but_add.Name = "but_add";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Name = "label16";
            // 
            // manConfirmPassword
            // 
            resources.ApplyResources(this.manConfirmPassword, "manConfirmPassword");
            this.manConfirmPassword.Name = "manConfirmPassword";
            // 
            // com_status
            // 
            this.com_status.FormattingEnabled = true;
            this.com_status.Items.AddRange(new object[] {
            resources.GetString("com_status.Items"),
            resources.GetString("com_status.Items1"),
            resources.GetString("com_status.Items2")});
            resources.ApplyResources(this.com_status, "com_status");
            this.com_status.Name = "com_status";
            // 
            // Manager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background4;
            this.Controls.Add(this.com_status);
            this.Controls.Add(this.manConfirmPassword);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.manPassword);
            this.Controls.Add(this.manUsername);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.manLastname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.manYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.manVillageNo);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.com_month);
            this.Controls.Add(this.com_day);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.manPostalcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.manProvince);
            this.Controls.Add(this.manDistrict);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.manSubdistrict);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.manVillage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.manHouseNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.manNoID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_num);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem พนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ผจดการToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox manPassword;
        private System.Windows.Forms.TextBox manUsername;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox manLastname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox manYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox manVillageNo;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.ComboBox com_month;
        private System.Windows.Forms.ComboBox com_day;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox manPostalcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox manProvince;
        private System.Windows.Forms.TextBox manDistrict;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manSubdistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox manVillage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox manHouseNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manNoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox manName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_num;
        private System.Windows.Forms.ToolStripMenuItem เพมพนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลพนกงานToolStripMenuItem;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox manConfirmPassword;
        private System.Windows.Forms.ComboBox com_status;
    }
}