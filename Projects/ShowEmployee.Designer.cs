namespace Projects
{
    partial class ShowEmployee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.but_print = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.พนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ผจดการToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_search1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 410);
            this.dataGridView1.TabIndex = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 195;
            this.label2.Text = "ค้นหาสมาชิก";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(309, 140);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 20);
            this.tb_search.TabIndex = 194;
            // 
            // but_search
            // 
            this.but_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search.Location = new System.Drawing.Point(525, 138);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(109, 23);
            this.but_search.TabIndex = 193;
            this.but_search.Text = "แสดงทั้งหมด";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 192;
            this.label1.Text = "รายชื่อสมาชิกทั้งหมด";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Projects.Properties.Resources.add_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(932, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 62);
            this.button3.TabIndex = 198;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // but_print
            // 
            this.but_print.BackgroundImage = global::Projects.Properties.Resources.print_icon;
            this.but_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_print.Location = new System.Drawing.Point(862, 110);
            this.but_print.Name = "but_print";
            this.but_print.Size = new System.Drawing.Size(64, 62);
            this.but_print.TabIndex = 197;
            this.but_print.UseVisualStyleBackColor = true;
            this.but_print.Click += new System.EventHandler(this.but_print_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muneToolStripMenuItem,
            this.พนกงานToolStripMenuItem,
            this.ผจดการToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 108);
            this.menuStrip1.TabIndex = 231;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muneToolStripMenuItem
            // 
            this.muneToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.muneToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muneToolStripMenuItem.Image = global::Projects.Properties.Resources.home_icon;
            this.muneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.muneToolStripMenuItem.Name = "muneToolStripMenuItem";
            this.muneToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.muneToolStripMenuItem.Text = "หน้าแรก";
            this.muneToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.muneToolStripMenuItem.Click += new System.EventHandler(this.muneToolStripMenuItem_Click);
            // 
            // พนกงานToolStripMenuItem
            // 
            this.พนกงานToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.พนกงานToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เพมพนกงานToolStripMenuItem,
            this.ขอมลพนกงานToolStripMenuItem});
            this.พนกงานToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.พนกงานToolStripMenuItem.Image = global::Projects.Properties.Resources.employee_icon;
            this.พนกงานToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.พนกงานToolStripMenuItem.Name = "พนกงานToolStripMenuItem";
            this.พนกงานToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.พนกงานToolStripMenuItem.Text = "พนักงาน";
            this.พนกงานToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // เพมพนกงานToolStripMenuItem
            // 
            this.เพมพนกงานToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.เพมพนกงานToolStripMenuItem.Name = "เพมพนกงานToolStripMenuItem";
            this.เพมพนกงานToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.เพมพนกงานToolStripMenuItem.Text = "เพิ่มพนักงาน";
            this.เพมพนกงานToolStripMenuItem.Click += new System.EventHandler(this.เพมพนกงานToolStripMenuItem_Click);
            // 
            // ขอมลพนกงานToolStripMenuItem
            // 
            this.ขอมลพนกงานToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem";
            this.ขอมลพนกงานToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ขอมลพนกงานToolStripMenuItem.Text = "ข้อมูลพนักงาน";
            this.ขอมลพนกงานToolStripMenuItem.Click += new System.EventHandler(this.ขอมลพนกงานToolStripMenuItem_Click);
            // 
            // ผจดการToolStripMenuItem
            // 
            this.ผจดการToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ผจดการToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ผจดการToolStripMenuItem.Image = global::Projects.Properties.Resources.manager_icon_mini;
            this.ผจดการToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ผจดการToolStripMenuItem.Name = "ผจดการToolStripMenuItem";
            this.ผจดการToolStripMenuItem.Size = new System.Drawing.Size(92, 104);
            this.ผจดการToolStripMenuItem.Text = "ผู้จัดการ";
            this.ผจดการToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ผจดการToolStripMenuItem.Click += new System.EventHandler(this.ผจดการToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ออกจากระบบToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ออกจากระบบToolStripMenuItem.Image = global::Projects.Properties.Resources.exit_icon;
            this.ออกจากระบบToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(102, 104);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // but_search1
            // 
            this.but_search1.BackColor = System.Drawing.Color.Transparent;
            this.but_search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_search1.Location = new System.Drawing.Point(425, 138);
            this.but_search1.Name = "but_search1";
            this.but_search1.Size = new System.Drawing.Size(82, 23);
            this.but_search1.TabIndex = 232;
            this.but_search1.Text = "ค้นหา";
            this.but_search1.UseVisualStyleBackColor = false;
            this.but_search1.Click += new System.EventHandler(this.but_search1_Click);
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projects.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.but_search1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.but_print);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.but_search);
            this.Controls.Add(this.label1);
            this.Name = "ShowEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพนักงาน";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button but_print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem muneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem พนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมพนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลพนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ผจดการToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.Button but_search1;
    }
}