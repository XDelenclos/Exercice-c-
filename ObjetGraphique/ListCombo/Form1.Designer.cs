namespace ListCombo
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
            this.CoBoxSource = new System.Windows.Forms.ComboBox();
            this.LblSource = new System.Windows.Forms.Label();
            this.LblCible = new System.Windows.Forms.Label();
            this.LBoxCible = new System.Windows.Forms.ListBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnTtAjout = new System.Windows.Forms.Button();
            this.BtnSup = new System.Windows.Forms.Button();
            this.BtnTtSupp = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoBoxSource
            // 
            this.CoBoxSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CoBoxSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CoBoxSource.FormattingEnabled = true;
            this.CoBoxSource.Location = new System.Drawing.Point(25, 41);
            this.CoBoxSource.Name = "CoBoxSource";
            this.CoBoxSource.Size = new System.Drawing.Size(121, 21);
            this.CoBoxSource.TabIndex = 0;
            this.CoBoxSource.SelectedIndexChanged += new System.EventHandler(this.CoBoxSource_SelectedIndexChanged);
            this.CoBoxSource.Validating += new System.ComponentModel.CancelEventHandler(this.CoBoxSource_Validating);
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(25, 22);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(41, 13);
            this.LblSource.TabIndex = 1;
            this.LblSource.Text = "Source";
            // 
            // LblCible
            // 
            this.LblCible.AutoSize = true;
            this.LblCible.Location = new System.Drawing.Point(263, 25);
            this.LblCible.Name = "LblCible";
            this.LblCible.Size = new System.Drawing.Size(30, 13);
            this.LblCible.TabIndex = 2;
            this.LblCible.Text = "Cible";
            // 
            // LBoxCible
            // 
            this.LBoxCible.FormattingEnabled = true;
            this.LBoxCible.Location = new System.Drawing.Point(266, 41);
            this.LBoxCible.Name = "LBoxCible";
            this.LBoxCible.Size = new System.Drawing.Size(120, 199);
            this.LBoxCible.TabIndex = 3;
            this.LBoxCible.SelectedIndexChanged += new System.EventHandler(this.LBoxCible_SelectedIndexChanged);
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(168, 41);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnAjout.TabIndex = 4;
            this.BtnAjout.Text = ">";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnTtAjout
            // 
            this.BtnTtAjout.Location = new System.Drawing.Point(168, 70);
            this.BtnTtAjout.Name = "BtnTtAjout";
            this.BtnTtAjout.Size = new System.Drawing.Size(75, 23);
            this.BtnTtAjout.TabIndex = 2;
            this.BtnTtAjout.Text = ">>";
            this.BtnTtAjout.UseVisualStyleBackColor = true;
            this.BtnTtAjout.Click += new System.EventHandler(this.BtnTtAjout_Click);
            // 
            // BtnSup
            // 
            this.BtnSup.Location = new System.Drawing.Point(168, 173);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(75, 23);
            this.BtnSup.TabIndex = 6;
            this.BtnSup.Text = "<";
            this.BtnSup.UseVisualStyleBackColor = true;
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // BtnTtSupp
            // 
            this.BtnTtSupp.Location = new System.Drawing.Point(168, 202);
            this.BtnTtSupp.Name = "BtnTtSupp";
            this.BtnTtSupp.Size = new System.Drawing.Size(75, 23);
            this.BtnTtSupp.TabIndex = 7;
            this.BtnTtSupp.Text = "<<";
            this.BtnTtSupp.UseVisualStyleBackColor = true;
            this.BtnTtSupp.Click += new System.EventHandler(this.BtnTtSupp_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUp.Location = new System.Drawing.Point(295, 243);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(32, 37);
            this.BtnUp.TabIndex = 8;
            this.BtnUp.Text = "↑";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDown.Location = new System.Drawing.Point(333, 243);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(32, 37);
            this.BtnDown.TabIndex = 9;
            this.BtnDown.Text = "↓";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 292);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.BtnTtSupp);
            this.Controls.Add(this.BtnSup);
            this.Controls.Add(this.BtnTtAjout);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.LBoxCible);
            this.Controls.Add(this.LblCible);
            this.Controls.Add(this.LblSource);
            this.Controls.Add(this.CoBoxSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CoBoxSource;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label LblCible;
        private System.Windows.Forms.ListBox LBoxCible;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnTtAjout;
        private System.Windows.Forms.Button BtnSup;
        private System.Windows.Forms.Button BtnTtSupp;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
    }
}

