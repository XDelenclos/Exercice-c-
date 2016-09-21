namespace InsertFournis
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
            this.TrackBSatis = new System.Windows.Forms.TrackBar();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtBoxAdresse = new System.Windows.Forms.TextBox();
            this.TxtBoxCP = new System.Windows.Forms.TextBox();
            this.TxtBoxVille = new System.Windows.Forms.TextBox();
            this.TxtBoxContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackBSatis
            // 
            this.TrackBSatis.Location = new System.Drawing.Point(153, 310);
            this.TrackBSatis.Name = "TrackBSatis";
            this.TrackBSatis.Size = new System.Drawing.Size(387, 45);
            this.TrackBSatis.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(465, 392);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Quitter";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(347, 392);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Ajouter";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indice de satisfaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Code Postale";
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(33, 48);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(507, 20);
            this.TxtBoxNom.TabIndex = 10;
            this.TxtBoxNom.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxNom_Validating);
            // 
            // TxtBoxAdresse
            // 
            this.TxtBoxAdresse.Location = new System.Drawing.Point(33, 104);
            this.TxtBoxAdresse.Multiline = true;
            this.TxtBoxAdresse.Name = "TxtBoxAdresse";
            this.TxtBoxAdresse.Size = new System.Drawing.Size(507, 67);
            this.TxtBoxAdresse.TabIndex = 11;
            this.TxtBoxAdresse.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxAdresse_Validating);
            // 
            // TxtBoxCP
            // 
            this.TxtBoxCP.Location = new System.Drawing.Point(33, 208);
            this.TxtBoxCP.Name = "TxtBoxCP";
            this.TxtBoxCP.Size = new System.Drawing.Size(176, 20);
            this.TxtBoxCP.TabIndex = 12;
            this.TxtBoxCP.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxCP_Validating);
            // 
            // TxtBoxVille
            // 
            this.TxtBoxVille.Location = new System.Drawing.Point(280, 208);
            this.TxtBoxVille.Name = "TxtBoxVille";
            this.TxtBoxVille.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxVille.TabIndex = 13;
            this.TxtBoxVille.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxVille_Validating);
            // 
            // TxtBoxContact
            // 
            this.TxtBoxContact.Location = new System.Drawing.Point(33, 266);
            this.TxtBoxContact.Name = "TxtBoxContact";
            this.TxtBoxContact.Size = new System.Drawing.Size(507, 20);
            this.TxtBoxContact.TabIndex = 14;
            this.TxtBoxContact.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxContact_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ville";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 435);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBoxContact);
            this.Controls.Add(this.TxtBoxVille);
            this.Controls.Add(this.TxtBoxCP);
            this.Controls.Add(this.TxtBoxAdresse);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TrackBSatis);
            this.Name = "Form1";
            this.Text = "Ajout Fournisseur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrackBSatis;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.TextBox TxtBoxAdresse;
        private System.Windows.Forms.TextBox TxtBoxCP;
        private System.Windows.Forms.TextBox TxtBoxVille;
        private System.Windows.Forms.TextBox TxtBoxContact;
        private System.Windows.Forms.Label label8;
    }
}

