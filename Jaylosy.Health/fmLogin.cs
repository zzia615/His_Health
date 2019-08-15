using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jaylosy.Kernel.Database;
using Jaylosy.Kernel.Extension;
namespace Jaylosy.Health
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucPatInfo patInfo = new ucPatInfo();
            patInfo.Dock = DockStyle.Fill;
            patInfo.AutoScaleMode = AutoScaleMode.Dpi;
            patInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Clear();
            panel1.Controls.Add(patInfo);
        }
    }
}
