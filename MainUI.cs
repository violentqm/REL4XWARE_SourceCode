using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using WeAreDevs_API;


namespace REL4XWARAE
{
    public partial class MainUI : Form
    {
        ExploitAPI api = new ExploitAPI();
        public MainUI()
        {
            InitializeComponent();
            label1.Text = "Logged in as " + Environment.UserName;
            
            
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Enter(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text == "--REL4XWARE ON TOP")
            {
                fastColoredTextBox1.Text = "";
            }
            
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            api.SendLuaScript(fastColoredTextBox1.Text);
            
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            Commands cmdui = new Commands();
            cmdui.Show();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            UtilUI util = new UtilUI();
            util.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(api.isAPIAttached())
            {
                loadbtn.Text = "Injected";
            }
            else
            {
                loadbtn.Text = "Inject";
            }
        }
    }
}
