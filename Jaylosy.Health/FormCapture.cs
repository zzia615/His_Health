using DevExpress.Data.Camera;
using DevExpress.XtraEditors.Camera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jaylosy.Health
{
    public partial class FormCapture : Form
    {
        public Image TakeImage { get; set; }
        public FormCapture()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            if (btn_Capture.Text == "拍照")
            {
                simpleButton1.Visible = true;
                pic_view.Image = null;
                pic_view.Visible = true;
                TakeImage = cameraControl1.TakeSnapshot();
                pic_view.Image = TakeImage;
                btn_Capture.Text = "重拍";
            }
            else
            {
                simpleButton1.Visible = false;
                pic_view.Image = null;
                pic_view.Visible = false;
                btn_Capture.Text = "拍照";
            }
        }


        private void FormCapture_Load(object sender, EventArgs e)
        {
        
        }

        private void FormCapture_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraControl1.Stop();
        }
    }
}
