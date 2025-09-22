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
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(72, 48);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(100, 20);
            this.txt_marque.TabIndex = 0;
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(72, 100);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(100, 20);
            this.txt_reference.TabIndex = 1;
            // 
            // txt_prix
            // 
            this.txt_prix.Location = new System.Drawing.Point(72, 148);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(100, 20);
            this.txt_prix.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(69, 9);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(35, 13);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "label1";
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_valider.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Location = new System.Drawing.Point(63, 207);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.txt_marque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_valider;
    }
}

