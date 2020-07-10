using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float a, b;
        public int count;
        bool znak = true;

        public void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        public void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        public void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        public void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        public void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        public void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        public void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        public void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text=textBox1.Text.Replace("-", "");
                znak = true;
            }
            
        }

        public void calculate()
        {
            Class3 cl = new Class3();
            cl.a = this.a;
            cl.textBox1.Text = this.textBox1.Text;
            cl.count = this.count;
            textBox1.Text = "";
            label1.Text = "";
            cl.Calculate();
            textBox1.Text= cl.textBox1.Text;
            count = 0;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        public void button_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button4":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 1;
                    label1.Text = a.ToString() + "+";
                    znak = true;
                    break;
                case "button8":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 2;
                    label1.Text = a.ToString() + "-";
                    znak = true;
                    break;
                case "button12":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 3;
                    label1.Text = a.ToString() + "*";
                    znak = true;
                    break;
                case "button16":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 4;
                    label1.Text = a.ToString() + "/";
                    znak = true;
                    break;
                case "button19"://равно
                    calculate();
                    break;
                case "button20":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 5;
                    label1.Text = a.ToString() + " и ";
                    znak = true;
                    break;
                case "button21":
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = a.ToString() + " ^2";
                    count = 6;
                    znak = true;
                    calculate();
                    break;
                default:
                    break;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        
    }
}
