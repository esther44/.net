namespace WindowsFormsPersonne
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
            this.btn_appuyer = new System.Windows.Forms.Button();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_recap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_appuyer
            // 
            this.btn_appuyer.Location = new System.Drawing.Point(301, 334);
            this.btn_appuyer.Name = "btn_appuyer";
            this.btn_appuyer.Size = new System.Drawing.Size(75, 23);
            this.btn_appuyer.TabIndex = 0;
            this.btn_appuyer.Text = "button1";
            this.btn_appuyer.UseVisualStyleBackColor = true;
            this.btn_appuyer.Click += new System.EventHandler(this.btn_appuyer_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(301, 219);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(301, 245);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 2;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(301, 193);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // lbl_recap
            // 
            this.lbl_recap.AutoSize = true;
            this.lbl_recap.Location = new System.Drawing.Point(301, 130);
            this.lbl_recap.Name = "lbl_recap";
            this.lbl_recap.Size = new System.Drawing.Size(35, 13);
            this.lbl_recap.TabIndex = 4;
            this.lbl_recap.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_recap);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.btn_appuyer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_appuyer;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_recap;
    }
}

