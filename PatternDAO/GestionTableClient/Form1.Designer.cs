namespace GestionTableClient
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
            this.DtViewList = new System.Windows.Forms.DataGridView();
            this.BtnADD = new System.Windows.Forms.Button();
            this.BtnModif = new System.Windows.Forms.Button();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.GrpBoxDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtViewList)).BeginInit();
            this.GrpBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DtViewList
            // 
            this.DtViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtViewList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtViewList.Location = new System.Drawing.Point(17, 22);
            this.DtViewList.Name = "DtViewList";
            this.DtViewList.RowHeadersVisible = false;
            this.DtViewList.Size = new System.Drawing.Size(228, 253);
            this.DtViewList.TabIndex = 0;
            this.DtViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtViewList_CellClick);
        
            // 
            // BtnADD
            // 
            this.BtnADD.Location = new System.Drawing.Point(251, 22);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(116, 23);
            this.BtnADD.TabIndex = 1;
            this.BtnADD.Text = "Ajouter";
            this.BtnADD.UseVisualStyleBackColor = true;
            this.BtnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // BtnModif
            // 
            this.BtnModif.Location = new System.Drawing.Point(251, 51);
            this.BtnModif.Name = "BtnModif";
            this.BtnModif.Size = new System.Drawing.Size(116, 23);
            this.BtnModif.TabIndex = 2;
            this.BtnModif.Text = "Modifier";
            this.BtnModif.UseVisualStyleBackColor = true;
            this.BtnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // BtnSupp
            // 
            this.BtnSupp.Location = new System.Drawing.Point(251, 80);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(116, 23);
            this.BtnSupp.TabIndex = 3;
            this.BtnSupp.Text = "Supprimer";
            this.BtnSupp.UseVisualStyleBackColor = true;
            this.BtnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // GrpBoxDetails
            // 
            this.GrpBoxDetails.Controls.Add(this.label3);
            this.GrpBoxDetails.Controls.Add(this.label2);
            this.GrpBoxDetails.Controls.Add(this.label1);
            this.GrpBoxDetails.Controls.Add(this.BtnOK);
            this.GrpBoxDetails.Controls.Add(this.BtnCancel);
            this.GrpBoxDetails.Controls.Add(this.textBox3);
            this.GrpBoxDetails.Controls.Add(this.textBox2);
            this.GrpBoxDetails.Controls.Add(this.textBox1);
            this.GrpBoxDetails.Location = new System.Drawing.Point(399, 22);
            this.GrpBoxDetails.Name = "GrpBoxDetails";
            this.GrpBoxDetails.Size = new System.Drawing.Size(290, 253);
            this.GrpBoxDetails.TabIndex = 4;
            this.GrpBoxDetails.TabStop = false;
            this.GrpBoxDetails.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(6, 224);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(186, 224);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 287);
            this.Controls.Add(this.GrpBoxDetails);
            this.Controls.Add(this.BtnSupp);
            this.Controls.Add(this.BtnModif);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.DtViewList);
            this.Name = "Form1";
            this.Text = "Gestion des Clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtViewList)).EndInit();
            this.GrpBoxDetails.ResumeLayout(false);
            this.GrpBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtViewList;
        private System.Windows.Forms.Button BtnADD;
        private System.Windows.Forms.Button BtnModif;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.GroupBox GrpBoxDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

