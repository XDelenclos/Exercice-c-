namespace OpListBox
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
            this.LblNew = new System.Windows.Forms.Label();
            this.LblIndex = new System.Windows.Forms.Label();
            this.LblListe = new System.Windows.Forms.Label();
            this.LblProp = new System.Windows.Forms.Label();
            this.TBoxNewElem = new System.Windows.Forms.TextBox();
            this.TBoxIndex = new System.Windows.Forms.TextBox();
            this.TBoxText = new System.Windows.Forms.TextBox();
            this.TBoxSelInd = new System.Windows.Forms.TextBox();
            this.TBoxItems = new System.Windows.Forms.TextBox();
            this.LblItems = new System.Windows.Forms.Label();
            this.LblSelected = new System.Windows.Forms.Label();
            this.LblTxt = new System.Windows.Forms.Label();
            this.LstListe = new System.Windows.Forms.ListBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnSelec = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNew
            // 
            this.LblNew.AutoSize = true;
            this.LblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNew.Location = new System.Drawing.Point(13, 13);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(96, 13);
            this.LblNew.TabIndex = 0;
            this.LblNew.Text = "Nouvel Elément";
            // 
            // LblIndex
            // 
            this.LblIndex.AutoSize = true;
            this.LblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndex.Location = new System.Drawing.Point(260, 13);
            this.LblIndex.Name = "LblIndex";
            this.LblIndex.Size = new System.Drawing.Size(87, 13);
            this.LblIndex.TabIndex = 1;
            this.LblIndex.Text = "Index Elément";
            // 
            // LblListe
            // 
            this.LblListe.AutoSize = true;
            this.LblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListe.Location = new System.Drawing.Point(13, 153);
            this.LblListe.Name = "LblListe";
            this.LblListe.Size = new System.Drawing.Size(51, 13);
            this.LblListe.TabIndex = 2;
            this.LblListe.Text = "LstListe";
            // 
            // LblProp
            // 
            this.LblProp.AutoSize = true;
            this.LblProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProp.Location = new System.Drawing.Point(248, 153);
            this.LblProp.Name = "LblProp";
            this.LblProp.Size = new System.Drawing.Size(64, 13);
            this.LblProp.TabIndex = 3;
            this.LblProp.Text = "Propriétés";
            // 
            // TBoxNewElem
            // 
            this.TBoxNewElem.Location = new System.Drawing.Point(16, 30);
            this.TBoxNewElem.Name = "TBoxNewElem";
            this.TBoxNewElem.Size = new System.Drawing.Size(155, 20);
            this.TBoxNewElem.TabIndex = 1;
            this.TBoxNewElem.TextChanged += new System.EventHandler(this.TBoxNewElem_TextChanged);
            // 
            // TBoxIndex
            // 
            this.TBoxIndex.Location = new System.Drawing.Point(263, 29);
            this.TBoxIndex.Name = "TBoxIndex";
            this.TBoxIndex.Size = new System.Drawing.Size(43, 20);
            this.TBoxIndex.TabIndex = 3;
            this.TBoxIndex.TextChanged += new System.EventHandler(this.TBoxIndex_TextChanged);
            // 
            // TBoxText
            // 
            this.TBoxText.BackColor = System.Drawing.SystemColors.Menu;
            this.TBoxText.Location = new System.Drawing.Point(325, 238);
            this.TBoxText.Name = "TBoxText";
            this.TBoxText.ReadOnly = true;
            this.TBoxText.Size = new System.Drawing.Size(100, 20);
            this.TBoxText.TabIndex = 6;
            this.TBoxText.TabStop = false;
            // 
            // TBoxSelInd
            // 
            this.TBoxSelInd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TBoxSelInd.Location = new System.Drawing.Point(325, 212);
            this.TBoxSelInd.Name = "TBoxSelInd";
            this.TBoxSelInd.ReadOnly = true;
            this.TBoxSelInd.Size = new System.Drawing.Size(43, 20);
            this.TBoxSelInd.TabIndex = 7;
            this.TBoxSelInd.TabStop = false;
            // 
            // TBoxItems
            // 
            this.TBoxItems.BackColor = System.Drawing.SystemColors.Menu;
            this.TBoxItems.Location = new System.Drawing.Point(325, 186);
            this.TBoxItems.Name = "TBoxItems";
            this.TBoxItems.ReadOnly = true;
            this.TBoxItems.Size = new System.Drawing.Size(43, 20);
            this.TBoxItems.TabIndex = 8;
            this.TBoxItems.TabStop = false;
            // 
            // LblItems
            // 
            this.LblItems.AutoSize = true;
            this.LblItems.Location = new System.Drawing.Point(248, 189);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(63, 13);
            this.LblItems.TabIndex = 9;
            this.LblItems.Text = "Items.Count";
            // 
            // LblSelected
            // 
            this.LblSelected.AutoSize = true;
            this.LblSelected.Location = new System.Drawing.Point(248, 215);
            this.LblSelected.Name = "LblSelected";
            this.LblSelected.Size = new System.Drawing.Size(75, 13);
            this.LblSelected.TabIndex = 10;
            this.LblSelected.Text = "SelectedIndex";
            // 
            // LblTxt
            // 
            this.LblTxt.AutoSize = true;
            this.LblTxt.Location = new System.Drawing.Point(248, 241);
            this.LblTxt.Name = "LblTxt";
            this.LblTxt.Size = new System.Drawing.Size(28, 13);
            this.LblTxt.TabIndex = 11;
            this.LblTxt.Text = "Text";
            // 
            // LstListe
            // 
            this.LstListe.FormattingEnabled = true;
            this.LstListe.Location = new System.Drawing.Point(16, 170);
            this.LstListe.Name = "LstListe";
            this.LstListe.Size = new System.Drawing.Size(155, 95);
            this.LstListe.TabIndex = 12;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(16, 69);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(155, 23);
            this.BtnAjout.TabIndex = 2;
            this.BtnAjout.Text = "Ajout Liste";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnSelec
            // 
            this.BtnSelec.Location = new System.Drawing.Point(325, 30);
            this.BtnSelec.Name = "BtnSelec";
            this.BtnSelec.Size = new System.Drawing.Size(100, 23);
            this.BtnSelec.TabIndex = 4;
            this.BtnSelec.Text = "Sélectionner";
            this.BtnSelec.UseVisualStyleBackColor = true;
            this.BtnSelec.Click += new System.EventHandler(this.BtnSelec_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.Location = new System.Drawing.Point(325, 69);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(100, 23);
            this.BtnVider.TabIndex = 15;
            this.BtnVider.Text = "Vider la Liste";
            this.BtnVider.UseVisualStyleBackColor = true;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.BtnVider);
            this.Controls.Add(this.BtnSelec);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.LstListe);
            this.Controls.Add(this.LblTxt);
            this.Controls.Add(this.LblSelected);
            this.Controls.Add(this.LblItems);
            this.Controls.Add(this.TBoxItems);
            this.Controls.Add(this.TBoxSelInd);
            this.Controls.Add(this.TBoxText);
            this.Controls.Add(this.TBoxIndex);
            this.Controls.Add(this.TBoxNewElem);
            this.Controls.Add(this.LblProp);
            this.Controls.Add(this.LblListe);
            this.Controls.Add(this.LblIndex);
            this.Controls.Add(this.LblNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Label LblIndex;
        private System.Windows.Forms.Label LblListe;
        private System.Windows.Forms.Label LblProp;
        private System.Windows.Forms.TextBox TBoxNewElem;
        private System.Windows.Forms.TextBox TBoxIndex;
        private System.Windows.Forms.TextBox TBoxText;
        private System.Windows.Forms.TextBox TBoxSelInd;
        private System.Windows.Forms.TextBox TBoxItems;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.Label LblSelected;
        private System.Windows.Forms.Label LblTxt;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnSelec;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.ListBox LstListe;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

