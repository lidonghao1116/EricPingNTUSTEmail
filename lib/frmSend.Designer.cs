namespace EricPingNTUSTEmail.lib
{
    partial class frmSend
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
            this.btnEmailAdd = new System.Windows.Forms.Button();
            this.listEmail = new System.Windows.Forms.ListBox();
            this.btnAttachmentAdd = new System.Windows.Forms.Button();
            this.listAttachment = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmailRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAttachmentRemove = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEmailAdd
            // 
            this.btnEmailAdd.Location = new System.Drawing.Point(0, 94);
            this.btnEmailAdd.Name = "btnEmailAdd";
            this.btnEmailAdd.Size = new System.Drawing.Size(368, 23);
            this.btnEmailAdd.TabIndex = 3;
            this.btnEmailAdd.Text = "Add";
            this.btnEmailAdd.UseVisualStyleBackColor = true;
            this.btnEmailAdd.Click += new System.EventHandler(this.btnEmailAdd_Click);
            // 
            // listEmail
            // 
            this.listEmail.FormattingEnabled = true;
            this.listEmail.ItemHeight = 12;
            this.listEmail.Location = new System.Drawing.Point(0, 140);
            this.listEmail.Name = "listEmail";
            this.listEmail.Size = new System.Drawing.Size(368, 136);
            this.listEmail.TabIndex = 4;
            // 
            // btnAttachmentAdd
            // 
            this.btnAttachmentAdd.Location = new System.Drawing.Point(0, 319);
            this.btnAttachmentAdd.Name = "btnAttachmentAdd";
            this.btnAttachmentAdd.Size = new System.Drawing.Size(368, 23);
            this.btnAttachmentAdd.TabIndex = 5;
            this.btnAttachmentAdd.Text = "Add";
            this.btnAttachmentAdd.UseVisualStyleBackColor = true;
            this.btnAttachmentAdd.Click += new System.EventHandler(this.btnAttachmentAdd_Click);
            // 
            // listAttachment
            // 
            this.listAttachment.FormattingEnabled = true;
            this.listAttachment.ItemHeight = 12;
            this.listAttachment.Location = new System.Drawing.Point(0, 365);
            this.listAttachment.Name = "listAttachment";
            this.listAttachment.Size = new System.Drawing.Size(368, 160);
            this.listAttachment.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "附件";
            // 
            // btnEmailRemove
            // 
            this.btnEmailRemove.Location = new System.Drawing.Point(0, 117);
            this.btnEmailRemove.Name = "btnEmailRemove";
            this.btnEmailRemove.Size = new System.Drawing.Size(368, 23);
            this.btnEmailRemove.TabIndex = 4;
            this.btnEmailRemove.Text = "Remove";
            this.btnEmailRemove.UseVisualStyleBackColor = true;
            this.btnEmailRemove.Click += new System.EventHandler(this.btnEmailRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "收件者";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(0, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btnAttachmentRemove
            // 
            this.btnAttachmentRemove.Location = new System.Drawing.Point(0, 342);
            this.btnAttachmentRemove.Name = "btnAttachmentRemove";
            this.btnAttachmentRemove.Size = new System.Drawing.Size(368, 23);
            this.btnAttachmentRemove.TabIndex = 6;
            this.btnAttachmentRemove.Text = "Remove";
            this.btnAttachmentRemove.UseVisualStyleBackColor = true;
            this.btnAttachmentRemove.Click += new System.EventHandler(this.btnAttachmentRemove_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(0, 531);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(833, 40);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(383, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "信件內容";
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBody.Location = new System.Drawing.Point(387, 75);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(446, 450);
            this.txtBody.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "主　旨";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(79, 8);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(743, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // frmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 570);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAttachment);
            this.Controls.Add(this.btnAttachmentRemove);
            this.Controls.Add(this.btnAttachmentAdd);
            this.Controls.Add(this.listEmail);
            this.Controls.Add(this.btnEmailRemove);
            this.Controls.Add(this.btnEmailAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEmailAdd;
        private System.Windows.Forms.ListBox listEmail;
        private System.Windows.Forms.Button btnAttachmentAdd;
        private System.Windows.Forms.ListBox listAttachment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmailRemove;
        private System.Windows.Forms.Button btnAttachmentRemove;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubject;
    }
}