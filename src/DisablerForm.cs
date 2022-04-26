using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace msfs2020_updates_disabler
{
    public partial class DisablerForm : Form
    {
        private const string ipToUse = "127.0.0.1";
        private const string hostToDisable = "xvcf1.xboxlive.com";
        private const string hostsFile = @"C:\Windows\System32\drivers\etc\hosts";

        private bool disabled = false;

        public DisablerForm()
        {
            InitializeComponent();
        }

        private string GetLine()
        {
            return ipToUse + " " + hostToDisable;
        }

        private void CheckDisabled()
        {
            string[] hosts = File.ReadAllLines(hostsFile);

            foreach (string host in hosts)
            {
                if (host == GetLine())
                {
                    disabled = true;
                    magicButton.Text = "ENABLE UPDATES";
                    magicButton.BackColor = System.Drawing.Color.Green;
                    return;
                }
            }

            magicButton.Text = "DISABLE UPDATES";
            magicButton.BackColor = System.Drawing.Color.DarkRed;
            disabled = false;
        }



        private void DisablerForm_Load(object sender, EventArgs e)
        {
            CheckDisabled();
        }


        [DllImport("dnsapi.dll", EntryPoint = "DnsFlushResolverCache")]
        private static extern UInt32 DnsFlushResolverCache();

        private void magicButton_Click(object sender, EventArgs e)
        {
            if(disabled)
            {
                File.WriteAllLines(
                    hostsFile,
                    File.ReadLines(hostsFile).Where(l => l != GetLine()).ToArray()
                );
            }
            else
            {
                using (StreamWriter sw = File.AppendText(hostsFile))
                    sw.WriteLine(GetLine());
            }

            DnsFlushResolverCache();

            CheckDisabled();
        }
    }
}
