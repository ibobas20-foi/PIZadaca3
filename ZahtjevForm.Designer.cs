namespace PIZadaca3
{
    partial class ZahtjevForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPodnositelj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPredmetNabave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProjekt = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podnositelj:";
            // 
            // tbxPodnositelj
            // 
            this.tbxPodnositelj.Location = new System.Drawing.Point(104, 45);
            this.tbxPodnositelj.Name = "tbxPodnositelj";
            this.tbxPodnositelj.Size = new System.Drawing.Size(252, 20);
            this.tbxPodnositelj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opis predmeta nabave:";
            // 
            // tbxPredmetNabave
            // 
            this.tbxPredmetNabave.Location = new System.Drawing.Point(160, 82);
            this.tbxPredmetNabave.Multiline = true;
            this.tbxPredmetNabave.Name = "tbxPredmetNabave";
            this.tbxPredmetNabave.Size = new System.Drawing.Size(196, 69);
            this.tbxPredmetNabave.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Projekt:";
            // 
            // tbxProjekt
            // 
            this.tbxProjekt.Location = new System.Drawing.Point(104, 169);
            this.tbxProjekt.Name = "tbxProjekt";
            this.tbxProjekt.Size = new System.Drawing.Size(252, 20);
            this.tbxProjekt.TabIndex = 1;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(281, 265);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(200, 265);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ZahtjevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 325);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbxPredmetNabave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxProjekt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPodnositelj);
            this.Controls.Add(this.label1);
            this.Name = "ZahtjevForm";
            this.Text = "Zahtjev";
            this.Load += new System.EventHandler(this.ZahtjevForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPodnositelj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPredmetNabave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxProjekt;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}