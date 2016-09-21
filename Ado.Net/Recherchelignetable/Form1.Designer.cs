namespace Recherchelignetable
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
            this.LblCodeFou = new System.Windows.Forms.Label();
            this.GrpBoxInfoFou = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxContact = new System.Windows.Forms.TextBox();
            this.TxtBoxVille = new System.Windows.Forms.TextBox();
            this.TxtBoxCP = new System.Windows.Forms.TextBox();
            this.TxtBoxAdresse = new System.Windows.Forms.TextBox();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtBoxCodeFou = new System.Windows.Forms.TextBox();
            this.BtnCherche = new System.Windows.Forms.Button();
            this.GrpBoxInfoFou.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCodeFou
            // 
            this.LblCodeFou.AutoSize = true;
            this.LblCodeFou.Location = new System.Drawing.Point(13, 13);
            this.LblCodeFou.Name = "LblCodeFou";
            this.LblCodeFou.Size = new System.Drawing.Size(86, 13);
            this.LblCodeFou.TabIndex = 0;
            this.LblCodeFou.Text = "Code fournisseur";
            // 
            // GrpBoxInfoFou
            // 
            this.GrpBoxInfoFou.Controls.Add(this.label4);
            this.GrpBoxInfoFou.Controls.Add(this.label3);
            this.GrpBoxInfoFou.Controls.Add(this.label2);
            this.GrpBoxInfoFou.Controls.Add(this.label1);
            this.GrpBoxInfoFou.Controls.Add(this.TxtBoxContact);
            this.GrpBoxInfoFou.Controls.Add(this.TxtBoxVille);
            this.GrpBoxInfoFou.Controls.Add(this.TxtBoxCP);
            this.GrpBoxInfoFou.Controls.Add(this.TxtBoxAdresse);
            this.GrpBoxInfoFou.Controls.Add(this.TxtBoxNom);
            this.GrpBoxInfoFou.Location = new System.Drawing.Point(13, 50);
            this.GrpBoxInfoFou.Name = "GrpBoxInfoFou";
            this.GrpBoxInfoFou.Size = new System.Drawing.Size(326, 196);
            this.GrpBoxInfoFou.TabIndex = 1;
            this.GrpBoxInfoFou.TabStop = false;
            this.GrpBoxInfoFou.Text = "Info fournisseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CP / Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // TxtBoxContact
            // 
            this.TxtBoxContact.Location = new System.Drawing.Point(83, 154);
            this.TxtBoxContact.Name = "TxtBoxContact";
            this.TxtBoxContact.Size = new System.Drawing.Size(206, 20);
            this.TxtBoxContact.TabIndex = 4;
            // 
            // TxtBoxVille
            // 
            this.TxtBoxVille.Location = new System.Drawing.Point(154, 114);
            this.TxtBoxVille.Name = "TxtBoxVille";
            this.TxtBoxVille.Size = new System.Drawing.Size(135, 20);
            this.TxtBoxVille.TabIndex = 3;
            // 
            // TxtBoxCP
            // 
            this.TxtBoxCP.Location = new System.Drawing.Point(83, 114);
            this.TxtBoxCP.Name = "TxtBoxCP";
            this.TxtBoxCP.Size = new System.Drawing.Size(65, 20);
            this.TxtBoxCP.TabIndex = 2;
            // 
            // TxtBoxAdresse
            // 
            this.TxtBoxAdresse.Location = new System.Drawing.Point(83, 76);
            this.TxtBoxAdresse.Name = "TxtBoxAdresse";
            this.TxtBoxAdresse.Size = new System.Drawing.Size(206, 20);
            this.TxtBoxAdresse.TabIndex = 1;
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(83, 34);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(206, 20);
            this.TxtBoxNom.TabIndex = 0;
            // 
            // TxtBoxCodeFou
            // 
            this.TxtBoxCodeFou.Location = new System.Drawing.Point(125, 10);
            this.TxtBoxCodeFou.Name = "TxtBoxCodeFou";
            this.TxtBoxCodeFou.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxCodeFou.TabIndex = 2;
            this.TxtBoxCodeFou.TextChanged += new System.EventHandler(this.TxtBoxCodeFou_TextChanged_1);
            // 
            // BtnCherche
            // 
            this.BtnCherche.Location = new System.Drawing.Point(264, 10);
            this.BtnCherche.Name = "BtnCherche";
            this.BtnCherche.Size = new System.Drawing.Size(75, 23);
            this.BtnCherche.TabIndex = 3;
            this.BtnCherche.Text = "Cherchez";
            this.BtnCherche.UseVisualStyleBackColor = true;
            this.BtnCherche.Click += new System.EventHandler(this.BtnCherche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.BtnCherche);
            this.Controls.Add(this.TxtBoxCodeFou);
            this.Controls.Add(this.GrpBoxInfoFou);
            this.Controls.Add(this.LblCodeFou);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpBoxInfoFou.ResumeLayout(false);
            this.GrpBoxInfoFou.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodeFou;
        private System.Windows.Forms.GroupBox GrpBoxInfoFou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxContact;
        private System.Windows.Forms.TextBox TxtBoxVille;
        private System.Windows.Forms.TextBox TxtBoxCP;
        private System.Windows.Forms.TextBox TxtBoxAdresse;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.TextBox TxtBoxCodeFou;
        private System.Windows.Forms.Button BtnCherche;
    }
}

