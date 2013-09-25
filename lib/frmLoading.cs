using System;
using System.Threading;
using System.Windows.Forms;
using Message = OpenPop.Mime.Message;

namespace EricPingNTUSTEmail.lib
{
    public partial class frmLoading : Form
    {
        private Boolean isLoaded;
        private NTUST_USER user;
        private frmMain parentForm;
        private Thread t;
        private int t_i = 0;  //停止loading 迴圈用的~
        private int t_end =1; //停止loading 用的~
        public frmLoading(NTUST_USER user, frmMain main)
        {
            InitializeComponent();
            this.user = user;
            this.parentForm = main;
        }

        private void frmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!isLoaded)
            {
                DialogResult result = MessageBox.Show("你的資料還在Loading也，確定要離開程式嗎??", "通知"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // t.Abort();                    
                    this.t_end = this.t_i;
                    e.Cancel = true;
                    // this.Close();
                }
            }
        }


        private void frmLoading_FormClosed(object sender, FormClosedEventArgs e)
        {
           
          
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            t = new Thread(new ThreadStart(() =>
                 {
                     int count = this.user.pop3.GetMessageCount();

                     Invoke(new MethodInvoker(() =>
                         {
                             this.progressLoading.Minimum = 0;
                             this.progressLoading.Maximum = count;
                             this.lblCount.Text = 0 + "/" + this.progressLoading.Maximum;
                         }));
                     for (this.t_i = count; this.t_i >= this.t_end; this.t_i--)
                     {
                         int i = this.t_i;
                         Message email = this.user.pop3.GetMessage(i);
                         int index = this.user.MessageCount + 1 - i;
                         this.user.ProgressEmail(email, index);
                         Invoke(new MethodInvoker(() =>
                         {
                             this.lblCount.Text = (++this.progressLoading.Value) + "/" + this.progressLoading.Maximum;
                             long dirsize = this.user.DirSize(this.user._folder + "\\" + index.ToString());

                             this.parentForm.AddData(index, email.Headers.Subject, email.Headers.From.Address, email.Headers.Date, dirsize);
                         }));
                     }
                     this.isLoaded = true;
                     Invoke(new MethodInvoker(() =>
                        {
                            this.Close();
                        }));
                 }

             ));
            t.Start();
        }

        
    }
}
