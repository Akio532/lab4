﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class NewSize : Form
    {
        int size;
        public NewSize()
        {
            InitializeComponent();
            size = -1;
        }

        public int Size
        {
            get => size;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            size = (int)sizeUpDown.Value;
            Close();
        }
    }
}