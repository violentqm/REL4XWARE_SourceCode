using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace REL4XWARAE
{
    public partial class UtilUI : Form
    {
        string clientfixpath = "C:\\REL4XWARE\\clientfix.bat";
        string instancepath = "C:\\REL4XWARE\\MultiInstances.exe";
        string designpath = "C:\\REL4XWARE\\MetroFramework.Design.dll";
        string frameworkpath = "C:\\REL4XWARE\\MetroFramework.dll";
        string fontspath = "C:\\REL4XWARE\\MetroFramework.Fonts.dll";
        string fpspath = "C:\\REL4XWARE\\rbxfpsunlocker.exe";
        string shadepath = "C:\\REL4XWARE\\shadersetup.exe";
        public UtilUI()
        {
            InitializeComponent();
            label1.Text = "Logged in as " + Environment.UserName;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient upcheck = new WebClient();
                Process.Start("taskkill", "/F /IM rbxfpsunlocker.exe");
                Directory.CreateDirectory("C:\\REL4XWARE\\");
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/896799851642257438/clientfix.bat", clientfixpath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/896846656484569118/MetroFramework.Design.dll", designpath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/896846658648829983/MetroFramework.dll", frameworkpath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/896846660448157716/MetroFramework.Fonts.dll", fontspath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/896846661987471411/MultiInstances.exe", instancepath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/897119516360843264/rbxfpsunlocker.exe", fpspath);
                upcheck.DownloadFile("https://cdn.discordapp.com/attachments/868472759657836547/897120925282074664/shadersetup.exe", shadepath);
                MessageBox.Show("Successfuly downloaded all utilities.");
            }
            catch
            {
                MessageBox.Show("Couldn't download all utilities.");
            }
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.Start(clientfixpath);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(File.Exists(clientfixpath))
            {
                siticoneButton1.Enabled = true;
            }
            else
            {
                siticoneButton1.Enabled = false;
            }
            if(File.Exists(fpspath))
            {
                siticoneButton2.Enabled = true;

            }
            else
            {
                siticoneButton2.Enabled = false;
            }
            if (File.Exists(instancepath))
            {
                siticoneButton3.Enabled = true;

            }
            else
            {
                siticoneButton3.Enabled = false;
            }
            if (File.Exists(shadepath))
            {
                siticoneButton4.Enabled = true;

            }
            else
            {
                siticoneButton4.Enabled = false;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start(fpspath);
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Process.Start(instancepath);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Process.Start("taskkill", "/F /IM RobloxPlayerBeta.exe");
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Process.Start(shadepath);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
