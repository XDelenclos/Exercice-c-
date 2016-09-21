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

namespace ConnexionBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void connexion()
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtErreur.Visible = false;
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=" + TxtBoxServeur.Text + ";database = " + TxtBoxBdD.Text + ";Integrated Security = true");
                connect.Open();
                LblEtat.Text = connect.State.ToString();

            }
            catch(Exception ex)
            {
                
                TxtErreur.Text = ex.Message;
                TxtErreur.Visible = true;
               
            }
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server=" + TxtBoxServeur.Text + ";database = " + TxtBoxBdD.Text + ";Integrated Security = true");
            connect.Close();
            LblEtat.Text = connect.State.ToString();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblEtat_Click(object sender, EventArgs e)
        {

        }
    }
}
