using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ListCombo
{

    public partial class Form1 : Form
    {

        public List<string> Pays()
        {
            List<string> ListePays = new List<string>();
            foreach (CultureInfo infos in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo region = new RegionInfo(infos.LCID);
                if (!ListePays.Contains(region.DisplayName))
                {
                    ListePays.Add(region.DisplayName);
                    ListePays.Sort();
                }
            }
            return ListePays;
        }

        void MoveUp(ListBox myListBox)
        {
            int selectedIndex = myListBox.SelectedIndex;
            if (selectedIndex > 0)
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]);
                myListBox.Items.RemoveAt(selectedIndex + 1);
                myListBox.SelectedIndex = selectedIndex - 1;
            }
            else
                BtnUp.Enabled = false;
        }
        void MoveDown(ListBox myListBox)
        {
            
            int selectedIndex = myListBox.SelectedIndex;
            try
            {
                if (selectedIndex > -1 | selectedIndex < myListBox.Items.Count)
                {
                    myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]);
                    myListBox.Items.RemoveAt(selectedIndex);
                    myListBox.SelectedIndex = selectedIndex + 1;
                }
            }
            catch
            {
                BtnDown.Enabled = false;
                MessageBox.Show("Limite atteinte", "Limite atteinte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private BindingList<string> BindingList1;

        public void BoutonSupActif()
        {
            if (LBoxCible.SelectedIndex != -1)
            {
                BtnSup.Enabled = true;
            }

            else
                BtnSup.Enabled = false;
        }
        public void BoutonTtSupActif()
        {
            if (LBoxCible.SelectedIndex != -1)
            {
                BtnTtSupp.Enabled = true;
            }

            else
                BtnTtSupp.Enabled = false;

        }
        public void BoutonTtAddActif()
        {
            if (CoBoxSource.SelectedIndex != -1)
            {
                BtnTtAjout.Enabled = true;
            }

            else
                BtnTtAjout.Enabled = false;

        }

        public void BoutonAddActif()
        {
            if (CoBoxSource.SelectedIndex != -1)
            {
                BtnAjout.Enabled = true;
            }

            else
                BtnAjout.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList1 = new BindingList<string>(Pays());
            CoBoxSource.Items.AddRange(BindingList1.ToArray());
            BoutonAddActif();
            BoutonSupActif();
            BoutonTtSupActif();
            BtnDown.Enabled = false;
            BtnUp.Enabled = false;
        }


        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if (LBoxCible.Items.Contains(CoBoxSource.SelectedItem) == false && CoBoxSource.Text != "")
            {
                LBoxCible.Items.Add(CoBoxSource.SelectedItem);
                CoBoxSource.Items.Remove((string)CoBoxSource.SelectedItem);
            }
            BoutonAddActif();
        }

        private void BtnTtAjout_Click(object sender, EventArgs e)
        {
            BoutonTtAddActif();
            for (int i = 0; i < BindingList1.Count; i++)
            {
                LBoxCible.Items.Add(BindingList1[i]);
            }
            CoBoxSource.Items.Clear();
            LBoxCible.Focus();


            //2nde possibilité
            /*for (int i = 0; i < CoBoxSource.Items.Count; i++)
            {
                CoBoxSource.Items.RemoveAt(0);
            }*/
        }


        private void CoBoxSource_Validating(object sender, CancelEventArgs e)
        {
            if (CoBoxSource.Items.Contains(CoBoxSource.Text) == false && CoBoxSource.Text != "")
            {
                BindingList1.Add(CoBoxSource.Text);
            }
        }

        private void BtnSup_Click(object sender, EventArgs e)
        {

            if (CoBoxSource.Items.Contains(LBoxCible.SelectedItem) == false && LBoxCible.Text != "")
            {
                CoBoxSource.Items.Add(LBoxCible.SelectedItem);
                LBoxCible.Items.Remove((string)LBoxCible.SelectedItem);
            }
            LBoxCible.Focus();
        }

        private void BtnTtSupp_Click(object sender, EventArgs e)
        {
            BoutonTtSupActif();
            for (int i = 0; i < BindingList1.Count; i++)
            {
                CoBoxSource.Items.Add(BindingList1[i]);
            }
            LBoxCible.Items.Clear();
            BoutonAddActif();
            BoutonTtAddActif();
            BoutonSupActif();
            BoutonTtSupActif();
        }

        private void LBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoutonAddActif();
            BoutonTtAddActif();
            BoutonSupActif();
            BoutonTtSupActif();
            if (LBoxCible.SelectedIndex > -1)
                BtnDown.Enabled = true;
            else
                BtnDown.Enabled = false;
            //if (LBoxCible.SelectedIndex < LBoxCible.Items.Count)
            //BtnUp.Enabled = false;
            if (LBoxCible.SelectedIndex > 0)
                BtnUp.Enabled = true;
            else
                BtnUp.Enabled = false;
        }

        private void CoBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoutonAddActif();
            BoutonTtAddActif();
            BoutonSupActif();
            BoutonTtSupActif();
            AcceptButton = BtnAjout;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
                MoveUp(LBoxCible);
        }
        private void BtnDown_Click(object sender, EventArgs e)
        {
            MoveDown(LBoxCible);
        }
    }
}

