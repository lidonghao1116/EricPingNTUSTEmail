using EricPingNTUSTEmail.lib;
using System;
using System.Windows.Forms;
namespace EricPingNTUSTEmail
{

    static class Program
    {
        private static NTUST_USER user;
        [STAThread]
        static void Main()
        {
            user = frmLogin.GetUserLogin();
            user._folder = Application.StartupPath;
            if (user._status != LoginStatus.Success)
            {
                MessageBox.Show("系統錯誤，Hacker入侵\n#____#");
                Environment.Exit(0);
            }
            user.ConnectSmtp();
            frmMain main = new frmMain(user);
            main.ShowDialog();
            Console.Read();         
        }          
    }
}

