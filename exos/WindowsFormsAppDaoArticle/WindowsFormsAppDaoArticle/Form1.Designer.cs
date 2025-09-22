namespace WindowsFormsAppDaoArticle
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
            this.btn_selectAll = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_selectByRef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.Location = new System.Drawing.Point(77, 95);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_selectAll.TabIndex = 0;
            this.btn_selectAll.Text = "select all";
            this.btn_selectAll.UseVisualStyleBackColor = true;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(77, 180);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_selectByRef
            // 
            this.btn_selectByRef.Location = new System.Drawing.Point(77, 262);
            this.btn_selectByRef.Name = "btn_selectByRef";
            this.btn_selectByRef.Size = new System.Drawing.Size(75, 23);
            this.btn_selectByRef.TabIndex = 2;
            this.btn_selectByRef.Text = "Select by ref";
            this.btn_selectByRef.UseVisualStyleBackColor = true;
            this.btn_selectByRef.Click += new System.EventHandler(this.btn_selectByRef_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_selectByRef);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_selectAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectAll;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_selectByRef;
    }
}

