using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RechercheJeuLigne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Selectall()
        {
            string selection = "Select NUMCOM, OBSCOM, DATCOM from xavier.ENTCOM ";
            return selection;
        }
        public string Selec()
        {
            string selection = Selectall()+" join xavier.FOURNIS on ENTCOM.NUMFOU = FOURNIS.NUMFOU where NOMFOU = '";
            return selection;
        }
        public string Connection()
        {
            string Connexion= "server=. ;database = PAPYRUS ;Integrated Security = true";
            return Connexion;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connect = null;
            SqlDataReader resultat = null;

            try
            {
                connect = new SqlConnection(Connection());
                connect.Open();
                SqlCommand select = new SqlCommand("Select NOMFOU from xavier.FOURNIS", connect);
                resultat = select.ExecuteReader();
                    try
                    {
                        List<string> Nomfournisseur = new List<string>();
                        CoBoxChoix.Items.Insert(0,"Tous");
                        while (resultat.Read())
                        {
                            CoBoxChoix.Items.Add(resultat["NOMFOU"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            catch
            { }
            connect.Close();
        }

        private void CoBoxChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlDataReader resultat = null;
            SqlConnection connect = new SqlConnection(Connection());
            connect.Open();
            if (CoBoxChoix.SelectedIndex == 0)
                try
                {
                    SqlCommand select2 = new SqlCommand(Selectall(), connect);
                    resultat = select2.ExecuteReader();
                    while (resultat.Read())
                    {
                        listBox1.Items.Add(resultat["NUMCOM"].ToString());
                        listBox1.Items.Add(resultat["OBSCOM"].ToString());
                        listBox1.Items.Add(resultat["DATCOM"].ToString());
                    }
                }
                catch { }
            else
            {
                try
                {
                    SqlCommand select2 = new SqlCommand(Selec() + CoBoxChoix.Text + "' ", connect);
                    resultat = select2.ExecuteReader();
                    while (resultat.Read())
                    {
                        listBox1.Items.Add(resultat["NUMCOM"].ToString());
                        listBox1.Items.Add(resultat["OBSCOM"].ToString());
                        listBox1.Items.Add(resultat["DATCOM"].ToString());
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
