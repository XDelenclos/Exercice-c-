using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int somme = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+0";
                somme += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+1";
            somme += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+2";
            somme += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+3";
            somme += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+4";
            somme += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+5";
            somme += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+6";
            somme += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+7";
            somme += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+8";
            somme += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+9";
            somme += 9;
        }

        private void Calculer_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += "="+ somme;
        }

        private void Vider_Btn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            somme = 0;
            
        }
    }
}
