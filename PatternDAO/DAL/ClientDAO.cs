using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class ClientDAO
    {

        public void insert(Client cli)
        {
            try {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                SqlCommand CmdInsert = new SqlCommand("insert into commercial.Clients (Nom_Particulier, Prenom_Particulier, Ville_Livraison, Adresse_Livraison, Code_Postal_Livraison, No_Telephone_Client,Mail_Client ) values (@nom, @prenom, @ville, @adresse, @CP, @Tel, @Mail)", connect);
                CmdInsert.Parameters.AddWithValue("@nom", cli.Nom);
                CmdInsert.Parameters.AddWithValue("@prenom", cli.Prenom);
                CmdInsert.Parameters.AddWithValue("@ville", cli.Ville);
                CmdInsert.Parameters.AddWithValue("@adresse", cli.adresse);
                CmdInsert.Parameters.AddWithValue("@CP", cli.CP);
                CmdInsert.Parameters.AddWithValue("@Tel", cli.Tel);
                CmdInsert.Parameters.AddWithValue("@Mail", cli.Mail);
                CmdInsert.ExecuteNonQuery();

                SqlCommand RequeteId = new SqlCommand("select max(ID_Client) from  commercial.Clients", connect);
                int ID = (int)RequeteId.ExecuteScalar();
                cli.ID = ID + 1;
                connect.Close();
            }
            catch
            {
                throw new Exception("Problème lors de l'ajout de la fiche client !");
            }
        }
        public void Update(Client cli)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                SqlCommand CmdUpdate = new SqlCommand("update commercial.Clients set Nom_Particulier = UPPER (@nom) , Prenom_Particulier = UPPER (@prenom), Ville_Livraison = UPPER (@ville) where ID_Client = @ID", connect);
                CmdUpdate.Parameters.AddWithValue("@ID", cli.ID);
                CmdUpdate.Parameters.AddWithValue("@nom", cli.Nom);
                CmdUpdate.Parameters.AddWithValue("@prenom", cli.Prenom);
                CmdUpdate.Parameters.AddWithValue("@ville", cli.Ville);
                CmdUpdate.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                throw new Exception("Problème lors de la modification de la fiche client !");
            }
        }
        public void Delete(Client cli)
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                SqlCommand CmdDelete = new SqlCommand("DELETE FROM commercial.Clients where ID_Client = @ID", connect);
                CmdDelete.Parameters.AddWithValue("@ID", cli.ID);
                CmdDelete.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                throw new Exception("Problème lors de la suppression de la fiche client !");
            }
        }
        public Client Find(int id)
        {
            SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
            connect.Open();
            SqlCommand CmdFind = new SqlCommand("Select * from commercial.Clients where ID_Client = @ID", connect);
            CmdFind.Parameters.AddWithValue("@ID", id);
            SqlDataReader lecture = CmdFind.ExecuteReader();
            Client c = new Client();

// if car 1 seule ligne, si +ieurs ligne alors while
            if (lecture.Read())                 
            {
                c.ID = Convert.ToInt32(lecture["ID_Client"]);
                c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                c.Ville = Convert.ToString(lecture["Ville_Livraison"]);
            }
            connect.Close();
            return c;
            
        }
        public List<Client> List()
        {
            try
            {
                SqlConnection connect = new SqlConnection("server=.; database = FIL_ROUGE; Integrated Security = true");
                connect.Open();
                List<Client> resultat = new List<Client>();
                SqlCommand requete = new SqlCommand("select * from  commercial.Clients", connect);
                SqlDataReader lecture = requete.ExecuteReader();
                while (lecture.Read())
                {
                    Client c = new Client();
                    c.ID = Convert.ToInt32(lecture["ID_Client"]);
                    c.Nom = Convert.ToString(lecture["Nom_Particulier"]);
                    c.Prenom = Convert.ToString(lecture["Prenom_Particulier"]);
                    c.Ville = Convert.ToString(lecture["Ville_Livraison"]);
                    resultat.Add(c);
                }
                lecture.Close();
                connect.Close();
                return resultat;
            }
            catch
            {
                throw new Exception("Problème lors du chargement de la liste client !");
            }
        }
    }
}
