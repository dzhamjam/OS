﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if(textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double dn1, dn2,res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = MyLib.MyLibrary.Addition(dn1, dn2);
            }
            if (D == "-")
            {
                res = MyLib.MyLibrary.Substract(dn1, dn2);
            }
            if (D == "X")
            {
                res = MyLib.MyLibrary.Multiply(dn1, dn2);
            }
            if (D == "/")
            {
                res = MyLib.MyLibrary.Divide(dn1, dn2);
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
