namespace WindowsFormsAppCalculette
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
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_moins = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.nud_val1 = new System.Windows.Forms.NumericUpDown();
            this.nud_val2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_res = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_val1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_val2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(290, 240);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 23);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_moins
            // 
            this.btn_moins.Location = new System.Drawing.Point(371, 240);
            this.btn_moins.Name = "btn_moins";
            this.btn_moins.Size = new System.Drawing.Size(75, 23);
            this.btn_moins.TabIndex = 1;
            this.btn_moins.Text = "-";
            this.btn_moins.UseVisualStyleBackColor = true;
            this.btn_moins.Click += new System.EventHandler(this.btn_moins_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(452, 240);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 23);
            this.btn_mult.TabIndex = 2;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(533, 240);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // nud_val1
            // 
            this.nud_val1.DecimalPlaces = 2;
            this.nud_val1.Location = new System.Drawing.Point(294, 144);
            this.nud_val1.Name = "nud_val1";
            this.nud_val1.Size = new System.Drawing.Size(120, 20);
            this.nud_val1.TabIndex = 5;
            // 
            // nud_val2
            // 
            this.nud_val2.DecimalPlaces = 2;
            this.nud_val2.Location = new System.Drawing.Point(294, 188);
            this.nud_val2.Name = "nud_val2";
            this.nud_val2.Size = new System.Drawing.Size(120, 20);
            this.nud_val2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOMBRE 1";
            // 
            // lbl_rec
            // 
            this.lbl_rec.AutoSize = true;
            this.lbl_rec.Location = new System.Drawing.Point(176, 343);
            this.lbl_rec.Name = "lbl_rec";
            this.lbl_rec.Size = new System.Drawing.Size(43, 13);
            this.lbl_rec.TabIndex = 9;
            this.lbl_rec.Text = "RECAP";
            this.lbl_rec.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Location = new System.Drawing.Point(291, 343);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(50, 13);
            this.lbl_res.TabIndex = 10;
            this.lbl_res.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.lbl_rec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_val2);
            this.Controls.Add(this.nud_val1);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_moins);
            this.Controls.Add(this.btn_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_val1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_val2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_moins;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.NumericUpDown nud_val1;
        private System.Windows.Forms.NumericUpDown nud_val2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_res;
    }
}

