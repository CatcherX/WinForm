using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmContactAuthor : CentralUse
    {
        public frmContactAuthor()
        {
            InitializeComponent();
        }

        private void frmContactAuthor_Load(object sender, EventArgs e)
        {

        }

        private void lLbQqZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://user.qzone.qq.com/189174112/");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnblogs.com/catcherx/");
        }

        private void LnkBccn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bccn.net/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.csdn.net/");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
