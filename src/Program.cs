using System;
using System.Windows.Forms;

namespace msfs2020_updates_disabler
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisablerForm());
        }
    }
}
