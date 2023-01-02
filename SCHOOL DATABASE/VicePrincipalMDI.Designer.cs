namespace SCHOOL_DATABASE
{
    partial class VicePrincipalMDI
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
            this.fILESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEgistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wINDOWSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERTICALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleCascadeanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILESToolStripMenuItem,
            this.wINDOWSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.wINDOWSToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILESToolStripMenuItem
            // 
            this.fILESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEgistrationToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.fILESToolStripMenuItem.Name = "fILESToolStripMenuItem";
            this.fILESToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fILESToolStripMenuItem.Text = "FILES";
            this.fILESToolStripMenuItem.Click += new System.EventHandler(this.fILESToolStripMenuItem_Click);
            // 
            // rEgistrationToolStripMenuItem
            // 
            this.rEgistrationToolStripMenuItem.Name = "rEgistrationToolStripMenuItem";
            this.rEgistrationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rEgistrationToolStripMenuItem.Text = "Registration";
            this.rEgistrationToolStripMenuItem.Click += new System.EventHandler(this.rEgistrationToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // wINDOWSToolStripMenuItem
            // 
            this.wINDOWSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vERTICALToolStripMenuItem,
            this.titleHorizontalToolStripMenuItem,
            this.titleCascadeanToolStripMenuItem,
            this.arrangeIconToolStripMenuItem});
            this.wINDOWSToolStripMenuItem.Name = "wINDOWSToolStripMenuItem";
            this.wINDOWSToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.wINDOWSToolStripMenuItem.Text = "WINDOWS";
            // 
            // vERTICALToolStripMenuItem
            // 
            this.vERTICALToolStripMenuItem.Name = "vERTICALToolStripMenuItem";
            this.vERTICALToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.vERTICALToolStripMenuItem.Text = "TILE Vertical";
            this.vERTICALToolStripMenuItem.Click += new System.EventHandler(this.vERTICALToolStripMenuItem_Click);
            // 
            // titleHorizontalToolStripMenuItem
            // 
            this.titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
            this.titleHorizontalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.titleHorizontalToolStripMenuItem.Text = "TiLE Horizontal";
            this.titleHorizontalToolStripMenuItem.Click += new System.EventHandler(this.titleHorizontalToolStripMenuItem_Click);
            // 
            // titleCascadeanToolStripMenuItem
            // 
            this.titleCascadeanToolStripMenuItem.Name = "titleCascadeanToolStripMenuItem";
            this.titleCascadeanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.titleCascadeanToolStripMenuItem.Text = "TILE Cascade";
            this.titleCascadeanToolStripMenuItem.Click += new System.EventHandler(this.titleCascadeanToolStripMenuItem_Click);
            // 
            // arrangeIconToolStripMenuItem
            // 
            this.arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            this.arrangeIconToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.arrangeIconToolStripMenuItem.Text = "Arrange Icon";
            this.arrangeIconToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconToolStripMenuItem_Click);
            // 
            // VicePrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 697);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VicePrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VicePrincipalMDI";
            this.Load += new System.EventHandler(this.VicePrincipalMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEgistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wINDOWSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERTICALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleCascadeanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconToolStripMenuItem;

    }
}



