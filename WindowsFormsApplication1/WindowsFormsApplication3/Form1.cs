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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        bool ErNom, ErMontant, ErDate, ErCP = true;
        public Form1()
        {
            InitializeComponent();


            /**/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnValider.Visible = false;
        }

        private void TxtNom_Validating(object sender, CancelEventArgs e)
        {
            nameErrorProvider = errorProvider1;

            string Correspondance = "^[A-Za-z ]+$";
            if (!Regex.IsMatch(TxtNom.Text, @Correspondance))
            {
                nameErrorProvider.SetError(TxtNom, "format incorrect");
                ErNom = true;

            }
            else
            {
                nameErrorProvider.SetError(TxtNom, string.Empty);
                ErNom = false;
                TxtNom.Enabled = false;
            }
            if (TxtNom.Text == "")
            {
                nameErrorProvider.SetError(TxtNom, "Champs vide");
                ErNom = true;
                TxtNom.Enabled = true;
            }
        }

        private void BtnClear_Validating(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show
                ("Souhaitez vous tout effacer ?", "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                TxtNom.Text = "";
                TxtDate.Text = "";
                TxtMontant.Text = "";
                TxtCP.Text = "";
                TxtNom.Enabled = true;
                TxtDate.Enabled = true;
                TxtMontant.Enabled = true;
                TxtCP.Enabled = true;
                BtnValider.Visible = false;
                TxtNom.Focus();
            };
        }

        private void BtnValider_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Validation des saisies acceptées" + TxtNom.Text  + TxtDate.Text+ TxtMontant.Text + TxtCP.Text,"Test MessageBox",
MessageBoxButtons.OK,
MessageBoxIcon.Asterisk);
        }

        private void TxtDate_Validating(object sender, CancelEventArgs e)
        {
            String Date = "^\\d{2}\\/\\d{2}\\/\\d{4}$";
            if (Regex.IsMatch(TxtDate.Text, @Date))
            {
                nameErrorProvider.SetError(TxtDate, string.Empty);
                ErDate = false;
                TxtDate.Enabled = false;
            }
            else
            {
                nameErrorProvider.SetError(TxtDate, "format incorrect");
                ErDate = true;
            }
            if (TxtDate.Text == "")
            {
                nameErrorProvider.SetError(TxtDate, "Champs vide");
                ErDate = true;
            }
        }

        private void TxtMontant_Validating(object sender, CancelEventArgs e)
        {
            string MontantMoney = "@(\\d+)(,|\\.)(\\d+)";
            string trigger = ",";

            if (Regex.IsMatch(TxtMontant.Text, MontantMoney))
            {
               // Regex.Replace(TxtMontant.Text, MontantMoney, "$1"+trigger+"$3");
              //  TxtMontant.Text = (Convert.ToDecimal(TxtMontant.Text)).ToString("C");

                nameErrorProvider.SetError(TxtMontant, string.Empty);
                ErMontant = false;
                TxtMontant.Enabled = false;
            }
            else
            {
                nameErrorProvider.SetError(TxtMontant, "format incorrect");
                ErMontant = true;
            }
            if (TxtMontant.Text == "")
            {
                nameErrorProvider.SetError(TxtMontant, "Champs non renseigné");
                ErMontant = true;
            }
        }

        private void TxtCP_TextChanged(object sender, EventArgs e)
        {
            string CodePostal = "^\\d{5}$";
            if (Regex.IsMatch(TxtCP.Text, CodePostal))
            {
                nameErrorProvider.SetError(TxtCP, string.Empty);
                ErCP = false;
                TxtCP.Enabled = false;

                if (ErCP | ErDate | ErMontant | ErNom)
                {
                    BtnValider.Visible = false;
                }
                else
                { BtnValider.Visible = true; }
            }
            else
            {
                nameErrorProvider.SetError(TxtCP, "format incorrect");
                ErCP = true;
            }
            if (TxtCP.Text == "")
            {
                nameErrorProvider.SetError(TxtCP, "Champs non renseigné");
                ErCP = true;
            }

        }
    }
}
