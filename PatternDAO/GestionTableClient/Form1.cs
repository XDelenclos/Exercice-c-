using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Text.RegularExpressions;

namespace GestionTableClient
{
    public partial class Form1 : Form
    {
        bool FlagNew = false;
        bool FlagUpd = false;
        bool FlagDele = false;
        bool FlagErreur = false;
        int id;
        string pattern = @"^[a-zA-ZÀ-ÿ\s\’-]{1,80}$";

        public void test(string text,TextBox textbox )
        {
            if (!Regex.IsMatch(text, pattern))
            {
                errorProvider1.SetError(textbox, "Format de saisie incorrect");
                textbox.Focus();
                FlagErreur = true;
            }
            else
            {
                errorProvider1.SetError(textbox,"");
                FlagErreur = false;
            }
        }
        public void EffaceText()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 400;
            ClientDAO repo = new ClientDAO();
            DtViewList.DataSource = repo.List();
            DtViewList.Columns[2].Visible = false;
            DtViewList.Columns[3].Visible = false;
            DtViewList.Columns[4].Visible = false;
            DtViewList.Columns[5].Visible = false;
            DtViewList.Columns[6].Visible = false;
            DtViewList.Columns[7].Visible = false;
            DtViewList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtViewList.RowHeadersVisible = false;
            DtViewList.MultiSelect = false;
            DtViewList.Rows[0].Selected = true;
            GrpBoxDetails.Enabled = false;
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            GrpBoxDetails.Enabled = true;
            EffaceText();
            FlagNew = true;
            FlagUpd = false;
            FlagDele = false;
            Width = 730;
            textBox1.Focus();
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            GrpBoxDetails.Enabled = true;
            FlagNew = false;
            FlagUpd = true;
            FlagDele = false;
            Width = 730;

            if (DtViewList.SelectedRows.Count > 0)
            {
                textBox1.Text = DtViewList.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = DtViewList.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = DtViewList.SelectedRows[0].Cells[2].Value.ToString();
                id = Convert.ToInt32((DtViewList.SelectedRows[0].Cells[3].Value.ToString()));
            }
        }
        private void BtnSupp_Click(object sender, EventArgs e)
        {
            GrpBoxDetails.Enabled = true;
            FlagNew = false;
            FlagUpd = false;
            FlagDele = true;
            Width = 730;
            if (DtViewList.SelectedRows.Count > 0)
            {
                textBox1.Text = DtViewList.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = DtViewList.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = DtViewList.SelectedRows[0].Cells[2].Value.ToString();
                id = Convert.ToInt32((DtViewList.SelectedRows[0].Cells[3].Value.ToString()));
            }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            Width = 400;
            if (FlagNew == true )
            {
                if (FlagErreur == false)
                {
                    Client c = new Client();
                    c.Nom = textBox1.Text;
                    c.Prenom = textBox2.Text;
                    c.Ville = textBox3.Text;
                    c.Tel = "";
                    c.Mail = "";
                    c.adresse = "";
                    c.CP = "";

                    ClientDAO database = new ClientDAO();
                    try
                    {
                        database.insert(c);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClientDAO repo = new ClientDAO();
                    DtViewList.DataSource = repo.List();

                    EffaceText();
                    GrpBoxDetails.Enabled = false;
                }
                else
                    MessageBox.Show("Vous ne pouvez pas ajouter un client sans renseigner les informations demandées", "Erreur lors de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (FlagUpd == true)
            {
                if (FlagErreur == false)
                {
                    Client d = new Client();
                    d.ID = id;
                    d.Nom = textBox1.Text;
                    d.Prenom = textBox2.Text;
                    d.Ville = textBox3.Text;
                    d.Tel = "";
                    d.Mail = "";
                    d.adresse = "";
                    d.CP = "";

                    ClientDAO database = new ClientDAO();
                    try
                    {
                        database.Update(d);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClientDAO repo = new ClientDAO();
                    DtViewList.DataSource = repo.List();
                    EffaceText();
                    GrpBoxDetails.Enabled = false;
                }
            }
            if (FlagDele == true)
            {
                if (FlagErreur == false)
                {
                    ClientDAO database = new ClientDAO();
                    Client d = new Client();
                    d.ID = id;
                    try
                    {
                        database.Delete(d);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ClientDAO repo = new ClientDAO();
                    DtViewList.DataSource = repo.List();

                    EffaceText();
                    GrpBoxDetails.Enabled = false;
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Width = 400;
            EffaceText();
            GrpBoxDetails.Enabled = false;
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            test(textBox1.Text, textBox1);
         }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            test(textBox2.Text, textBox2);
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            test(textBox3.Text, textBox3);
        }
        private void DtViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = DtViewList.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = DtViewList.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = DtViewList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show("Souhaitez vous vraiment quitter ?", "validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            { }
            else
                e.Cancel = true;
        }
    }
}
