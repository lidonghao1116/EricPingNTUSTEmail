using System;
using System.Threading;
using System.Windows.Forms;

namespace EricPingNTUSTEmail.lib
{
    public partial class frmSend : Form
    {
        private NTUST_USER user;
        public frmSend(NTUST_USER user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnEmailAdd_Click(object sender, EventArgs e)
        {
            if (this.user.addReceiver(this.txtEmail.Text))
            {
                this.listEmail.Items.Add(this.txtEmail.Text);
                this.txtEmail.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Email格式錯誤，或者Email重複");
            }
        }

        private void btnEmailRemove_Click(object sender, EventArgs e)
        {
            if (listEmail.SelectedItems.Count > 0)
            {
                this.user.ReceiverList.Remove((String)listEmail.SelectedItems[0]);
                this.listEmail.Items.RemoveAt(listEmail.SelectedIndex);
            }
            else
            {
                MessageBox.Show("請選擇一個要刪除的Email");
            }
        }

        private void btnAttachmentAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.Title = "Hello World";
                    String filename = ofd.FileName;

                    if (this.user.addAttachment(filename))
                    {
                        this.listAttachment.Items.Add(filename);
                    }
                    else
                    {
                        MessageBox.Show("檔案路徑有錯，或者檔案重複");
                    }
                }
            }
        }

        private void btnAttachmentRemove_Click(object sender, EventArgs e)
        {
            if (listEmail.SelectedItems.Count > 0)
            {
                this.user.AttachmentList.Remove((String)listAttachment.SelectedItems[0]);
                this.listAttachment.Items.RemoveAt(listAttachment.SelectedIndex);

            }
            else
            {
                MessageBox.Show("請選擇一個要刪除的Email");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String subject =this.txtSubject.Text;
            string body = this.txtBody.Text;
            this.Cursor = Cursors.WaitCursor;
            Thread t = new Thread(new ThreadStart(
                () => {
                    try
                    {
                        this.user.sendMail(subject, body + "\r\n 您使用了EricPing的Email，此系統現在還在Beta版，目前還有很多錯誤，請多多支持，期待新版完成…");
                        Invoke(new MethodInvoker(() =>
                        {
                            this.Cursor = Cursors.Default;                            
                        }));
                        MessageBox.Show("發送成功");
                        this.user.ReceiverList.Clear();
                        this.user.AttachmentList.Clear();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                ));
            t.Start();
            
        }

    }
}
