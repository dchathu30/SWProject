﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class Viewphoto : Form
    {

        int num = PhotoViewer.ind, i;
        PictureBox[] p = PhotoViewer.pic;
        int len = PhotoViewer.pic.Length;
        public Viewphoto()
        {
            InitializeComponent();
            i = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num < len - 1)
                pictureBox1.Image = PhotoViewer.pic[++num].Image;
            else if(num==len-1)
            {
                num = len - 2;
                button2.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num > -1)
                pictureBox1.Image = PhotoViewer.pic[num--].Image;
            else if(num==-1)
            {
                num = 0;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void Viewphoto_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = PhotoViewer.pic[num].Image;
        }
    }
}
