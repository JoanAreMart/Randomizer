﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(Program.backColor);
            this.TopMost = Convert.ToBoolean(Program.alwaysOnTop);
            this.Opacity = (double)Program.opacity / 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FormConfig = new Form2();
            FormConfig.Show();
        }
    }
}