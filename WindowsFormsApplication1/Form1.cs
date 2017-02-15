using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static double ans;
        static double num;
        private void button8_Click(object sender, EventArgs e)
        {
            //2-es szám
            textBox1.Text = textBox1.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1-es szám
            textBox1.Text = textBox1.Text + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //3-as szám
            textBox1.Text = textBox1.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ans = 0;
            num = 0;
            textBox1.Clear();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = ans.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void számolás()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();                
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();                
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    break;

            }
        }
    }

    private void button11_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox1.Focus();
        count 1;
        label1.Text = num.ToString() + "+";

    }
    private void button12_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox1.Focus();
        count 2;
        label1.Text = num.ToString() + "-";

    }
    private void button13_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox1.Focus();
        count 3;
        label1.Text = num.ToString() + "*";

    }
    private void button14_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox1.Focus();
        count 4;
        label1.Text = num.ToString() + "/";

    }


}
