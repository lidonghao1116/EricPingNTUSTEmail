using System;
using System.Windows.Forms;

namespace EricPingNTUSTEmail.lib
{
    public partial class frmPathSelect : Form
    {
        private Boolean NextClicked;

        public frmPathSelect()
        {
            InitializeComponent();
            this.txtPath.Text = Application.StartupPath;

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (this.txtPath.Text != "")
            {
                this.folderDialog.SelectedPath = this.txtPath.Text;
            }
            if (this.folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtPath.Text = this.folderDialog.SelectedPath;
                this.btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.NextClicked = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmPathSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!this.NextClicked)
                Environment.Exit(0);
        }

        public static String GetFolderPath()
        {
            frmPathSelect frm = new frmPathSelect();
            frm.ShowDialog();
            return frm.txtPath.Text;
        }

    }
}
