﻿using PictureBox_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            // lblTitle.Text = "Boy";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            // lblTitle.Text = "Girl";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            // lblTitle.Text = "Book";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            //  lblTitle.Text = "Pen";
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();


        }
    }
}
