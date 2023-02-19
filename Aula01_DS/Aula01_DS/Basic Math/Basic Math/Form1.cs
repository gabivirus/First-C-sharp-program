﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Math
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double value, result;

            value = double.Parse(textBoxValue.Text);
            result = value * 2;

            textBoxResult.Text = result.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
            textBoxValue.Clear();
        }
    }
}
