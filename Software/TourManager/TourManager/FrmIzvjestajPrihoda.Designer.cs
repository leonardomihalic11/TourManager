namespace TourManager
{
    partial class FrmIzvjestajPrihoda
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
            this.dtpPocetniDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpZavrsniDatum = new System.Windows.Forms.DateTimePicker();
            this.btnGenerirajIzvjestaj = new System.Windows.Forms.Button();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.lblUkupanPrihod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Početni datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Završni datum:";
            // 
            // dtpPocetniDatum
            // 
            this.dtpPocetniDatum.Location = new System.Drawing.Point(189, 37);
            this.dtpPocetniDatum.Name = "dtpPocetniDatum";
            this.dtpPocetniDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetniDatum.TabIndex = 2;
            // 
            // dtpZavrsniDatum
            // 
            this.dtpZavrsniDatum.Location = new System.Drawing.Point(189, 107);
            this.dtpZavrsniDatum.Name = "dtpZavrsniDatum";
            this.dtpZavrsniDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpZavrsniDatum.TabIndex = 3;
            // 
            // btnGenerirajIzvjestaj
            // 
            this.btnGenerirajIzvjestaj.Location = new System.Drawing.Point(454, 60);
            this.btnGenerirajIzvjestaj.Name = "btnGenerirajIzvjestaj";
            this.btnGenerirajIzvjestaj.Size = new System.Drawing.Size(147, 38);
            this.btnGenerirajIzvjestaj.TabIndex = 4;
            this.btnGenerirajIzvjestaj.Text = "Generiraj izvještaj";
            this.btnGenerirajIzvjestaj.UseVisualStyleBackColor = true;
            this.btnGenerirajIzvjestaj.Click += new System.EventHandler(this.btnGenerirajIzvjestaj_Click_1);
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(95, 182);
            this.dgvIzvjestaj.MultiSelect = false;
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.RowHeadersWidth = 51;
            this.dgvIzvjestaj.RowTemplate.Height = 24;
            this.dgvIzvjestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(511, 206);
            this.dgvIzvjestaj.TabIndex = 5;
            // 
            // lblUkupanPrihod
            // 
            this.lblUkupanPrihod.AutoSize = true;
            this.lblUkupanPrihod.Location = new System.Drawing.Point(284, 411);
            this.lblUkupanPrihod.Name = "lblUkupanPrihod";
            this.lblUkupanPrihod.Size = new System.Drawing.Size(132, 16);
            this.lblUkupanPrihod.TabIndex = 6;
            this.lblUkupanPrihod.Text = "Ukupan prihod: 0,00€";
            // 
            // FrmIzvjestajPrihoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblUkupanPrihod);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Controls.Add(this.btnGenerirajIzvjestaj);
            this.Controls.Add(this.dtpZavrsniDatum);
            this.Controls.Add(this.dtpPocetniDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIzvjestajPrihoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj o ukupnim prihodima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPocetniDatum;
        private System.Windows.Forms.DateTimePicker dtpZavrsniDatum;
        private System.Windows.Forms.Button btnGenerirajIzvjestaj;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.Label lblUkupanPrihod;
    }
}