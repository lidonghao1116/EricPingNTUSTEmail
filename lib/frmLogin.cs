using EricPingNTUSTEmail.lib;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EricPingNTUSTEmail
{
    public partial class frmLogin : Form
    {
        public NTUST_USER _user;

        private Boolean isWaiting;
        public frmLogin(NTUST_USER user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void Check()
        {
            if (isWaiting == false)
            {
                isWaiting = true;

                Thread t = new Thread(new ThreadStart(() =>
                {
                    this._user.setUserPassword(this.txtStuID.Text, this.txtPassword.Text);
                    this._user.ConnectPop();
                    String message = "連線成功！";
                    switch (this._user._status)
                    {
                        case LoginStatus.ServerError:
                            message = "Server 連不上，可能是學校的問題！\n請稍後再連線。";
                            break;
                        case LoginStatus.InvalidUser:
                            message = "帳號密碼錯誤，請重新輸入！";
                            break;
                    }
                    MessageBox.Show(message, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (this._user._status == LoginStatus.Success)
                    {
                        Invoke(new MethodInvoker(() =>
                        {
                            this.Close();
                        }));

                    }
                    else
                    {
                        isWaiting = false;
                    }
                }));

                t.Start();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Check();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static NTUST_USER GetUserLogin()
        {
            NTUST_USER user = new NTUST_USER();
            frmLogin login = new frmLogin(user);
            login.ShowDialog();
            if (user == null)
                MessageBox.Show("NULL");

            return user;
        }

        /// <summary>
        /// FormEvent
        /// </summary>
        private void SendData(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               Check();
            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this._user._status != LoginStatus.Success)
                Environment.Exit(0);
        }
    }
}
