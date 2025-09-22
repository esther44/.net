namespace WindowsFormsApp1
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
            this.label_total = new System.Windows.Forms.Label();
            this.nud_quantite = new System.Windows.Forms.NumericUpDown();
            this.nud_prix = new System.Windows.Forms.NumericUpDown();
            this.label_totalHT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_ttc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ttc)).BeginInit();
            this.SuspendLayout();
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(516, 84);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(35, 13);
            this.label_total.TabIndex = 1;
            this.label_total.Text = "label1";
            // 
            // nud_quantite
            // 
            this.nud_quantite.Location = new System.Drawing.Point(102, 82);
            this.nud_quantite.Name = "nud_quantite";
            this.nud_quantite.Size = new System.Drawing.Size(120, 20);
            this.nud_quantite.TabIndex = 2;
            // 
            // nud_prix
            // 
            this.nud_prix.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nud_prix.DecimalPlaces = 2;
            this.nud_prix.Location = new System.Drawing.Point(302, 82);
            this.nud_prix.Name = "nud_prix";
            this.nud_prix.Size = new System.Drawing.Size(120, 20);
            this.nud_prix.TabIndex = 3;
            // 
            // label_totalHT
            // 
            this.label_totalHT.AutoSize = true;
            this.label_totalHT.Location = new System.Drawing.Point(519, 202);
            this.label_totalHT.Name = "label_totalHT";
            this.label_totalHT.Size = new System.Drawing.Size(35, 13);
            this.label_totalHT.TabIndex = 4;
            this.label_totalHT.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "prix TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "prix TOTAL";
            // 
            // nud_ttc
            // 
            this.nud_ttc.Location = new System.Drawing.Point(161, 192);
            this.nud_ttc.Name = "nud_ttc";
            this.nud_ttc.Size = new System.Drawing.Size(120, 20);
            this.nud_ttc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_ttc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_totalHT);
            this.Controls.Add(this.nud_prix);
            this.Controls.Add(this.nud_quantite);
            this.Controls.Add(this.label_total);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ttc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.NumericUpDown nud_quantite;
        private System.Windows.Forms.NumericUpDown nud_prix;
        private System.Windows.Forms.Label label_totalHT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_ttc;
    }
}

