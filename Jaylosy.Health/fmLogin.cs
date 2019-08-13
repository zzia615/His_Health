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
            DatabaseManager db = new DatabaseManager("defaultDb");
            dataSet1 = db.QueryDataset("select * from sysobjects");
            dataGridView1.DataSource = dataSet1.Tables[0];
        }
    }
}
