using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21计科2班_马菁含069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            before_jinzhi.SelectedIndex = 3; // 默认16进制
            after_jinzhi.SelectedIndex = 3; // 默认16进制
        }

        private void btn_transform_Click(object sender, EventArgs e)
        {
            // 检查输入是否为空
            if (string.IsNullOrEmpty(num.Text))
            {
                MessageBox.Show("请填入数字");
                num.Focus();//聚焦
                return;
            }

            // 获取原进制和目标进制
            int sourceBase = int.Parse(before_jinzhi.Text);
            int targetBase = int.Parse(after_jinzhi.Text);

            // 将输入数字先转换成十进制
            string inputNumber = num.Text.Trim().ToUpper();
            int decNumber = 0;
            foreach (char c in inputNumber)
            {
                int digit = char.IsDigit(c) ? (c - '0') : (c - 'A' + 10);
                if (digit >= sourceBase)
                {
                    MessageBox.Show("数字和进制设置不吻合");
                    num.Focus();
                    return;
                }
                decNumber = decNumber * sourceBase + digit;
            }

            // 将十进制数转换为目标进制
            string outputNumber = "";
            while (decNumber > 0)
            {
                int remainder = decNumber % targetBase;
                char digitChar = remainder < 10 ? (char)(remainder + '0') : (char)(remainder - 10 + 'A');
                outputNumber = digitChar + outputNumber;
                decNumber /= targetBase;
            }

            // 显示转换结果
            result.Text = outputNumber;

        }
    }
}
