namespace TourManager
{
    partial class FrmTure
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
            this.dgvTure = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNovaTura = new System.Windows.Forms.Button();
            this.btnIzmijeniTuru = new System.Windows.Forms.Button();
            this.btnObrisiTuru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTure)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTure
            // 
            this.dgvTure.AllowUserToAddRows = false;
            this.dgvTure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTure.Location = new System.Drawing.Point(44, 51);
            this.dgvTure.MultiSelect = false;
            this.dgvTure.Name = "dgvTure";
            this.dgvTure.ReadOnly = true;
            this.dgvTure.RowHeadersWidth = 51;
            this.dgvTure.RowTemplate.Height = 24;
            this.dgvTure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTure.Size = new System.Drawing.Size(782, 390);
            this.dgvTure.TabIndex = 0;
            this.dgvTure.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTure_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži turu:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(629, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(735, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNovaTura
            // 
            this.btnNovaTura.Location = new System.Drawing.Point(80, 17);
            this.btnNovaTura.Name = "btnNovaTura";
            this.btnNovaTura.Size = new System.Drawing.Size(75, 23);
            this.btnNovaTura.TabIndex = 4;
            this.btnNovaTura.Text = "Nova tura";
            this.btnNovaTura.UseVisualStyleBackColor = true;
            this.btnNovaTura.Click += new System.EventHandler(this.btnNovaTura_Click_1);
            // 
            // btnIzmijeniTuru
            // 
            this.btnIzmijeniTuru.Location = new System.Drawing.Point(172, 17);
            this.btnIzmijeniTuru.Name = "btnIzmijeniTuru";
            this.btnIzmijeniTuru.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeniTuru.TabIndex = 5;
            this.btnIzmijeniTuru.Text = "Izmijeni";
            this.btnIzmijeniTuru.UseVisualStyleBackColor = true;
            this.btnIzmijeniTuru.Click += new System.EventHandler(this.btnIzmijeniTuru_Click);
            // 
            // btnObrisiTuru
            // 
            this.btnObrisiTuru.Location = new System.Drawing.Point(276, 17);
            this.btnObrisiTuru.Name = "btnObrisiTuru";
            this.btnObrisiTuru.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTuru.TabIndex = 6;
            this.btnObrisiTuru.Text = "Obriši";
            this.btnObrisiTuru.UseVisualStyleBackColor = true;
            this.btnObrisiTuru.Click += new System.EventHandler(this.btnObrisiTuru_Click);
            // 
            // FrmTure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.btnObrisiTuru);
            this.Controls.Add(this.btnIzmijeniTuru);
            this.Controls.Add(this.btnNovaTura);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTure);
            this.Name = "FrmTure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled turističkih tura";
            this.Load += new System.EventHandler(this.FrmTure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNovaTura;
        private System.Windows.Forms.Button btnIzmijeniTuru;
        private System.Windows.Forms.Button btnObrisiTuru;
    }
}