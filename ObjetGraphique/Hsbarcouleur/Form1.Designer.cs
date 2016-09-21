namespace Hsbarcouleur
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
            this.LaBResultat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HSSBRouge = new System.Windows.Forms.HScrollBar();
            this.HSSBVert = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumUpDownBleu = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownVert = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownRouge = new System.Windows.Forms.NumericUpDown();
            this.HSSBBleu = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownRouge)).BeginInit();
            this.SuspendLayout();
            // 
            // LaBResultat
            // 
            this.LaBResultat.Location = new System.Drawing.Point(16, 190);
            this.LaBResultat.Name = "LaBResultat";
            this.LaBResultat.Size = new System.Drawing.Size(400, 76);
            this.LaBResultat.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "          ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "          ";
            // 
            // HSSBRouge
            // 
            this.HSSBRouge.Location = new System.Drawing.Point(77, 51);
            this.HSSBRouge.Maximum = 264;
            this.HSSBRouge.Name = "HSSBRouge";
            this.HSSBRouge.Size = new System.Drawing.Size(151, 24);
            this.HSSBRouge.TabIndex = 23;
            this.HSSBRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSSBRouge_Scroll);
            // 
            // HSSBVert
            // 
            this.HSSBVert.Location = new System.Drawing.Point(77, 80);
            this.HSSBVert.Maximum = 264;
            this.HSSBVert.Name = "HSSBVert";
            this.HSSBVert.Size = new System.Drawing.Size(151, 24);
            this.HSSBVert.TabIndex = 22;
            this.HSSBVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSSBVert_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bleu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rouge";
            // 
            // NumUpDownBleu
            // 
            this.NumUpDownBleu.Location = new System.Drawing.Point(231, 119);
            this.NumUpDownBleu.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUpDownBleu.Name = "NumUpDownBleu";
            this.NumUpDownBleu.Size = new System.Drawing.Size(87, 20);
            this.NumUpDownBleu.TabIndex = 18;
            this.NumUpDownBleu.ValueChanged += new System.EventHandler(this.HSSBBleu_Scroll);
            // 
            // NumUpDownVert
            // 
            this.NumUpDownVert.Location = new System.Drawing.Point(231, 80);
            this.NumUpDownVert.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUpDownVert.Name = "NumUpDownVert";
            this.NumUpDownVert.Size = new System.Drawing.Size(87, 20);
            this.NumUpDownVert.TabIndex = 17;
            this.NumUpDownVert.ValueChanged += new System.EventHandler(this.HSSBVert_Scroll);
            // 
            // NumUpDownRouge
            // 
            this.NumUpDownRouge.Location = new System.Drawing.Point(231, 51);
            this.NumUpDownRouge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumUpDownRouge.Name = "NumUpDownRouge";
            this.NumUpDownRouge.Size = new System.Drawing.Size(87, 20);
            this.NumUpDownRouge.TabIndex = 16;
            this.NumUpDownRouge.ValueChanged += new System.EventHandler(this.HSSBRouge_Scroll);
            // 
            // HSSBBleu
            // 
            this.HSSBBleu.Location = new System.Drawing.Point(77, 119);
            this.HSSBBleu.Maximum = 264;
            this.HSSBBleu.Name = "HSSBBleu";
            this.HSSBBleu.Size = new System.Drawing.Size(151, 24);
            this.HSSBBleu.TabIndex = 15;
            this.HSSBBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSSBBleu_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 292);
            this.Controls.Add(this.LaBResultat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HSSBRouge);
            this.Controls.Add(this.HSSBVert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUpDownBleu);
            this.Controls.Add(this.NumUpDownVert);
            this.Controls.Add(this.NumUpDownRouge);
            this.Controls.Add(this.HSSBBleu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownRouge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaBResultat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar HSSBRouge;
        private System.Windows.Forms.HScrollBar HSSBVert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumUpDownBleu;
        private System.Windows.Forms.NumericUpDown NumUpDownVert;
        private System.Windows.Forms.NumericUpDown NumUpDownRouge;
        private System.Windows.Forms.HScrollBar HSSBBleu;
    }
}

