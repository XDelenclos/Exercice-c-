using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompDefil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void color(int rouge, int vert, int bleu)
        {
            LaBResultat.BackColor = Color.FromArgb(rouge, vert, bleu);
        }
        private void HSSBRouge_Scroll(object sender, ScrollEventArgs e)
        {
            label4.BackColor = Color.FromArgb(HSSBRouge.Value, 0, 0);
            color(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }

        private void HSSBVert_Scroll(object sender, ScrollEventArgs e)
        {
            label5.BackColor = Color.FromArgb( 0, HSSBVert.Value , 0);
            color(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }

        private void HSSBBleu_Scroll(object sender, ScrollEventArgs e)
        {
            label6.BackColor = Color.FromArgb(0, 0, HSSBBleu.Value);
            color(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }

       
        // TBoxResultat.BackColor = Color.FromArgb(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);

    }
}
    

