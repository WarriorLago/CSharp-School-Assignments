using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21计科2班_马菁含_069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Point orip = new Point(0, this.Height / 2);
            Point rightP = new Point(this.Width, this.Height / 2);
            g.DrawLine(p, orip, rightP);
            Point lastP = new Point(0, this.Height / 2);
            for (int i = 0; i < this.Width; i++)
            {
                Point nextp = new Point(i + 1, (int)getYFromX(orip, (double)(i + 1)));
                g.DrawLine(p, getComPoint(orip, lastP), getComPoint(orip, nextp));
                lastP = nextp;
            }
        }
        public Point getComPoint(Point oriPoint, Point mathPoint)
        {
            return new Point(oriPoint.X + mathPoint.X, oriPoint.Y - mathPoint.Y);
        }
        public double getYFromX(Point oriPoint, double X)
        {
            return oriPoint.Y * Math.Cos(6.28 * X / this.Width);
        }
    }

    }
