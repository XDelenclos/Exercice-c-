using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recherchelignetable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection connect = new SqlConnection("server=. ;database = PAPYRUS ;Integrated Security = true");
            //connect.Open();
            BtnCherche.Enabled = false;
        }



        private void BtnCherche_Click(object sender, EventArgs e)
        {
            SqlConnection connect = null;
            SqlCommand select = null;
            SqlDataReader resultat = null;
            try
            {
                connect = new SqlConnection("server=. ;database = PAPYRUS ;Integrated Security = true");
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                select = new SqlCommand("Select NOMFOU, RUEFOU, POSFOU, VILFOU, CONFOU from xavier.FOURNIS where NUMFOU= " + TxtBoxCodeFou.Text, connect);
                resultat = select.ExecuteReader();
                if (resultat.Read())
                {
                    TxtBoxNom.Text = resultat["NOMFOU"].ToString();
                    TxtBoxAdresse.Text = resultat["RUEFOU"].ToString();
                    TxtBoxCP.Text = resultat["POSFOU"].ToString();
                    TxtBoxVille.Text = resultat["VILFOU"].ToString();
                    TxtBoxContact.Text = resultat["CONFOU"].ToString();
                }
                else
                {
                    MessageBox.Show("Code fournisseur invalide ou inexistent", "Erreur Code Fournisseur", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex1)
            { MessageBox.Show(ex1.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            connect.Close();
        }

        private void TxtBoxCodeFou_TextChanged_1(object sender, EventArgs e)
        {
            string patern = "^[0-9]{1,4}$";
            if (Regex.IsMatch(TxtBoxCodeFou.Text, @patern))
            {
                BtnCherche.Enabled = true;
            }
            else
            {
                BtnCherche.Enabled = false;
            }
        }
    }
}

