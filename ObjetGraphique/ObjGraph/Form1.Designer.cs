namespace ObjGraph
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
            this.LabelTxt = new System.Windows.Forms.Label();
            this.TxtBoxText = new System.Windows.Forms.TextBox();
            this.GroupBoxChoix = new System.Windows.Forms.GroupBox();
            this.CBoxCasse = new System.Windows.Forms.CheckBox();
            this.CBoxCarac = new System.Windows.Forms.CheckBox();
            this.CBoxFond = new System.Windows.Forms.CheckBox();
            this.GBoxFond = new System.Windows.Forms.GroupBox();
            this.RBtnFBleu = new System.Windows.Forms.RadioButton();
            this.RBtnFVert = new System.Windows.Forms.RadioButton();
            this.RBtnFRouge = new System.Windows.Forms.RadioButton();
            this.GBoxCarac = new System.Windows.Forms.GroupBox();
            this.RBtnCNoir = new System.Windows.Forms.RadioButton();
            this.RBtnCBlanc = new System.Windows.Forms.RadioButton();
            this.RBtnCRouge = new System.Windows.Forms.RadioButton();
            this.GBoxCasse = new System.Windows.Forms.GroupBox();
            this.RbtnMaj = new System.Windows.Forms.RadioButton();
            this.RBtnMinus = new System.Windows.Forms.RadioButton();
            this.Resultat = new System.Windows.Forms.Label();
            this.GroupBoxChoix.SuspendLayout();
            this.GBoxFond.SuspendLayout();
            this.GBoxCarac.SuspendLayout();
            this.GBoxCasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTxt
            // 
            this.LabelTxt.AutoSize = true;
            this.LabelTxt.Location = new System.Drawing.Point(28, 20);
            this.LabelTxt.Name = "LabelTxt";
            this.LabelTxt.Size = new System.Drawing.Size(90, 13);
            this.LabelTxt.TabIndex = 0;
            this.LabelTxt.Text = "Tapez votre texte";
            // 
            // TxtBoxText
            // 
            this.TxtBoxText.Location = new System.Drawing.Point(31, 45);
            this.TxtBoxText.Name = "TxtBoxText";
            this.TxtBoxText.Size = new System.Drawing.Size(224, 20);
            this.TxtBoxText.TabIndex = 1;
            this.TxtBoxText.TextChanged += new System.EventHandler(this.TxtBoxText_TextChanged);
            // 
            // GroupBoxChoix
            // 
            this.GroupBoxChoix.Controls.Add(this.CBoxCasse);
            this.GroupBoxChoix.Controls.Add(this.CBoxCarac);
            this.GroupBoxChoix.Controls.Add(this.CBoxFond);
            this.GroupBoxChoix.Location = new System.Drawing.Point(330, 12);
            this.GroupBoxChoix.Name = "GroupBoxChoix";
            this.GroupBoxChoix.Size = new System.Drawing.Size(189, 92);
            this.GroupBoxChoix.TabIndex = 2;
            this.GroupBoxChoix.TabStop = false;
            this.GroupBoxChoix.Text = "Choix";
            // 
            // CBoxCasse
            // 
            this.CBoxCasse.AutoSize = true;
            this.CBoxCasse.Location = new System.Drawing.Point(6, 64);
            this.CBoxCasse.Name = "CBoxCasse";
            this.CBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.CBoxCasse.TabIndex = 2;
            this.CBoxCasse.Text = "Casse";
            this.CBoxCasse.UseVisualStyleBackColor = true;
            this.CBoxCasse.CheckedChanged += new System.EventHandler(this.CBoxCasse_CheckedChanged);
            // 
            // CBoxCarac
            // 
            this.CBoxCarac.AutoSize = true;
            this.CBoxCarac.Location = new System.Drawing.Point(6, 41);
            this.CBoxCarac.Name = "CBoxCarac";
            this.CBoxCarac.Size = new System.Drawing.Size(135, 17);
            this.CBoxCarac.TabIndex = 1;
            this.CBoxCarac.Text = "Couleur des caractères";
            this.CBoxCarac.UseVisualStyleBackColor = true;
            this.CBoxCarac.CheckedChanged += new System.EventHandler(this.CBoxCarac_CheckedChanged);
            // 
            // CBoxFond
            // 
            this.CBoxFond.AutoSize = true;
            this.CBoxFond.Location = new System.Drawing.Point(6, 18);
            this.CBoxFond.Name = "CBoxFond";
            this.CBoxFond.Size = new System.Drawing.Size(101, 17);
            this.CBoxFond.TabIndex = 0;
            this.CBoxFond.Text = "Couleur du fond";
            this.CBoxFond.UseVisualStyleBackColor = true;
            this.CBoxFond.CheckedChanged += new System.EventHandler(this.CBoxFond_CheckedChanged);
            // 
            // GBoxFond
            // 
            this.GBoxFond.Controls.Add(this.RBtnFBleu);
            this.GBoxFond.Controls.Add(this.RBtnFVert);
            this.GBoxFond.Controls.Add(this.RBtnFRouge);
            this.GBoxFond.Location = new System.Drawing.Point(32, 215);
            this.GBoxFond.Name = "GBoxFond";
            this.GBoxFond.Size = new System.Drawing.Size(85, 85);
            this.GBoxFond.TabIndex = 3;
            this.GBoxFond.TabStop = false;
            this.GBoxFond.Text = "Fond";
            // 
            // RBtnFBleu
            // 
            this.RBtnFBleu.AutoSize = true;
            this.RBtnFBleu.Location = new System.Drawing.Point(6, 65);
            this.RBtnFBleu.Name = "RBtnFBleu";
            this.RBtnFBleu.Size = new System.Drawing.Size(46, 17);
            this.RBtnFBleu.TabIndex = 2;
            this.RBtnFBleu.TabStop = true;
            this.RBtnFBleu.Text = "Bleu";
            this.RBtnFBleu.UseVisualStyleBackColor = true;
            this.RBtnFBleu.CheckedChanged += new System.EventHandler(this.RBtnFBleu_CheckedChanged);
            // 
            // RBtnFVert
            // 
            this.RBtnFVert.AutoSize = true;
            this.RBtnFVert.Location = new System.Drawing.Point(6, 42);
            this.RBtnFVert.Name = "RBtnFVert";
            this.RBtnFVert.Size = new System.Drawing.Size(44, 17);
            this.RBtnFVert.TabIndex = 1;
            this.RBtnFVert.TabStop = true;
            this.RBtnFVert.Text = "Vert";
            this.RBtnFVert.UseVisualStyleBackColor = true;
            this.RBtnFVert.CheckedChanged += new System.EventHandler(this.RBtnFVert_CheckedChanged);
            // 
            // RBtnFRouge
            // 
            this.RBtnFRouge.AutoSize = true;
            this.RBtnFRouge.Location = new System.Drawing.Point(6, 19);
            this.RBtnFRouge.Name = "RBtnFRouge";
            this.RBtnFRouge.Size = new System.Drawing.Size(57, 17);
            this.RBtnFRouge.TabIndex = 0;
            this.RBtnFRouge.TabStop = true;
            this.RBtnFRouge.Text = "Rouge";
            this.RBtnFRouge.UseVisualStyleBackColor = true;
            this.RBtnFRouge.CheckedChanged += new System.EventHandler(this.RBtnFRouge_CheckedChanged);
            // 
            // GBoxCarac
            // 
            this.GBoxCarac.Controls.Add(this.RBtnCNoir);
            this.GBoxCarac.Controls.Add(this.RBtnCBlanc);
            this.GBoxCarac.Controls.Add(this.RBtnCRouge);
            this.GBoxCarac.Location = new System.Drawing.Point(123, 215);
            this.GBoxCarac.Name = "GBoxCarac";
            this.GBoxCarac.Size = new System.Drawing.Size(85, 85);
            this.GBoxCarac.TabIndex = 4;
            this.GBoxCarac.TabStop = false;
            this.GBoxCarac.Text = "Caractères";
            // 
            // RBtnCNoir
            // 
            this.RBtnCNoir.AutoSize = true;
            this.RBtnCNoir.Location = new System.Drawing.Point(6, 65);
            this.RBtnCNoir.Name = "RBtnCNoir";
            this.RBtnCNoir.Size = new System.Drawing.Size(44, 17);
            this.RBtnCNoir.TabIndex = 5;
            this.RBtnCNoir.TabStop = true;
            this.RBtnCNoir.Text = "Noir";
            this.RBtnCNoir.UseVisualStyleBackColor = true;
            this.RBtnCNoir.CheckedChanged += new System.EventHandler(this.RBtnCNoir_CheckedChanged);
            // 
            // RBtnCBlanc
            // 
            this.RBtnCBlanc.AutoSize = true;
            this.RBtnCBlanc.Location = new System.Drawing.Point(6, 42);
            this.RBtnCBlanc.Name = "RBtnCBlanc";
            this.RBtnCBlanc.Size = new System.Drawing.Size(52, 17);
            this.RBtnCBlanc.TabIndex = 4;
            this.RBtnCBlanc.TabStop = true;
            this.RBtnCBlanc.Text = "Blanc";
            this.RBtnCBlanc.UseVisualStyleBackColor = true;
            this.RBtnCBlanc.CheckedChanged += new System.EventHandler(this.RBtnCBlanc_CheckedChanged);
            // 
            // RBtnCRouge
            // 
            this.RBtnCRouge.AutoSize = true;
            this.RBtnCRouge.Location = new System.Drawing.Point(6, 19);
            this.RBtnCRouge.Name = "RBtnCRouge";
            this.RBtnCRouge.Size = new System.Drawing.Size(57, 17);
            this.RBtnCRouge.TabIndex = 3;
            this.RBtnCRouge.TabStop = true;
            this.RBtnCRouge.Text = "Rouge";
            this.RBtnCRouge.UseVisualStyleBackColor = true;
            this.RBtnCRouge.CheckedChanged += new System.EventHandler(this.RBtnCRouge_CheckedChanged);
            // 
            // GBoxCasse
            // 
            this.GBoxCasse.Controls.Add(this.RbtnMaj);
            this.GBoxCasse.Controls.Add(this.RBtnMinus);
            this.GBoxCasse.Location = new System.Drawing.Point(214, 236);
            this.GBoxCasse.Name = "GBoxCasse";
            this.GBoxCasse.Size = new System.Drawing.Size(85, 64);
            this.GBoxCasse.TabIndex = 5;
            this.GBoxCasse.TabStop = false;
            this.GBoxCasse.Text = "Casse";
            // 
            // RbtnMaj
            // 
            this.RbtnMaj.AutoSize = true;
            this.RbtnMaj.Location = new System.Drawing.Point(6, 42);
            this.RbtnMaj.Name = "RbtnMaj";
            this.RbtnMaj.Size = new System.Drawing.Size(78, 17);
            this.RbtnMaj.TabIndex = 7;
            this.RbtnMaj.TabStop = true;
            this.RbtnMaj.Text = "Majuscules";
            this.RbtnMaj.UseVisualStyleBackColor = true;
            this.RbtnMaj.CheckedChanged += new System.EventHandler(this.RbtnMaj_CheckedChanged);
            // 
            // RBtnMinus
            // 
            this.RBtnMinus.AutoSize = true;
            this.RBtnMinus.Location = new System.Drawing.Point(6, 19);
            this.RBtnMinus.Name = "RBtnMinus";
            this.RBtnMinus.Size = new System.Drawing.Size(78, 17);
            this.RBtnMinus.TabIndex = 6;
            this.RBtnMinus.TabStop = true;
            this.RBtnMinus.Text = "Minuscules";
            this.RBtnMinus.UseVisualStyleBackColor = true;
            this.RBtnMinus.CheckedChanged += new System.EventHandler(this.RBtnMinus_CheckedChanged);
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(35, 125);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(0, 13);
            this.Resultat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.GBoxCasse);
            this.Controls.Add(this.GBoxCarac);
            this.Controls.Add(this.GBoxFond);
            this.Controls.Add(this.GroupBoxChoix);
            this.Controls.Add(this.TxtBoxText);
            this.Controls.Add(this.LabelTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxChoix.ResumeLayout(false);
            this.GroupBoxChoix.PerformLayout();
            this.GBoxFond.ResumeLayout(false);
            this.GBoxFond.PerformLayout();
            this.GBoxCarac.ResumeLayout(false);
            this.GBoxCarac.PerformLayout();
            this.GBoxCasse.ResumeLayout(false);
            this.GBoxCasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTxt;
        private System.Windows.Forms.TextBox TxtBoxText;
        private System.Windows.Forms.GroupBox GroupBoxChoix;
        private System.Windows.Forms.CheckBox CBoxCasse;
        private System.Windows.Forms.CheckBox CBoxCarac;
        private System.Windows.Forms.CheckBox CBoxFond;
        private System.Windows.Forms.GroupBox GBoxFond;
        private System.Windows.Forms.RadioButton RBtnFBleu;
        private System.Windows.Forms.RadioButton RBtnFVert;
        private System.Windows.Forms.RadioButton RBtnFRouge;
        private System.Windows.Forms.GroupBox GBoxCarac;
        private System.Windows.Forms.RadioButton RBtnCNoir;
        private System.Windows.Forms.RadioButton RBtnCBlanc;
        private System.Windows.Forms.RadioButton RBtnCRouge;
        private System.Windows.Forms.GroupBox GBoxCasse;
        private System.Windows.Forms.RadioButton RbtnMaj;
        private System.Windows.Forms.RadioButton RBtnMinus;
        private System.Windows.Forms.Label Resultat;
    }
}

