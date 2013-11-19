using System;
using System.Runtime.InteropServices;

namespace DAL
{
    public class SendMailDAL
    {
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteA")]
        public static extern int ShellExecute(
         int hwnd,
         String lpOperation,
         String lpFile,
         String lpParameters,
         String lpDirectory,
         int nShowCmd
         );
    }
}
