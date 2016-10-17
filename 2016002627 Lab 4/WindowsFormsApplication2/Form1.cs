using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016002627_Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taskLIstToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help N/A");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void forLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4TxT.Clear();
            for (int num = 1; num <= 7; num++)
            {
                Lab4TxT.Text += num + "\r\n";
            }
        }

        private void doWhileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4TxT.Clear();
            int dwLoop = 0;

            do
            {
                dwLoop++;
                Lab4TxT.Text += dwLoop + "\r\n";
            }
            while (dwLoop <= 6);
        }

        private void nestedForLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4TxT.Clear();
            for (int nest = 1; nest <= 7; nest++)
            {
                for (int nest2 = 1; nest2 <= nest; nest2++)
                {
                    Lab4TxT.Text += nest2;
                }
                Lab4TxT.Text += "\r\n";

            }
        }

        private void forEachLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4TxT.Clear();
            int[] feLoop = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int element in feLoop)
            {
                Lab4TxT.Text += element;
                Lab4TxT.Text += "\r\n";
            }
        }

        private void whileLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lab4TxT.Clear();
            int wLoop = 0;
            while (wLoop <= 6)
            {
                wLoop++;
                Lab4TxT.Text += wLoop + "\r\n";
            }
        }

       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
