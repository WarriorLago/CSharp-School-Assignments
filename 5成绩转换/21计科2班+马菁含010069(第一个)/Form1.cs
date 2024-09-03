using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21计科2班_马菁含010069_第一个_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            if (num_100.Text != "" && num_5.Text == "")
            {
                string result = "";
                if (int.Parse(num_100.Text) > 100)
                {
                    MessageBox.Show("输入错误：百分制成绩不能超过 100");
                    result = "";
                }
                else if (int.Parse(num_100.Text) >= 90)
                {
                    result = "优秀";
                }
                else if (int.Parse(num_100.Text) >= 80)
                {
                    result = "良";
                }
                else if (int.Parse(num_100.Text) >= 70)
                {
                    result = "中";
                }
                else if (int.Parse(num_100.Text) >= 60)
                {
                    result = "及格";
                }
                else
                {
                    result = "不及格";
                }
                num_5.Text = result;
            }
            else if (num_100.Text == "" && num_5.Text != "")
            {
                string score ="";

                if (num_5.Text == "优秀")
                {
                    score = "90-100";
                }
                else if (num_5.Text == "良")
                {
                    score = "80-90";
                }
                else if (num_5.Text == "中")
                {
                    score = "70-80";
                }
                else if (num_5.Text == "及格")
                {
                    score = "60-70";
                }
                else if (num_5.Text == "不及格")
                {
                    score = "0-60";
                }
                else
                {
                    MessageBox.Show("输入错误,五分制成绩只能为 优秀 良 中 及格 不及格");
                    score = "";
                }

                num_100.Text = score;

            }
            else if (num_100.Text == "" && num_5.Text == "")
            {
                MessageBox.Show("请输入百分制成绩或五分制成绩");
            }
            else if (num_100.Text != "" && num_5.Text != "")
            {
                MessageBox.Show("不可同时输入两个成绩");
                num_100.Text = "";
                num_5.Text = "";
            }
        }

        private void num_100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            // 如果输入字符不是数字且不是退格键
            {
                e.Handled = true; // 屏蔽非数字输入
            }
        }
    }
}
