using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace validation_de_saisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            string Correspondance = "^[A-Za-z ]+$";
            if (Regex.IsMatch(TxtNom.Text, @Correspondance))
            {
                TxtNom.BackColor = Color.LightGreen;
            }
            else
            {
                TxtNom.BackColor = Color.White;
                MessageBox.Show("Saisie incorrecte", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNom.Clear();
            }
        }

        private void TxtDate_TextChanged(object sender, EventArgs e)
        {
            String Date = "^\\d{2}\\/\\d{2}\\/\\d{4}$";
            if (Regex.IsMatch(TxtDate.Text, @Date))
            {
                TxtDate.BackColor = Color.LightGreen;
            }
            else
            {
                TxtDate.BackColor = Color.LightCoral;                
            }
            if (TxtDate.Text=="")
            {
                TxtDate.BackColor = Color.White;
            }
        }

        /*private void TxtMontant_TextChanged(object sender, EventArgs e)
        {
            
        }*/

        private void TxtMontant_Validated(object sender, EventArgs e)
        {
            
        }

        private void TxtMontant_TextChanged_1(object sender, EventArgs e)
        {
            string MontantMoney = "(\\d+)(,|\\.)(\\d+)";
            if (Regex.IsMatch(TxtMontant.Text, MontantMoney))
            {
                TxtMontant.BackColor = Color.LightGreen;
            }
            else
            { TxtMontant.BackColor = Color.LightCoral; }
            if (TxtMontant.Text == "")
            { TxtMontant.BackColor = Color.White; }
        }

        private void TxtCP_TextChanged(object sender, EventArgs e)
        {
            string CodePostal = "^\\d{5}$";
            if (Regex.IsMatch(TxtCP.Text,CodePostal))
            {
                TxtCP.BackColor = Color.LightGreen;
            }
            else
            { TxtCP.BackColor = Color.LightCoral; }
            if (TxtCP.Text == "")
            { TxtCP.BackColor = Color.White; }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCP.Text ="";
            TxtMontant.Text ="";
            TxtDate.Text = "";
            TxtNom.Text = "";

        }

        private void BtnValider_Validated(object sender, EventArgs e)
        {
            if ((TxtCP.BackColor == Color.LightGreen) & (TxtMontant.BackColor == Color.LightGreen) & (TxtDate.BackColor == Color.LightGreen) & (TxtNom.BackColor == Color.LightGreen))
            {
                BtnValider.Visible = true;
            }
            else
            { BtnValider.Visible = false; }
        }

        private void BtnValider_Validating(object sender, CancelEventArgs e)
        {

        }

        private void BtnValider_Enter(object sender, EventArgs e)
        {
            if ((TxtCP.BackColor == Color.LightGreen) & (TxtMontant.BackColor == Color.LightGreen) & (TxtDate.BackColor == Color.LightGreen) & (TxtNom.BackColor == Color.LightGreen))
            {
                BtnValider.Visible = true;
            }
            else
            { BtnValider.Visible = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnValider.Visible = false;
        }

        private void TxtMontant_Validating(object sender, CancelEventArgs e)
        {
            
            string Signe = ",";
            string MontantMoney = "(\\d+)(.)(\\d+)";
            TxtMontant.Text = Regex.Replace(TxtMontant.Text, MontantMoney, "$1" + Signe + "$3");
            if ( TxtMontant.Text != Convert.ToDouble(TxtMontant.Text).ToString("C"))
                {
                string Money = Convert.ToDouble(TxtMontant.Text).ToString("C");
                TxtMontant.Text = Money; }
            else
            { }
        }
    }
}


