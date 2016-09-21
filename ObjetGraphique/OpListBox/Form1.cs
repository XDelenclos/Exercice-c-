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

namespace OpListBox
{
    public partial class Form1 : Form
    {
        
      
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            bool Flag = true;
            for (int i = 0; i < LstListe.Items.Count; i++)
            {
                if ((string)LstListe.Items[i] == TBoxNewElem.Text)
                {
                    Flag = false;
                }
            }
            if (Flag)
            {
                string Pattern = "^[A-Za-z]+$";
                if (Regex.IsMatch(TBoxNewElem.Text, Pattern))
                {
                    LstListe.Items.Add(TBoxNewElem.Text);
                }
                else
                    MessageBox.Show("Nom Invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Nom déjà présent dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



            TBoxNewElem.Clear();
            TBoxNewElem.Focus();
            TBoxItems.Text = Convert.ToString(LstListe.Items.Count);
        }

        private void TBoxIndex_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = BtnSelec;
        }

        private void BtnSelec_Click(object sender, EventArgs e)
        {
            string PatIndex = "^[0-9]+$";
            if (Regex.IsMatch(TBoxIndex.Text, PatIndex))
                try
                {
                    if (Convert.ToInt32(TBoxIndex.Text) < LstListe.Items.Count+1)
                    {
                        LstListe.SelectedIndex = Convert.ToInt32(TBoxIndex.Text);
                        TBoxSelInd.Text = Convert.ToString(LstListe.SelectedIndex);
                        TBoxText.Text = Convert.ToString(LstListe.SelectedItem);
                        TBoxIndex.Clear();
                        TBoxIndex.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("L'index " + TBoxIndex.Text + " est hors liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    TBoxIndex.Clear();
                    TBoxIndex.Focus();
                }
            else
            {
                MessageBox.Show("Veuillez saisir un chiffre [0-9]", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TBoxIndex.Clear();
                TBoxIndex.Focus();
            }
        }

        private void TBoxNewElem_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = BtnAjout;
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            LstListe.Items.Clear();
            TBoxSelInd.Clear();
            TBoxItems.Clear();
            TBoxText.Clear();
            TBoxIndex.Clear();
        }
    }
}

