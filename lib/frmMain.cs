using System;
using System.Collections;
using System.Windows.Forms;

namespace EricPingNTUSTEmail.lib
{
    public partial class frmMain : Form
    {
        private NTUST_USER user;

        public void refreshAll()
        {
            this.listEmail.Items.Clear();
            frmLoading frmloading = new frmLoading(user, this);
            frmloading.ShowDialog();
            this.SortList(0);
        }

        public frmMain(NTUST_USER user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.refreshAll();
        }

        public void SortList(int column)
        {
            this.listEmail.ListViewItemSorter = new ListViewItemComparer(column);
            this.listEmail.Sort();

        }

        public void AddData(int No, String Subject, String From, String dt, long Size)
        {
            ListViewItem Data = new ListViewItem(No.ToString());
            ListViewItem.ListViewSubItem sub_i2 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub_i3 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub_i4 = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem sub_i5 = new ListViewItem.ListViewSubItem();

            sub_i2.Text = Subject;
            sub_i3.Text = From;
            sub_i4.Text = dt;
            sub_i5.Text = ((float)Size / 1024).ToString() + " KB";
            if (Size == 0)
            {
                sub_i5.Text = "ERROR!!!Please Read Online ^.<";
            }
            Data.SubItems.Add(sub_i2);
            Data.SubItems.Add(sub_i3);
            Data.SubItems.Add(sub_i4);
            Data.SubItems.Add(sub_i5);

            listEmail.Items.Add(Data);
        }

        private void listEmail_Click(object sender, EventArgs e)
        {

            if (this.listEmail.SelectedItems[0].SubItems[4].Text.Contains("ERROR"))
            {
                this.webMail.Navigate("http://mail.ntust.edu.tw/index.html");
            }
            else
            {
                string filename = this.user._folder + "\\" + (listEmail.SelectedItems[0].Index + 1).ToString() + "\\" + "index.html";
                this.webMail.Navigate(filename);
                Application.DoEvents();
            }
        }

        private void 重新整理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(Application.ExecutablePath);
            //this.user.pop3.Disconnect();
            //this.user.Connect();
            this.user._folder = Application.StartupPath;
            this.user.MailList.Clear();
            this.refreshAll();
        }

        private void webMail_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (this.webMail.Url.ToString().Equals("http://mail.ntust.edu.tw/index.html"))
            {
                this.webMail.Document.GetElementById("USERID").InnerText = this.user._user;
                this.webMail.Document.GetElementById("PASSWD").InnerText = this.user._password;
                this.webMail.Document.GetElementById("Submit").InvokeMember("Click");
            }
        }

        private void 刪除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listEmail.SelectedItems.Count == 0)
            {
                MessageBox.Show("請選擇一封要刪除的信，再按下刪除");
                return;
            }
            DialogResult dr = MessageBox.Show("你確定要刪除這封信嗎?\r\n網路上的也會刪唷^_^", "Hello World", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {

                //     this.user.pop3.DeleteMessage(this.user.MailList[this.listEmail.SelectedIndices[0]].Headers.MessageId);
                //this.user.Connect();
                int resultMessageNo = this.user.MessageCount - this.listEmail.SelectedIndices[0];
                this.user.pop3.DeleteMessage(resultMessageNo);
                this.listEmail.Items[this.listEmail.SelectedIndices[0]].Remove();
                // this.重新整理ToolStripMenuItem_Click(sender, e);
            }
        }

        private void 學校信箱網頁SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.webMail.Navigate("http://mail.ntust.edu.tw/index.html");
        }

        private void listEmail_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.SortList(0);
        }
        
        private void 寄信SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSend(this.user).ShowDialog();
        }
        
        private void 附件AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listEmail.SelectedItems.Count == 0)
            {
                MessageBox.Show("請選擇一封信");
                return;
            }
            string folder = this.user._folder + "\\" + (listEmail.SelectedItems[0].Index + 1).ToString();
            System.Diagnostics.Process.Start(folder);
        }

        private partial class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {

                int a = int.Parse(((ListViewItem)x).SubItems[col].Text);
                int b = int.Parse(((ListViewItem)y).SubItems[col].Text);
                if (a > b) return 1;
                if (a < b) return -1;
                return -1;
            }
        }

    }
}
