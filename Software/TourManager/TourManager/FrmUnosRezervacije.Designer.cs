namespace TourManager
{
    partial class FrmUnosRezervacije
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremiRezervaciju = new System.Windows.Forms.Button();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtSlobodnaMjesta = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtBrojOsoba = new System.Windows.Forms.TextBox();
            this.cmbTure = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabir ture:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj slobodnih mjesta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime i prezime klijenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kontak klijenta:";
            // 
            // btnSpremiRezervaciju
            // 
            this.btnSpremiRezervaciju.Location = new System.Drawing.Point(269, 378);
            this.btnSpremiRezervaciju.Name = "btnSpremiRezervaciju";
            this.btnSpremiRezervaciju.Size = new System.Drawing.Size(161, 51);
            this.btnSpremiRezervaciju.TabIndex = 4;
            this.btnSpremiRezervaciju.Text = "Spremi rezervaciju";
            this.btnSpremiRezervaciju.UseVisualStyleBackColor = true;
            this.btnSpremiRezervaciju.Click += new System.EventHandler(this.btnSpremiRezervaciju_Click_1);
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(389, 187);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(100, 22);
            this.txtImePrezime.TabIndex = 5;
            // 
            // txtSlobodnaMjesta
            // 
            this.txtSlobodnaMjesta.Location = new System.Drawing.Point(389, 123);
            this.txtSlobodnaMjesta.Name = "txtSlobodnaMjesta";
            this.txtSlobodnaMjesta.ReadOnly = true;
            this.txtSlobodnaMjesta.Size = new System.Drawing.Size(100, 22);
            this.txtSlobodnaMjesta.TabIndex = 6;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(389, 244);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 22);
            this.txtKontakt.TabIndex = 7;
            // 
            // txtBrojOsoba
            // 
            this.txtBrojOsoba.Location = new System.Drawing.Point(389, 307);
            this.txtBrojOsoba.Name = "txtBrojOsoba";
            this.txtBrojOsoba.Size = new System.Drawing.Size(100, 22);
            this.txtBrojOsoba.TabIndex = 8;
            // 
            // cmbTure
            // 
            this.cmbTure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTure.FormattingEnabled = true;
            this.cmbTure.Location = new System.Drawing.Point(389, 73);
            this.cmbTure.Name = "cmbTure";
            this.cmbTure.Size = new System.Drawing.Size(121, 24);
            this.cmbTure.TabIndex = 9;
            this.cmbTure.SelectedIndexChanged += new System.EventHandler(this.cmbTure_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj prijavljenih osoba:";
            // 
            // FrmUnosRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTure);
            this.Controls.Add(this.txtBrojOsoba);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtSlobodnaMjesta);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.btnSpremiRezervaciju);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosRezervacije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos rezervacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremiRezervaciju;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtSlobodnaMjesta;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtBrojOsoba;
        private System.Windows.Forms.ComboBox cmbTure;
        private System.Windows.Forms.Label label5;
    }
}