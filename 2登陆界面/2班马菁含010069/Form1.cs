using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2班马菁含010069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsAllLetters(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsAllDigits(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (username == "abcde" && password == "12345")
            {
                lbInfo.Text = "登陆成功";
                lbInfo.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbInfo.Text = "用户名或密码有误，请重新输入";
                lbInfo.ForeColor = System.Drawing.Color.Red;
            }

            if (!IsAllLetters(username))
            {
                lbInfo.Text = "用户名只能为大小写字母";
                lbInfo.ForeColor = System.Drawing.Color.Red;
            }
            else if (!IsAllDigits(password))
            {
                lbInfo.Text = "密码只能为数字";
                lbInfo.ForeColor = System.Drawing.Color.Red;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}

