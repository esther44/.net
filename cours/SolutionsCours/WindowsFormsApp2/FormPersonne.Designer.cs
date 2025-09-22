namespace WindowsFormsApp2
{
    partial class FormPersonne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAppuyer = new System.Windows.Forms.Button();
            this.labelRecap = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAppuyer
            // 
            this.buttonAppuyer.Location = new System.Drawing.Point(345, 282);
            this.buttonAppuyer.Name = "buttonAppuyer";
            this.buttonAppuyer.Size = new System.Drawing.Size(75, 23);
            this.buttonAppuyer.TabIndex = 0;
            this.buttonAppuyer.Text = "Appuyer";
            this.buttonAppuyer.UseVisualStyleBackColor = true;
            this.buttonAppuyer.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRecap
            // 
            this.labelRecap.AutoSize = true;
            this.labelRecap.Location = new System.Drawing.Point(345, 149);
            this.labelRecap.Name = "labelRecap";
            this.labelRecap.Size = new System.Drawing.Size(30, 13);
            this.labelRecap.TabIndex = 2;
            this.labelRecap.Text = "NAN";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(345, 194);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(345, 221);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(345, 248);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // FormPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelRecap);
            this.Controls.Add(this.buttonAppuyer);
            this.Name = "FormPersonne";
            this.Text = "FormPersonne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAppuyer;
        private System.Windows.Forms.Label labelRecap;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}