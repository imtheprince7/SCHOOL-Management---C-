namespace SCHOOL_DATABASE
{
    partial class TeachersMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMISSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHOWRECORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPADTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTTENDENCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSEMESTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iISEMESTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fINALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTSToolStripMenuItem,
            this.rECORDSToolStripMenuItem,
            this.mARKSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1650, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTSToolStripMenuItem
            // 
            this.sTUDENTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMISSIONToolStripMenuItem,
            this.sHOWRECORDToolStripMenuItem,
            this.uPADTEToolStripMenuItem,
            this.dELETEToolStripMenuItem1});
            this.sTUDENTSToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTSToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.sTUDENTSToolStripMenuItem.Name = "sTUDENTSToolStripMenuItem";
            this.sTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(158, 36);
            this.sTUDENTSToolStripMenuItem.Text = "STUDENTS";
            // 
            // aDMISSIONToolStripMenuItem
            // 
            this.aDMISSIONToolStripMenuItem.ForeColor = System.Drawing.Color.ForestGreen;
            this.aDMISSIONToolStripMenuItem.Name = "aDMISSIONToolStripMenuItem";
            this.aDMISSIONToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.aDMISSIONToolStripMenuItem.Text = "ADMISSION";
            this.aDMISSIONToolStripMenuItem.Click += new System.EventHandler(this.aDMISSIONToolStripMenuItem_Click);
            // 
            // sHOWRECORDToolStripMenuItem
            // 
            this.sHOWRECORDToolStripMenuItem.ForeColor = System.Drawing.Color.DarkMagenta;
            this.sHOWRECORDToolStripMenuItem.Name = "sHOWRECORDToolStripMenuItem";
            this.sHOWRECORDToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.sHOWRECORDToolStripMenuItem.Text = "SHOW RECORD";
            this.sHOWRECORDToolStripMenuItem.Click += new System.EventHandler(this.sHOWRECORDToolStripMenuItem_Click);
            // 
            // uPADTEToolStripMenuItem
            // 
            this.uPADTEToolStripMenuItem.Name = "uPADTEToolStripMenuItem";
            this.uPADTEToolStripMenuItem.Size = new System.Drawing.Size(304, 40);
            this.uPADTEToolStripMenuItem.Text = "UPDATE";
            this.uPADTEToolStripMenuItem.Click += new System.EventHandler(this.uPADTEToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem1
            // 
            this.dELETEToolStripMenuItem1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dELETEToolStripMenuItem1.Name = "dELETEToolStripMenuItem1";
            this.dELETEToolStripMenuItem1.Size = new System.Drawing.Size(304, 40);
            this.dELETEToolStripMenuItem1.Text = "DELETE";
            this.dELETEToolStripMenuItem1.Click += new System.EventHandler(this.dELETEToolStripMenuItem1_Click);
            // 
            // rECORDSToolStripMenuItem
            // 
            this.rECORDSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTTENDENCEToolStripMenuItem});
            this.rECORDSToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rECORDSToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.rECORDSToolStripMenuItem.Name = "rECORDSToolStripMenuItem";
            this.rECORDSToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.rECORDSToolStripMenuItem.Text = "RECORDS";
            // 
            // aTTENDENCEToolStripMenuItem
            // 
            this.aTTENDENCEToolStripMenuItem.Name = "aTTENDENCEToolStripMenuItem";
            this.aTTENDENCEToolStripMenuItem.Size = new System.Drawing.Size(271, 38);
            this.aTTENDENCEToolStripMenuItem.Text = "ATTENDENCE";
            // 
            // mARKSToolStripMenuItem
            // 
            this.mARKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iSEMESTERToolStripMenuItem,
            this.iISEMESTERToolStripMenuItem,
            this.fINALToolStripMenuItem});
            this.mARKSToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mARKSToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.mARKSToolStripMenuItem.Name = "mARKSToolStripMenuItem";
            this.mARKSToolStripMenuItem.Size = new System.Drawing.Size(117, 36);
            this.mARKSToolStripMenuItem.Text = "MARKS";
            this.mARKSToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // iSEMESTERToolStripMenuItem
            // 
            this.iSEMESTERToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSEMESTERToolStripMenuItem.ForeColor = System.Drawing.Color.Fuchsia;
            this.iSEMESTERToolStripMenuItem.Name = "iSEMESTERToolStripMenuItem";
            this.iSEMESTERToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.iSEMESTERToolStripMenuItem.Text = "I TERM";
            this.iSEMESTERToolStripMenuItem.Click += new System.EventHandler(this.iSEMESTERToolStripMenuItem_Click);
            // 
            // iISEMESTERToolStripMenuItem
            // 
            this.iISEMESTERToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iISEMESTERToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.iISEMESTERToolStripMenuItem.Name = "iISEMESTERToolStripMenuItem";
            this.iISEMESTERToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.iISEMESTERToolStripMenuItem.Text = "II TERM";
            this.iISEMESTERToolStripMenuItem.Click += new System.EventHandler(this.iISEMESTERToolStripMenuItem_Click);
            // 
            // fINALToolStripMenuItem
            // 
            this.fINALToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fINALToolStripMenuItem.ForeColor = System.Drawing.Color.BlueViolet;
            this.fINALToolStripMenuItem.Name = "fINALToolStripMenuItem";
            this.fINALToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.fINALToolStripMenuItem.Text = "FINAL";
            this.fINALToolStripMenuItem.Click += new System.EventHandler(this.fINALToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(840, 1009);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 1009);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(840, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 98);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(416, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(168, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 46);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher ID";
            // 
            // TeachersMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SCHOOL_DATABASE.Properties.Resources.TeachersPic1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1650, 1049);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeachersMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeachersMDI";
            this.Load += new System.EventHandler(this.TeachersMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECORDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMISSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTTENDENCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSEMESTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iISEMESTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fINALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHOWRECORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPADTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;


    }
}



