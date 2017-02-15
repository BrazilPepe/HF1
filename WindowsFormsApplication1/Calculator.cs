using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    class Calculator
    {
       double num, ans;
       public int b;
       public static int count;
        //public static string c;
        public void számolás()
        {
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    num = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count 1;
                    label1.Text = num.ToString() + "+";

                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    num = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count 2;
                    label1.Text = num.ToString() + "-";

                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    num = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count 3;
                    label1.Text = num.ToString() + "*";

                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox.Text = ans.ToString();
                    num = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                    count 4;
                    label1.Text = num.ToString() + "/";

                    break;



            }

        }



    }
}
