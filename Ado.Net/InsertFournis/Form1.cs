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

namespace InsertFournis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Connection()
        {
            string Connexion = "server=. ;database = PAPYRUS ;Integrated Security = true";
            return Connexion;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection());
            connect.Open();
            int id = 0;
            try
            {
                SqlCommand SelectID = new SqlCommand("select max(NUMFOU) from xavier.FOURNIS", connect);
                id = (int)SelectID.ExecuteScalar()+1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                SqlCommand requete = new SqlCommand("insert into xavier.FOURNIS (NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF, NUMFOU) values(@nom, @rue, @CP, @ville, @contact, @Satisf, @ID) ", connect);
                requete.Parameters.AddWithValue("@nom", TxtBoxNom.Text);
                requete.Parameters.AddWithValue("@rue", TxtBoxAdresse.Text);
                requete.Parameters.AddWithValue("@CP", TxtBoxCP.Text);
                requete.Parameters.AddWithValue("@ville", TxtBoxVille.Text);
                requete.Parameters.AddWithValue("@contact", TxtBoxContact.Text);
                requete.Parameters.AddWithValue("@Satisf", TrackBSatis.Value);
                requete.Parameters.AddWithValue("@ID", id );
                requete.ExecuteNonQuery();                MessageBox.Show("Ajout de fournisseur validé", "Validation Fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            finally
            {
                
                connect.Close();
            }
        }

        private void TxtBoxNom_Validating(object sender, CancelEventArgs e)
        {
            string patern = @"^[A-Za-z]+(([- ][A-Za-z])?[A-Za-z]){1,200}$";
            if (Regex.IsMatch(TxtBoxNom.Text, patern))
            {

            }
            else
            {
                MessageBox.Show("Erreur Format du Nom Incorrect [A-Z]");
            }
        }

        private void TxtBoxAdresse_Validating(object sender, CancelEventArgs e)
        {
            string PaternAdr = @"^(\w|\s){5,200}$"; 
            if (Regex.IsMatch(TxtBoxNom.Text, PaternAdr))
            {

            }
            else
            {
                MessageBox.Show("Erreur Format de l'adresse");
                TxtBoxAdresse.Select();
            }
        }

        private void TxtBoxCP_Validating(object sender, CancelEventArgs e)
        {
            string PaternCP = "^[0-9]{5}";
            if (Regex.IsMatch(TxtBoxCP.Text, PaternCP))
            {

            }
            else
            {
                MessageBox.Show("Erreur Format du Code Postale [0-9]");
            }
        }

        private void TxtBoxVille_Validating(object sender, CancelEventArgs e)
        {
            string PaternVil = @"^[A-Za-z]+(([- ][A-Za-z])?[A-Za-z]){1,75}$";
            if (Regex.IsMatch(TxtBoxNom.Text, PaternVil))
            {

            }
            else
            {
                MessageBox.Show("Erreur Format de la Ville Incorrect [A-Z]");
            }
        }

        private void TxtBoxContact_Validating(object sender, CancelEventArgs e)
        {
            string patern = @"^[A-Za-z]+(([- ][A-Za-z])?[A-Za-z]){1,75}$";
            if (Regex.IsMatch(TxtBoxNom.Text, patern))
            {

            }
            else
            {
                MessageBox.Show("Erreur du nom du contact");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
