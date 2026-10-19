namespace TourManager
{
    partial class FrmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnTure = new System.Windows.Forms.Button();
            this.btnPrihodi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(188, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TourManager - Početni zaslon";
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezervacije.Location = new System.Drawing.Point(518, 110);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(200, 50);
            this.btnRezervacije.TabIndex = 2;
            this.btnRezervacije.Text = "Rezervacije";
            this.btnRezervacije.UseVisualStyleBackColor = true;
            this.btnRezervacije.Click += new System.EventHandler(this.btnRezervacije_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatistika.Location = new System.Drawing.Point(518, 251);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(200, 50);
            this.btnStatistika.TabIndex = 4;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(295, 358);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(200, 50);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnTure
            // 
            this.btnTure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTure.Location = new System.Drawing.Point(79, 110);
            this.btnTure.Name = "btnTure";
            this.btnTure.Size = new System.Drawing.Size(200, 50);
            this.btnTure.TabIndex = 6;
            this.btnTure.Text = "Turističke ture";
            this.btnTure.UseVisualStyleBackColor = true;
            this.btnTure.Click += new System.EventHandler(this.btnTure_Click);
            // 
            // btnPrihodi
            // 
            this.btnPrihodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrihodi.Location = new System.Drawing.Point(79, 253);
            this.btnPrihodi.Name = "btnPrihodi";
            this.btnPrihodi.Size = new System.Drawing.Size(200, 50);
            this.btnPrihodi.TabIndex = 7;
            this.btnPrihodi.Text = "Prihodi";
            this.btnPrihodi.UseVisualStyleBackColor = true;
            this.btnPrihodi.Click += new System.EventHandler(this.btnPrihodi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrihodi);
            this.Controls.Add(this.btnTure);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnRezervacije);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TourManager - Početni zaslon";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnTure;
        private System.Windows.Forms.Button btnPrihodi;
    }
}