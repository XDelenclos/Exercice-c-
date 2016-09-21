namespace WindowsFormsApplication3
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
            this.components = new System.ComponentModel.Container();
            this.LblFormatDate = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblCP = new System.Windows.Forms.Label();
            this.LblMontant = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.TxtCP = new System.Windows.Forms.TextBox();
            this.TxtMontant = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFormatDate
            // 
            this.LblFormatDate.AutoSize = true;
            this.LblFormatDate.Location = new System.Drawing.Point(233, 94);
            this.LblFormatDate.Name = "LblFormatDate";
            this.LblFormatDate.Size = new System.Drawing.Size(79, 13);
            this.LblFormatDate.TabIndex = 21;
            this.LblFormatDate.Text = "(JJ/MM/AAAA)";
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(275, 208);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 20;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Validating += new System.ComponentModel.CancelEventHandler(this.BtnValider_Validating);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(275, 247);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "Effacer";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Validating);
            // 
            // LblCP
            // 
            this.LblCP.AutoSize = true;
            this.LblCP.Location = new System.Drawing.Point(37, 177);
            this.LblCP.Name = "LblCP";
            this.LblCP.Size = new System.Drawing.Size(64, 13);
            this.LblCP.TabIndex = 18;
            this.LblCP.Text = "Code Postal";
            // 
            // LblMontant
            // 
            this.LblMontant.AutoSize = true;
            this.LblMontant.Location = new System.Drawing.Point(55, 137);
            this.LblMontant.Name = "LblMontant";
            this.LblMontant.Size = new System.Drawing.Size(46, 13);
            this.LblMontant.TabIndex = 17;
            this.LblMontant.Text = "Montant";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(71, 94);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 13);
            this.LblDate.TabIndex = 16;
            this.LblDate.Text = "Date";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(72, 57);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 15;
            this.LblNom.Text = "Nom";
            // 
            // TxtCP
            // 
            this.TxtCP.Location = new System.Drawing.Point(109, 174);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(118, 20);
            this.TxtCP.TabIndex = 14;
            this.TxtCP.TextChanged += new System.EventHandler(this.TxtCP_TextChanged);
            // 
            // TxtMontant
            // 
            this.TxtMontant.Location = new System.Drawing.Point(109, 134);
            this.TxtMontant.Name = "TxtMontant";
            this.TxtMontant.Size = new System.Drawing.Size(118, 20);
            this.TxtMontant.TabIndex = 13;
            this.TxtMontant.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMontant_Validating);
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(109, 91);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(118, 20);
            this.TxtDate.TabIndex = 12;
            this.TxtDate.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDate_Validating);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(109, 54);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(147, 20);
            this.TxtNom.TabIndex = 11;
            this.TxtNom.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNom_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 282);
            this.Controls.Add(this.LblFormatDate);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LblCP);
            this.Controls.Add(this.LblMontant);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.TxtMontant);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtNom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFormatDate;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblCP;
        private System.Windows.Forms.Label LblMontant;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxtCP;
        private System.Windows.Forms.TextBox TxtMontant;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

