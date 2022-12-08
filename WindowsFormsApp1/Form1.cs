using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.Icon = Properties.Resources.calculator;
        }
        void equals()
        {
            DataTable result = new DataTable();
            textBox1.Text = result.Compute(textBox1.Text, "").ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var currentButton = (Button)sender;
            textBox1.Text += currentButton.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equals();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsSymbol(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equals();
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
