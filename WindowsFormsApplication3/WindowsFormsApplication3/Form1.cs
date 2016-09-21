using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("TextChanged");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            Console.WriteLine("Validating");
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            Console.WriteLine("Validated");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Enter");
        }
    }
}
