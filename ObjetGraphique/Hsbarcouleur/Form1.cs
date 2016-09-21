using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hsbarcouleur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ColorRes(int rouge, int vert, int bleu)
        {
            LaBResultat.BackColor = Color.FromArgb(rouge, vert, bleu);
        }
        public void ColorR(int rouge, int vert, int bleu)
        {
            label4.BackColor = Color.FromArgb(rouge, vert, bleu);
        }
        public void ColorV(int rouge, int vert, int bleu)
        {
            label5.BackColor = Color.FromArgb(rouge, vert, bleu);
        }
        public void ColorB(int rouge, int vert, int bleu)
        {
            label6.BackColor = Color.FromArgb(rouge, vert, bleu);
        }

        private void HSSBRouge_Scroll(object sender, ScrollEventArgs e)
        {
            ColorR(HSSBRouge.Value, 0, 0);
            NumUpDownRouge.Value = HSSBRouge.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }

        private void HSSBVert_Scroll(object sender, ScrollEventArgs e)
        {
            ColorV(0, HSSBVert.Value, 0);
            NumUpDownVert.Value = HSSBVert.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }

        private void HSSBBleu_Scroll(object sender, ScrollEventArgs e)
        {
            ColorB(0, 0, HSSBBleu.Value);
            NumUpDownBleu.Value = HSSBBleu.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
        }
        private void HSSBRouge_Scroll(object sender, EventArgs e)
        {
            HSSBRouge.Value = (int)NumUpDownRouge.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
            ColorR(HSSBRouge.Value, 0, 0);
        }

        private void HSSBVert_Scroll(object sender, EventArgs e)
        {
            HSSBVert.Value = (int)NumUpDownVert.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
            ColorV(0, HSSBVert.Value, 0);
        }

        private void HSSBBleu_Scroll(object sender, EventArgs e)
        {
            HSSBBleu.Value = (int)NumUpDownBleu.Value;
            ColorRes(HSSBRouge.Value, HSSBVert.Value, HSSBBleu.Value);
            ColorB(0, 0, HSSBBleu.Value);
        }
    }
}

