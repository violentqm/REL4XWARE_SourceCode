
namespace REL4XWARAE
{
    partial class LoadingUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingUI));
            this.minimizebtn = new Siticone.UI.WinForms.SiticoneButton();
            this.closebtn = new Siticone.UI.WinForms.SiticoneButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.barbackpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.panel1.SuspendLayout();
            this.barbackpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizebtn
            // 
            this.minimizebtn.CheckedState.Parent = this.minimizebtn;
            this.minimizebtn.CustomImages.Parent = this.minimizebtn;
            this.minimizebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.minimizebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizebtn.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.HoveredState.Parent = this.minimizebtn;
            this.minimizebtn.Location = new System.Drawing.Point(338, 5);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.ShadowDecoration.Parent = this.minimizebtn;
            this.minimizebtn.Size = new System.Drawing.Size(15, 18);
            this.minimizebtn.TabIndex = 2;
            this.minimizebtn.Text = "_";
            this.minimizebtn.TextOffset = new System.Drawing.Point(0, -5);
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.CheckedState.Parent = this.closebtn;
            this.closebtn.CustomImages.Parent = this.closebtn;
            this.closebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.HoveredState.Parent = this.closebtn;
            this.closebtn.Location = new System.Drawing.Point(359, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.ShadowDecoration.Parent = this.closebtn;
            this.closebtn.Size = new System.Drawing.Size(14, 21);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "×";
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.minimizebtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 25);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "REL4XWARE";
            // 
            // barbackpanel
            // 
            this.barbackpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.barbackpanel.Controls.Add(this.panel2);
            this.barbackpanel.Location = new System.Drawing.Point(29, 130);
            this.barbackpanel.Name = "barbackpanel";
            this.barbackpanel.Size = new System.Drawing.Size(330, 29);
            this.barbackpanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 29);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loading Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.label3;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 2;
            this.siticoneElipse1.TargetControl = this.barbackpanel;
            // 
            // LoadingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barbackpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingUI";
            this.Text = "LoadingUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barbackpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton minimizebtn;
        private Siticone.UI.WinForms.SiticoneButton closebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel barbackpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
    }
}