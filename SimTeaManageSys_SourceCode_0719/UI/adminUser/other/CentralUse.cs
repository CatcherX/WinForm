using System;
using System.Windows.Forms;

namespace UI
{
    public partial class CentralUse : Form
    {
        public CentralUse()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void MainFileOpenExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFileReload_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


    }
}
