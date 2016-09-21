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

namespace syntheses
{
    public partial class Form1 : Form
    {
        double Duree=1 ;
        int diviseur=1 ;
        double Interet;
        double NbMens;
        bool Flag = true;
        public Form1()
        {
            InitializeComponent();
        }
        public double CalcDuree()
        {
            TxtBoxDure.Text = Convert.ToString(HSBDureRemb.Value);
            Duree = HSBDureRemb.Value;
            double Periode = Duree / diviseur;
            LblNbreMois.Text = Convert.ToString(Periode);
            return Periode;
        }
        public void Remb()
        {
            double P = CalcDuree();
            double TxInt = (Interet / NbMens);
            double Remb = TxInt / (1-(Math.Pow((1+ TxInt), -P)));
            double capital = 0;
            try {
                capital = Convert.ToDouble(TxtBoxCapEmp.Text);
            }
            catch
            {
                capital = 0;
            }
            double Montant = Remb * capital; 
            LblMontant.Text = String.Format("{0:C}", Montant);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RadBout7.Select();
            TxtBoxCapEmp.Text = "0";
            ListBoxPeriode.SetSelected(0, true);
            TxtBoxNom.Select();

        }
        private void TxtBoxCapEmp_Validating(object sender, CancelEventArgs e)
        {
            string Patern = "^[0-9]+$";
            if (!Regex.IsMatch(TxtBoxCapEmp.Text, Patern) & TxtBoxCapEmp.Text != "")
            {
                MessageBox.Show("Saisie incorrect, Format numérique [0-9]", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtBoxCapEmp.Select();
            }
            if (TxtBoxCapEmp.Text == "")
            {
                MessageBox.Show("Saisie incorrect, Veuillez entrer une valeur", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtBoxCapEmp.Select();
            }
            else
            { Remb(); }

        }
        private void HSBDureRemb_Scroll(object sender, EventArgs e)
        {
            TxtBoxDure.Text = Convert.ToString(HSBDureRemb.Value);
            int Duree = HSBDureRemb.Value;
            int Periode = Duree / diviseur;
            LblNbreMois.Text = Convert.ToString(Periode);
            

        }

        private void ListBoxPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Choix = ListBoxPeriode.SelectedIndex;
            switch (Choix)
            {
                case 0:
                    HSBDureRemb.Minimum = 1;
                    HSBDureRemb.Maximum = 240;
                    HSBDureRemb.SmallChange = 1;
                    HSBDureRemb.LargeChange = 1;
                    diviseur = 1;
                    HSBDureRemb.Value = 1;
                    NbMens = 12;
                    break;
                case 1:
                    HSBDureRemb.Minimum = 2;
                    HSBDureRemb.Maximum = 241;
                    HSBDureRemb.SmallChange = 2;
                    HSBDureRemb.LargeChange = 2;
                    diviseur = 2;
                    HSBDureRemb.Value = 2;
                    NbMens = 6;
                    break;
                case 2:
                    HSBDureRemb.Minimum = 3;
                    HSBDureRemb.Maximum = 244;
                    HSBDureRemb.SmallChange = 3;
                    HSBDureRemb.LargeChange = 3;
                    diviseur = 3;
                    HSBDureRemb.Value = 3;
                    NbMens = 4;
                    break;
                case 3:
                    HSBDureRemb.Minimum = 6;
                    HSBDureRemb.Maximum = 245;
                    HSBDureRemb.SmallChange = 6;
                    HSBDureRemb.LargeChange = 6;
                    diviseur = 6;
                    HSBDureRemb.Value = 6;
                    NbMens = 2;
                    break;
                case 4:
                    HSBDureRemb.Minimum = 12;
                    HSBDureRemb.Maximum = 251;
                    HSBDureRemb.SmallChange = 12;
                    HSBDureRemb.LargeChange = 12;
                    diviseur = 12;
                    HSBDureRemb.Value = 12;
                    NbMens = 1;
                    break;
            }
            CalcDuree();
           
        }

        private void HSBDureRemb_ValueChanged(object sender, EventArgs e)
        {
            HSBDureRemb.Value = (HSBDureRemb.Value / HSBDureRemb.SmallChange) * HSBDureRemb.SmallChange;
            Remb();
        }

        private void RadBout7_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBout7.Checked == Flag)
            {
                Interet = 0.07;
                Remb();
            }
        }

        private void RadBout8_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBout8.Checked == Flag)
            {
                Interet = 0.08;
                Remb();
            }
        }

        private void RadBout9_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBout9.Checked == Flag)
            {
                Interet = 0.09;
                Remb();
            }
        }

        private void BoutAnnuler_Click(object sender, EventArgs e)
        {
            TxtBoxCapEmp.Text = "0";
            TxtBoxNom.Clear();
            TxtBoxDure.Clear();
            Remb();
        }

        private void BoutVal_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Voulez vous valider la saisie suivante : \n Monsieur/Madame  " + TxtBoxNom.Text + 
            " \r\n Capital Emprunté : " + TxtBoxCapEmp.Text+ " €" + 
            "\r\n Un taux d'intéret de : "+ Interet*100+"%"+
            " \r\n Durée de l'emprunt : " + TxtBoxDure.Text +" mois"+ 
            "\r\n Votre période de remboursement est "+ ListBoxPeriode.SelectedItem+
            "\r\n Nombre de mensualité : " + LblNbreMois.Text + 
            "\r\n Montant à rembourser par mois :" + LblMontant.Text, 
            "Validation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult ==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { }
        }
    }
}
