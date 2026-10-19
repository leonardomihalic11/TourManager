namespace TourManager
{
    partial class FrmNovaTura
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivTure = new System.Windows.Forms.TextBox();
            this.dtpDatumVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtCijenaPoOsobi = new System.Windows.Forms.TextBox();
            this.txtMaksBrojSudionika = new System.Windows.Forms.TextBox();
            this.btnSpremiTuru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv ture:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vrijeme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena po osobi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maksimalan broj sudionika:";
            // 
            // txtNazivTure
            // 
            this.txtNazivTure.Location = new System.Drawing.Point(327, 51);
            this.txtNazivTure.Name = "txtNazivTure";
            this.txtNazivTure.Size = new System.Drawing.Size(100, 22);
            this.txtNazivTure.TabIndex = 5;
            // 
            // dtpDatumVrijeme
            // 
            this.dtpDatumVrijeme.Location = new System.Drawing.Point(327, 109);
            this.dtpDatumVrijeme.Name = "dtpDatumVrijeme";
            this.dtpDatumVrijeme.Size = new System.Drawing.Size(149, 22);
            this.dtpDatumVrijeme.TabIndex = 6;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(327, 167);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(100, 22);
            this.txtTrajanje.TabIndex = 7;
            // 
            // txtCijenaPoOsobi
            // 
            this.txtCijenaPoOsobi.Location = new System.Drawing.Point(327, 224);
            this.txtCijenaPoOsobi.Name = "txtCijenaPoOsobi";
            this.txtCijenaPoOsobi.Size = new System.Drawing.Size(100, 22);
            this.txtCijenaPoOsobi.TabIndex = 8;
            // 
            // txtMaksBrojSudionika
            // 
            this.txtMaksBrojSudionika.Location = new System.Drawing.Point(327, 287);
            this.txtMaksBrojSudionika.Name = "txtMaksBrojSudionika";
            this.txtMaksBrojSudionika.Size = new System.Drawing.Size(100, 22);
            this.txtMaksBrojSudionika.TabIndex = 9;
            // 
            // btnSpremiTuru
            // 
            this.btnSpremiTuru.Location = new System.Drawing.Point(196, 352);
            this.btnSpremiTuru.Name = "btnSpremiTuru";
            this.btnSpremiTuru.Size = new System.Drawing.Size(129, 23);
            this.btnSpremiTuru.TabIndex = 10;
            this.btnSpremiTuru.Text = "Spremi turu";
            this.btnSpremiTuru.UseVisualStyleBackColor = true;
            this.btnSpremiTuru.Click += new System.EventHandler(this.btnSpremiTuru_Click_1);
            // 
            // FrmNovaTura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.btnSpremiTuru);
            this.Controls.Add(this.txtMaksBrojSudionika);
            this.Controls.Add(this.txtCijenaPoOsobi);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.dtpDatumVrijeme);
            this.Controls.Add(this.txtNazivTure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNovaTura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos turističke ture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivTure;
        private System.Windows.Forms.DateTimePicker dtpDatumVrijeme;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtCijenaPoOsobi;
        private System.Windows.Forms.TextBox txtMaksBrojSudionika;
        private System.Windows.Forms.Button btnSpremiTuru;
    }
}