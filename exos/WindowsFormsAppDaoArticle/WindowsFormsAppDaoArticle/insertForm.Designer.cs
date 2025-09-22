namespace WindowsFormsAppDaoArticle
{
    partial class insertForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.nud_ref = new System.Windows.Forms.NumericUpDown();
            this.nud_prix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ref)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(366, 152);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(100, 20);
            this.txt_marque.TabIndex = 2;
            this.txt_marque.Text = "marque";
            // 
            // nud_ref
            // 
            this.nud_ref.Location = new System.Drawing.Point(366, 104);
            this.nud_ref.Name = "nud_ref";
            this.nud_ref.Size = new System.Drawing.Size(120, 20);
            this.nud_ref.TabIndex = 4;
            // 
            // nud_prix
            // 
            this.nud_prix.Location = new System.Drawing.Point(366, 211);
            this.nud_prix.Name = "nud_prix";
            this.nud_prix.Size = new System.Drawing.Size(120, 20);
            this.nud_prix.TabIndex = 5;
            // 
            // insertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_prix);
            this.Controls.Add(this.nud_ref);
            this.Controls.Add(this.txt_marque);
            this.Controls.Add(this.button1);
            this.Name = "insertForm";
            this.Text = "insertForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_ref)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.NumericUpDown nud_ref;
        private System.Windows.Forms.NumericUpDown nud_prix;
    }
}