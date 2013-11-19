using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
    public partial class ReadMe : CentralUse
    {
        public ReadMe()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎下次使用！", "温馨提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LoginUI objLoginUI = new LoginUI();
            //objLoginUI.ShowDialog();
            objLoginUI.Show();
            this.Hide();
        }

        public class SendMail
        {
            [DllImport("shell32.dll", EntryPoint = "ShellExecuteA")]
            
            public static extern int ShellExecute
            (
                    int hwnd,
                    String lpOperation,
                    String lpFile,
                    String lpParameters,
                    String lpDirectory,
                    int nShowCmd
             );
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                try
                {
                    SendMail.ShellExecute(0, String.Empty, "mailto:邮箱地址", String.Empty, String.Empty, 1);
                }
                catch
                {
                    MessageBox.Show("未找到符合要求的邮箱客户端支持此功能！");
                }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mail.qq.com");
            System.Diagnostics.Process.Start("http://www.baidu.com/s?ie=utf-8&bs=%E9%82%AE%E7%AE%B1&f=3&rsv_bp=1&rsv_spt=3&wd=%E9%82%AE%E7%AE%B1%E7%99%BB%E9%99%86");
        }

      
    }
}
