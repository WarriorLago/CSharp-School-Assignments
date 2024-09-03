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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRmb.Text = "";
            txtHuilv.Text = "";
            txtDollar.Text = "";
        }

        private void btnR2D_Click(object sender, EventArgs e)
        {
            if (txtRmb.Text == ""|| txtHuilv.Text=="")
            {
                MessageBox.Show("输入不能为空");
                return;
            }
            double rmb = double.Parse(txtRmb.Text);
            double huilv = double.Parse(txtHuilv.Text);
            double dollar = rmb / huilv;
            txtDollar.Text = dollar.ToString("0.00");
        }

        private void btnD2R_Click(object sender, EventArgs e)
        {
            if (txtDollar.Text == ""|| txtHuilv.Text == "")
            {
                MessageBox.Show("输入不能为空");
                return;
            }
            double dollar = double.Parse(txtDollar.Text);
            double huilv = double.Parse(txtHuilv.Text);
            double rmb = dollar * huilv;
            txtRmb.Text = rmb.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
