using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace _21计科2班_马菁含010069
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        private string textToPrint = "";
        private Font printFont;
        public Form1()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }
        private void cutbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.SelectedText))
            {
                Clipboard.SetText(textbox.SelectedText);
                textbox.SelectedText = "";
            }
        }

        private void copybtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textbox.SelectedText))
            {
                Clipboard.SetText(textbox.SelectedText);
            }
        }

        private void pastebtn_Click(object sender, EventArgs e)
        {
            textbox.SelectedText = Clipboard.GetText();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
    }

        private void format_Click(object sender, EventArgs e)
        {
            int start = textbox.SelectionStart;
            int length = textbox.SelectionLength;

            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textbox.SelectionFont = fontDialog.Font;
            }


            textbox.SelectionStart = start;
            textbox.SelectionLength = length;
        }

        private void 插入图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
              
                    Image image = Image.FromFile(openFileDialog.FileName);
                    Clipboard.SetImage(image);
                    textbox.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting image: " + ex.Message);
                }
            }

        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
             
                    File.WriteAllText(fileName, textbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法保存文件: " + ex.Message);
                }
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
             
                    textbox.Text = File.ReadAllText(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法打开文件: " + ex.Message);
                }
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void 预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textbox.Text, textbox.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top, new StringFormat());
        }

    }
}
