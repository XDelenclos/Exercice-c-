namespace RechercheJeuLigne
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
            this.LblChoix = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LblCommande = new System.Windows.Forms.Label();
            this.CoBoxChoix = new System.Windows.Forms.ComboBox();
            this.pAPYRUSDataSet = new RechercheJeuLigne.PAPYRUSDataSet();
            this.fOURNISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOURNISTableAdapter = new RechercheJeuLigne.PAPYRUSDataSetTableAdapters.FOURNISTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pAPYRUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblChoix
            // 
            this.LblChoix.AutoSize = true;
            this.LblChoix.Location = new System.Drawing.Point(12, 43);
            this.LblChoix.Name = "LblChoix";
            this.LblChoix.Size = new System.Drawing.Size(107, 13);
            this.LblChoix.TabIndex = 0;
            this.LblChoix.Text = "Choisir un fournisseur";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LblCommande
            // 
            this.LblCommande.AutoSize = true;
            this.LblCommande.Location = new System.Drawing.Point(12, 138);
            this.LblCommande.Name = "LblCommande";
            this.LblCommande.Size = new System.Drawing.Size(85, 13);
            this.LblCommande.TabIndex = 2;
            this.LblCommande.Text = "Les Commandes";
            // 
            // CoBoxChoix
            // 
            this.CoBoxChoix.FormattingEnabled = true;
            this.CoBoxChoix.Location = new System.Drawing.Point(128, 40);
            this.CoBoxChoix.Name = "CoBoxChoix";
            this.CoBoxChoix.Size = new System.Drawing.Size(121, 21);
            this.CoBoxChoix.TabIndex = 3;
            this.CoBoxChoix.SelectedIndexChanged += new System.EventHandler(this.CoBoxChoix_SelectedIndexChanged);
            // 
            // pAPYRUSDataSet
            // 
            this.pAPYRUSDataSet.DataSetName = "PAPYRUSDataSet";
            this.pAPYRUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOURNISBindingSource
            // 
            this.fOURNISBindingSource.DataMember = "FOURNIS";
            this.fOURNISBindingSource.DataSource = this.pAPYRUSDataSet;
            // 
            // fOURNISTableAdapter
            // 
            this.fOURNISTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CoBoxChoix);
            this.Controls.Add(this.LblCommande);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblChoix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pAPYRUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOURNISBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChoix;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label LblCommande;
        private System.Windows.Forms.ComboBox CoBoxChoix;
        private PAPYRUSDataSet pAPYRUSDataSet;
        private System.Windows.Forms.BindingSource fOURNISBindingSource;
        private PAPYRUSDataSetTableAdapters.FOURNISTableAdapter fOURNISTableAdapter;
    }
}

