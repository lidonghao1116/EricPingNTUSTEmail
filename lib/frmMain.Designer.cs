namespace EricPingNTUSTEmail.lib
{
    partial class frmMain
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
            this.listEmail = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.webMail = new System.Windows.Forms.WebBrowser();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.寄信SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新整理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學校信箱網頁SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.附件AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listEmail
            // 
            this.listEmail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.listEmail.FullRowSelect = true;
            this.listEmail.Location = new System.Drawing.Point(0, 24);
            this.listEmail.Name = "listEmail";
            this.listEmail.Size = new System.Drawing.Size(886, 161);
            this.listEmail.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listEmail.TabIndex = 0;
            this.listEmail.UseCompatibleStateImageBehavior = false;
            this.listEmail.View = System.Windows.Forms.View.Details;
            this.listEmail.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listEmail_ColumnClick);
            this.listEmail.Click += new System.EventHandler(this.listEmail_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "From";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DateTime";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Size";
            this.columnHeader5.Width = 280;
            // 
            // webMail
            // 
            this.webMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webMail.Location = new System.Drawing.Point(0, 191);
            this.webMail.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMail.Name = "webMail";
            this.webMail.Size = new System.Drawing.Size(886, 239);
            this.webMail.TabIndex = 1;
            this.webMail.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webMail_DocumentCompleted);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.寄信SToolStripMenuItem,
            this.重新整理ToolStripMenuItem,
            this.附件AToolStripMenuItem,
            this.刪除DToolStripMenuItem,
            this.學校信箱網頁SToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(886, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 寄信SToolStripMenuItem
            // 
            this.寄信SToolStripMenuItem.Name = "寄信SToolStripMenuItem";
            this.寄信SToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.寄信SToolStripMenuItem.Text = "寄信(&S)";
            this.寄信SToolStripMenuItem.Click += new System.EventHandler(this.寄信SToolStripMenuItem_Click);
            // 
            // 重新整理ToolStripMenuItem
            // 
            this.重新整理ToolStripMenuItem.Name = "重新整理ToolStripMenuItem";
            this.重新整理ToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.重新整理ToolStripMenuItem.Text = "重新整理(&R)";
            this.重新整理ToolStripMenuItem.Click += new System.EventHandler(this.重新整理ToolStripMenuItem_Click);
            // 
            // 刪除DToolStripMenuItem
            // 
            this.刪除DToolStripMenuItem.Name = "刪除DToolStripMenuItem";
            this.刪除DToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.刪除DToolStripMenuItem.Text = "刪除(&D)";
            this.刪除DToolStripMenuItem.Click += new System.EventHandler(this.刪除DToolStripMenuItem_Click);
            // 
            // 學校信箱網頁SToolStripMenuItem
            // 
            this.學校信箱網頁SToolStripMenuItem.Name = "學校信箱網頁SToolStripMenuItem";
            this.學校信箱網頁SToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.學校信箱網頁SToolStripMenuItem.Text = "學校信箱網頁(&S)";
            this.學校信箱網頁SToolStripMenuItem.Click += new System.EventHandler(this.學校信箱網頁SToolStripMenuItem_Click);
            // 
            // 附件AToolStripMenuItem
            // 
            this.附件AToolStripMenuItem.Name = "附件AToolStripMenuItem";
            this.附件AToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.附件AToolStripMenuItem.Text = "附件(&A)";
            this.附件AToolStripMenuItem.Click += new System.EventHandler(this.附件AToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 430);
            this.Controls.Add(this.webMail);
            this.Controls.Add(this.listEmail);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listEmail;
        private System.Windows.Forms.WebBrowser webMail;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem 重新整理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 寄信SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 學校信箱網頁SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 附件AToolStripMenuItem;
    }
}