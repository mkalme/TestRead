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
using System.Threading;

namespace TestRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void countLetters() {
            String text = File.ReadAllText(textBox1.Text);
            if (checkBox1.Checked) {
                text = text.Trim().Replace("\n", "");
            }

            textBox2.Text = text.Length.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countLetters();
        }
    }
}
