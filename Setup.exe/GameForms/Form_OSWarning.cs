﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.exe.GameForms
{
    public partial class Form_OSWarning : GameForm
    {
        public Form_OSWarning()
        {
            InitializeComponent();
        }

        private void label_publisher_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameManager.Instance.NextEvent();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            button2.Text = "Run";
            button1.Text = "Don't Run";
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button2.Text = "Don't Run";
            button1.Text = "Run";
        }
    }
}
