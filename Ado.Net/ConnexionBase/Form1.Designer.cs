namespace ConnexionBase
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
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.BtnDeconnexion = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.LblServeur = new System.Windows.Forms.Label();
            this.LblBdD = new System.Windows.Forms.Label();
            this.LblEtat = new System.Windows.Forms.Label();
            this.LblEtatConnect = new System.Windows.Forms.Label();
            this.TxtBoxServeur = new System.Windows.Forms.TextBox();
            this.TxtErreur = new System.Windows.Forms.TextBox();
            this.TxtBoxBdD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.Location = new System.Drawing.Point(49, 169);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(105, 23);
            this.BtnConnexion.TabIndex = 0;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = true;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // BtnDeconnexion
            // 
            this.BtnDeconnexion.Location = new System.Drawing.Point(247, 169);
            this.BtnDeconnexion.Name = "BtnDeconnexion";
            this.BtnDeconnexion.Size = new System.Drawing.Size(105, 23);
            this.BtnDeconnexion.TabIndex = 1;
            this.BtnDeconnexion.Text = "Déconnexion";
            this.BtnDeconnexion.UseVisualStyleBackColor = true;
            this.BtnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(247, 198);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(105, 23);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // LblServeur
            // 
            this.LblServeur.AutoSize = true;
            this.LblServeur.Location = new System.Drawing.Point(24, 28);
            this.LblServeur.Name = "LblServeur";
            this.LblServeur.Size = new System.Drawing.Size(50, 13);
            this.LblServeur.TabIndex = 3;
            this.LblServeur.Text = "Serveur :";
            // 
            // LblBdD
            // 
            this.LblBdD.AutoSize = true;
            this.LblBdD.Location = new System.Drawing.Point(24, 71);
            this.LblBdD.Name = "LblBdD";
            this.LblBdD.Size = new System.Drawing.Size(96, 13);
            this.LblBdD.TabIndex = 4;
            this.LblBdD.Text = "Base de données :";
            // 
            // LblEtat
            // 
            this.LblEtat.AutoSize = true;
            this.LblEtat.Location = new System.Drawing.Point(157, 240);
            this.LblEtat.Name = "LblEtat";
            this.LblEtat.Size = new System.Drawing.Size(39, 13);
            this.LblEtat.TabIndex = 5;
            this.LblEtat.Text = "Closed";
            this.LblEtat.Click += new System.EventHandler(this.LblEtat_Click);
            // 
            // LblEtatConnect
            // 
            this.LblEtatConnect.AutoSize = true;
            this.LblEtatConnect.Location = new System.Drawing.Point(24, 240);
            this.LblEtatConnect.Name = "LblEtatConnect";
            this.LblEtatConnect.Size = new System.Drawing.Size(104, 13);
            this.LblEtatConnect.TabIndex = 6;
            this.LblEtatConnect.Text = "Etat de la connexion";
            // 
            // TxtBoxServeur
            // 
            this.TxtBoxServeur.Location = new System.Drawing.Point(151, 25);
            this.TxtBoxServeur.Name = "TxtBoxServeur";
            this.TxtBoxServeur.Size = new System.Drawing.Size(220, 20);
            this.TxtBoxServeur.TabIndex = 7;
            // 
            // TxtErreur
            // 
            this.TxtErreur.Location = new System.Drawing.Point(27, 256);
            this.TxtErreur.Multiline = true;
            this.TxtErreur.Name = "TxtErreur";
            this.TxtErreur.Size = new System.Drawing.Size(344, 161);
            this.TxtErreur.TabIndex = 8;
            // 
            // TxtBoxBdD
            // 
            this.TxtBoxBdD.Location = new System.Drawing.Point(151, 68);
            this.TxtBoxBdD.Name = "TxtBoxBdD";
            this.TxtBoxBdD.Size = new System.Drawing.Size(220, 20);
            this.TxtBoxBdD.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 444);
            this.Controls.Add(this.TxtBoxBdD);
            this.Controls.Add(this.TxtErreur);
            this.Controls.Add(this.TxtBoxServeur);
            this.Controls.Add(this.LblEtatConnect);
            this.Controls.Add(this.LblEtat);
            this.Controls.Add(this.LblBdD);
            this.Controls.Add(this.LblServeur);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnDeconnexion);
            this.Controls.Add(this.BtnConnexion);
            this.Name = "Form1";
            this.Text = "Connexion à la base de données";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.Button BtnDeconnexion;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label LblServeur;
        private System.Windows.Forms.Label LblBdD;
        private System.Windows.Forms.Label LblEtat;
        private System.Windows.Forms.Label LblEtatConnect;
        private System.Windows.Forms.TextBox TxtBoxServeur;
        private System.Windows.Forms.TextBox TxtErreur;
        private System.Windows.Forms.TextBox TxtBoxBdD;
    }
}

