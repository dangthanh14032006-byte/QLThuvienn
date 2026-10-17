namespace QLThuVienn
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlydocgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblform = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlydocgiaToolStripMenuItem,
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýTácGiảToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Đăng xuất ";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // quanlydocgiaToolStripMenuItem
            // 
            this.quanlydocgiaToolStripMenuItem.Name = "quanlydocgiaToolStripMenuItem";
            this.quanlydocgiaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.quanlydocgiaToolStripMenuItem.Text = "Quản Lý Độc Giả";
            this.quanlydocgiaToolStripMenuItem.Click += new System.EventHandler(this.quanlydocgiaToolStripMenuItem_Click);
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản Lý Sách";
            // 
            // quảnLýTácGiảToolStripMenuItem
            // 
            this.quảnLýTácGiảToolStripMenuItem.Name = "quảnLýTácGiảToolStripMenuItem";
            this.quảnLýTácGiảToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.quảnLýTácGiảToolStripMenuItem.Text = "Quản Lý Tác Giả";
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýMượnToolStripMenuItem,
            this.quảnLýTrảToolStripMenuItem});
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản Lý Mượn Trả";
            // 
            // quảnLýMượnToolStripMenuItem
            // 
            this.quảnLýMượnToolStripMenuItem.Name = "quảnLýMượnToolStripMenuItem";
            this.quảnLýMượnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýMượnToolStripMenuItem.Text = "Quản Lý Mượn";
            // 
            // quảnLýTrảToolStripMenuItem
            // 
            this.quảnLýTrảToolStripMenuItem.Name = "quảnLýTrảToolStripMenuItem";
            this.quảnLýTrảToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýTrảToolStripMenuItem.Text = "Quản Lý Trả";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 402);
            this.panel1.TabIndex = 2;
            // 
            // lblform
            // 
            this.lblform.AutoSize = true;
            this.lblform.Location = new System.Drawing.Point(12, 33);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(0, 16);
            this.lblform.TabIndex = 3;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlydocgiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblform;
    }
}