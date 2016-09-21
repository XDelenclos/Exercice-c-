using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ObjGraph
{
    public partial class Form1 : Form
    {
        public void Visible(int i)
        {
            switch (i)
            {
                case 1:
                    GBoxFond.Visible = false;
                    CBoxFond.Checked = false;
                    break;
                case 2:
                    GBoxCarac.Visible = false;
                    CBoxCarac.Checked = false;
                    break;
                case 3:
                    GBoxCasse.Visible = false;
                    CBoxCasse.Checked = false;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GroupBoxChoix.Enabled = false;
            GBoxCarac.Visible = false;
            GBoxCasse.Visible = false;
            GBoxFond.Visible = false;
        }

        private void TxtBoxText_TextChanged(object sender, EventArgs e)
        {
            Resultat.Text = TxtBoxText.Text;
            if (TxtBoxText.Text == "")
                GroupBoxChoix.Enabled = false;
            else
                GroupBoxChoix.Enabled = true;
        }

        private void CBoxFond_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxFond.Checked == true)
                GBoxFond.Visible = true;
            else
                GBoxFond.Visible = false;
        }

        private void CBoxCarac_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxCarac.Checked == true)
                GBoxCarac.Visible = true;
            else
                GBoxCarac.Visible = false;
        }

        private void CBoxCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (CBoxCasse.Checked == true)
                GBoxCasse.Visible = true;
            else
                GBoxCasse.Visible = false;

        }

        private void RBtnFRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnFRouge.Checked == true)
            {
                Resultat.BackColor = Color.Red;
                Visible(1);
            }
        }

        private void RBtnFVert_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnFVert.Checked == true)
            {
                Resultat.BackColor = Color.LightGreen;
                Visible(1);
            }
        }

        private void RBtnFBleu_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnFBleu.Checked == true)
            {
                Resultat.BackColor = Color.Aqua;
                Visible(1);
            }
        }

        private void RBtnCRouge_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnCRouge.Checked == true)
            {
                Resultat.ForeColor = Color.Red;
                Visible(2);
            }
        }

        private void RBtnCBlanc_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnCBlanc.Checked == true)
            {
                Resultat.ForeColor = Color.White;
                Visible(2);
            }
        }

        private void RBtnCNoir_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnCNoir.Checked == true)
            {
                Resultat.ForeColor = Color.Black;
                Visible(2);
            }
        }

        private void RBtnMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnMinus.Checked == true)
            {
                Resultat.Text = Resultat.Text.ToLower();
                Visible(3);
            }
        }

        private void RbtnMaj_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnMaj.Checked == true)
            {
                Resultat.Text = Resultat.Text.ToUpper();
                Visible(3);

            }
        }
    }
}
