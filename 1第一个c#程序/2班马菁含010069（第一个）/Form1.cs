using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2班马菁含010069_第一个_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "我真棒"; 
            label1.Text = "我的第一个Visual C#程序"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
