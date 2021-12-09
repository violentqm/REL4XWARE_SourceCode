using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace REL4XWARAE
{
    public partial class Commands : Form
    {
        ExploitAPI api = new ExploitAPI();
        public Commands()
        {
            InitializeComponent();
            label1.Text = "Logged in as " + Environment.UserName;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void siticoneSlider2_ValueChanged(object sender, EventArgs e)
        {
            api.SetJumpPower(siticoneSlider2.Value);
            
        }


        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            api.DoBTools();
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            api.Suicide();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            api.ToggleFloat();

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            api.AddForcefield();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            api.RemoveForceField();
            
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            api.AddSmoke();
            
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            api.RemoveFire();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            api.RemoveLegs();
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            api.RemoveArms();
        }
    }
}
