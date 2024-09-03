using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21计科2班_马菁含_069_选课窗体_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jichu;
        string yuyan;
        string yingyong;
        string ch1;
        string ch2;
        string ch3;
        string ch4;
        string ch5;

        private void a1()
        {
            yingyong = "\n\n应用："+ch1 + ch2 + ch3 + ch4 + ch5;
            if(yingyong== "\n\n应用：")
            {
                yingyong = "";
            }

            show_Label.Text= "您的选课结果如下：" +jichu +yuyan+ yingyong;
        }

        private void btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (btn1.Checked)
            {
                jichu = "\n\n基础：" + btn1.Text;
                a1();
            }

        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (btn2.Checked)
            {
                jichu = "\n\n基础：" + btn2.Text;
                a1();
            }
        }

        private void btn3_CheckedChanged(object sender, EventArgs e)
        {
            if (btn3.Checked)
            {
                yuyan = "\n\n语言：" + btn3.Text;
                a1();
            }
        } 

        private void btn4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btn4.Checked)
            {
                yuyan = "\n\n语言：" + btn4.Text;
                a1();
            }
        }

        private void btn5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btn5.Checked)
            {
                yuyan = "\n\n语言：" + btn5.Text;
                a1();
            }
        }

        private void btn6_CheckedChanged(object sender, EventArgs e)
        {
            if (btn6.Checked)
            {
                yuyan = "\n\n语言：" + btn6.Text;
                a1();
            }
        }

        private void btn7_CheckedChanged(object sender, EventArgs e)
        {
            if (btn7.Checked)
            {
                yuyan = "\n\n语言：" + btn7.Text;
                a1();
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                ch1 = cb1.Text + " ";
                
            }
            if (!cb1.Checked)
            {
                ch1 = "";
            }
            a1();
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                ch2 = cb2.Text + " ";

            }
            if (!cb2.Checked)
            {
                ch2 = "";
            }
            a1();
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                ch3 = cb3.Text + " ";

            }
            if (!cb3.Checked)
            {
                ch3 = "";
            }
            a1();
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                ch4 = cb4.Text + " ";

            }
            if (!cb4.Checked)
            {
                ch4 = "";
            }
            a1();
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked)
            {
                ch5 = cb5.Text+" ";

            }
            if (!cb5.Checked)
            {
                ch5 = "";
            }
            a1();
        }
    }
}
