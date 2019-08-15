using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jaylosy.Health
{
    public partial class ucPatInfo : UserControl
    {
        public ucPatInfo()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pic_photo.Image = null;
        }

        private void ucPatInfo_Load(object sender, EventArgs e)
        {
            pic_photo.Properties.ContextMenu = new ContextMenu();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "jpg图片(*jpg)|*.jpg|jpeg图片(*.jpeg)|*.jpeg|bmp图片(*.bmp)|*.bmp|png图片(*.png)|*.png";
            if(openFileDialog1.ShowDialog()!= DialogResult.OK)
            {
                return;
            }
            string s_fileName = openFileDialog1.FileName;
            pic_photo.Image = new Bitmap(s_fileName);
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            FormCapture formCapture = new FormCapture();
            var result = formCapture.ShowDialog();
            if(result!= DialogResult.OK)
            {
                return;
            }
            pic_photo.Image = formCapture.TakeImage;
        }
    }
}
