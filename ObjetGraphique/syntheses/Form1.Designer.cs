namespace syntheses
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNom = new System.Windows.Forms.Label();
            this.LblCapEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblListe = new System.Windows.Forms.Label();
            this.GBTaux = new System.Windows.Forms.GroupBox();
            this.RadBout9 = new System.Windows.Forms.RadioButton();
            this.RadBout8 = new System.Windows.Forms.RadioButton();
            this.RadBout7 = new System.Windows.Forms.RadioButton();
            this.BoutVal = new System.Windows.Forms.Button();
            this.BoutAnnuler = new System.Windows.Forms.Button();
            this.HSBDureRemb = new System.Windows.Forms.HScrollBar();
            this.TxtBoxDure = new System.Windows.Forms.TextBox();
            this.TxtBoxCapEmp = new System.Windows.Forms.TextBox();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.ListBoxPeriode = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblMontant = new System.Windows.Forms.Label();
            this.LblNbreMois = new System.Windows.Forms.Label();
            this.GBTaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(16, 42);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // LblCapEmp
            // 
            this.LblCapEmp.AutoSize = true;
            this.LblCapEmp.Location = new System.Drawing.Point(16, 84);
            this.LblCapEmp.Name = "LblCapEmp";
            this.LblCapEmp.Size = new System.Drawing.Size(87, 13);
            this.LblCapEmp.TabIndex = 1;
            this.LblCapEmp.Text = "Capital Emprunté";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée en mois du remboursement";
            // 
            // LblListe
            // 
            this.LblListe.AutoSize = true;
            this.LblListe.Location = new System.Drawing.Point(31, 218);
            this.LblListe.Name = "LblListe";
            this.LblListe.Size = new System.Drawing.Size(146, 13);
            this.LblListe.TabIndex = 3;
            this.LblListe.Text = "Périodicité de remboursement";
            // 
            // GBTaux
            // 
            this.GBTaux.Controls.Add(this.RadBout9);
            this.GBTaux.Controls.Add(this.RadBout8);
            this.GBTaux.Controls.Add(this.RadBout7);
            this.GBTaux.Location = new System.Drawing.Point(451, 35);
            this.GBTaux.Name = "GBTaux";
            this.GBTaux.Size = new System.Drawing.Size(107, 151);
            this.GBTaux.TabIndex = 4;
            this.GBTaux.TabStop = false;
            this.GBTaux.Text = "Taux d\'intérêt";
            // 
            // RadBout9
            // 
            this.RadBout9.AutoSize = true;
            this.RadBout9.Location = new System.Drawing.Point(6, 107);
            this.RadBout9.Name = "RadBout9";
            this.RadBout9.Size = new System.Drawing.Size(39, 17);
            this.RadBout9.TabIndex = 6;
            this.RadBout9.TabStop = true;
            this.RadBout9.Text = "9%";
            this.RadBout9.UseVisualStyleBackColor = true;
            this.RadBout9.CheckedChanged += new System.EventHandler(this.RadBout9_CheckedChanged);
            // 
            // RadBout8
            // 
            this.RadBout8.AutoSize = true;
            this.RadBout8.Location = new System.Drawing.Point(6, 67);
            this.RadBout8.Name = "RadBout8";
            this.RadBout8.Size = new System.Drawing.Size(39, 17);
            this.RadBout8.TabIndex = 5;
            this.RadBout8.TabStop = true;
            this.RadBout8.Text = "8%";
            this.RadBout8.UseVisualStyleBackColor = true;
            this.RadBout8.CheckedChanged += new System.EventHandler(this.RadBout8_CheckedChanged);
            // 
            // RadBout7
            // 
            this.RadBout7.AutoSize = true;
            this.RadBout7.Location = new System.Drawing.Point(6, 28);
            this.RadBout7.Name = "RadBout7";
            this.RadBout7.Size = new System.Drawing.Size(39, 17);
            this.RadBout7.TabIndex = 4;
            this.RadBout7.TabStop = true;
            this.RadBout7.Text = "7%";
            this.RadBout7.UseVisualStyleBackColor = true;
            this.RadBout7.CheckedChanged += new System.EventHandler(this.RadBout7_CheckedChanged);
            // 
            // BoutVal
            // 
            this.BoutVal.Location = new System.Drawing.Point(579, 39);
            this.BoutVal.Name = "BoutVal";
            this.BoutVal.Size = new System.Drawing.Size(75, 23);
            this.BoutVal.TabIndex = 7;
            this.BoutVal.Text = "OK";
            this.BoutVal.UseVisualStyleBackColor = true;
            this.BoutVal.Click += new System.EventHandler(this.BoutVal_Click);
            // 
            // BoutAnnuler
            // 
            this.BoutAnnuler.Location = new System.Drawing.Point(579, 84);
            this.BoutAnnuler.Name = "BoutAnnuler";
            this.BoutAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BoutAnnuler.TabIndex = 8;
            this.BoutAnnuler.Text = "Annuler";
            this.BoutAnnuler.UseVisualStyleBackColor = true;
            this.BoutAnnuler.Click += new System.EventHandler(this.BoutAnnuler_Click);
            // 
            // HSBDureRemb
            // 
            this.HSBDureRemb.Location = new System.Drawing.Point(147, 124);
            this.HSBDureRemb.Maximum = 249;
            this.HSBDureRemb.Minimum = 1;
            this.HSBDureRemb.Name = "HSBDureRemb";
            this.HSBDureRemb.Size = new System.Drawing.Size(227, 22);
            this.HSBDureRemb.TabIndex = 7;
            this.HSBDureRemb.Value = 1;
            this.HSBDureRemb.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBDureRemb_Scroll);
            this.HSBDureRemb.ValueChanged += new System.EventHandler(this.HSBDureRemb_ValueChanged);
            // 
            // TxtBoxDure
            // 
            this.TxtBoxDure.Enabled = false;
            this.TxtBoxDure.Location = new System.Drawing.Point(109, 126);
            this.TxtBoxDure.Name = "TxtBoxDure";
            this.TxtBoxDure.Size = new System.Drawing.Size(35, 20);
            this.TxtBoxDure.TabIndex = 8;
            this.TxtBoxDure.TextChanged += new System.EventHandler(this.HSBDureRemb_Scroll);
            // 
            // TxtBoxCapEmp
            // 
            this.TxtBoxCapEmp.Location = new System.Drawing.Point(109, 81);
            this.TxtBoxCapEmp.Name = "TxtBoxCapEmp";
            this.TxtBoxCapEmp.Size = new System.Drawing.Size(144, 20);
            this.TxtBoxCapEmp.TabIndex = 2;
            this.TxtBoxCapEmp.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxCapEmp_Validating);
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(109, 39);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(144, 20);
            this.TxtBoxNom.TabIndex = 1;
            // 
            // ListBoxPeriode
            // 
            this.ListBoxPeriode.FormattingEnabled = true;
            this.ListBoxPeriode.Items.AddRange(new object[] {
            "Mensuelle",
            "Bimestruelle",
            "Trimestruelle",
            "Semestrielle",
            "Annuelle"});
            this.ListBoxPeriode.Location = new System.Drawing.Point(30, 232);
            this.ListBoxPeriode.Name = "ListBoxPeriode";
            this.ListBoxPeriode.Size = new System.Drawing.Size(223, 95);
            this.ListBoxPeriode.TabIndex = 3;
            this.ListBoxPeriode.SelectedIndexChanged += new System.EventHandler(this.ListBoxPeriode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Remboursement";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblMontant
            // 
            this.LblMontant.AutoSize = true;
            this.LblMontant.Location = new System.Drawing.Point(523, 282);
            this.LblMontant.Name = "LblMontant";
            this.LblMontant.Size = new System.Drawing.Size(13, 13);
            this.LblMontant.TabIndex = 13;
            this.LblMontant.Text = "L";
            // 
            // LblNbreMois
            // 
            this.LblNbreMois.AutoSize = true;
            this.LblNbreMois.Location = new System.Drawing.Point(428, 245);
            this.LblNbreMois.Name = "LblNbreMois";
            this.LblNbreMois.Size = new System.Drawing.Size(0, 13);
            this.LblNbreMois.TabIndex = 14;
            this.LblNbreMois.TextChanged += new System.EventHandler(this.HSBDureRemb_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 346);
            this.Controls.Add(this.LblNbreMois);
            this.Controls.Add(this.LblMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBoxPeriode);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.TxtBoxCapEmp);
            this.Controls.Add(this.TxtBoxDure);
            this.Controls.Add(this.HSBDureRemb);
            this.Controls.Add(this.BoutAnnuler);
            this.Controls.Add(this.BoutVal);
            this.Controls.Add(this.GBTaux);
            this.Controls.Add(this.LblListe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblCapEmp);
            this.Controls.Add(this.LblNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBTaux.ResumeLayout(false);
            this.GBTaux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblCapEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblListe;
        private System.Windows.Forms.GroupBox GBTaux;
        private System.Windows.Forms.RadioButton RadBout9;
        private System.Windows.Forms.RadioButton RadBout8;
        private System.Windows.Forms.RadioButton RadBout7;
        private System.Windows.Forms.Button BoutVal;
        private System.Windows.Forms.Button BoutAnnuler;
        private System.Windows.Forms.HScrollBar HSBDureRemb;
        private System.Windows.Forms.TextBox TxtBoxDure;
        private System.Windows.Forms.TextBox TxtBoxCapEmp;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.ListBox ListBoxPeriode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblMontant;
        private System.Windows.Forms.Label LblNbreMois;
    }
}

