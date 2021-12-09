using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace REL4XWARAE
{
    public partial class LoadingUI : Form
    {
        public LoadingUI()
        {
            InitializeComponent();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            WebClient wb = new WebClient();
            await Task.Delay(1000);
            panel2.Width = 110;
            label1.Text = "Checking Version";
            await Task.Delay(500);
            if(!wb.DownloadString("https://raw.githubusercontent.com/Nuggetz9999/REL4XWARE/main/checkversion").Contains("1.0"))
            {
                label1.Text = "Old Version detected";
                MessageBox.Show("You don't have the lastest version! Dm REL4X#7447 for the updated one");
                await Task.Delay(1000);
                Application.Exit();
            }
            else
            {
                label1.Text = "Checking Patch status";
                panel2.Width = 190;
                await Task.Delay(1000);
                if (!wb.DownloadString("https://raw.githubusercontent.com/Nuggetz9999/REL4XWARE/main/patchcheck").Contains("notpatched"))
                {
                    label1.Text = "Exploit Patched";
                    MessageBox.Show("REL4XWARE is currently patched. Try again later");
                    await Task.Delay(1000);
                    Application.Exit();
                }
                else
                {
                    label1.Text = "Loading REL4XWARE";
                    panel2.Width = 280;
                    await Task.Delay(2000);
                    label1.Text = "Finished";
                    panel2.Width = 330;
                    await Task.Delay(1000);
                    this.Hide();
                    MainUI main = new MainUI();
                    main.Show();

                }
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
