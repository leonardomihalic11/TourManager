using System;
using System.Windows.Forms;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmNovaTura : Form
    {
        public FrmNovaTura()
        {
            InitializeComponent();
        }

        private void btnSpremiTuru_Click(object sender, EventArgs e)
        {
            if (txtNazivTure.Text == "" || txtTrajanje.Text == "" ||
                txtCijenaPoOsobi.Text == "" || txtMaksBrojSudionika.Text == "")
            {
                MessageBox.Show("Svi podaci o turi moraju biti uneseni!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtCijenaPoOsobi.Text, out decimal cijenaPoOsobi))
            {
                MessageBox.Show("Cijena po osobi mora biti broj!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtMaksBrojSudionika.Text, out int maksimalanBrojSudionika))
            {
                MessageBox.Show("Maksimalan broj sudionika mora biti broj!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cijenaPoOsobi <= 0 || maksimalanBrojSudionika <= 0)
            {
                MessageBox.Show("Cijena i maksimalan broj sudionika moraju biti veći od 0!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TuristickaTura tura = new TuristickaTura
            {
                NazivTure = txtNazivTure.Text,
                DatumVrijeme = dtpDatumVrijeme.Value,
                Trajanje = txtTrajanje.Text,
                CijenaPoOsobi = cijenaPoOsobi,
                MaksimalanBrojSudionika = maksimalanBrojSudionika
            };

            bool spremljeno = TuraRepository.DodajTuru(tura);

            if (spremljeno)
            {
                MessageBox.Show("Turistička tura je uspješno spremljena!", "TourManager",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Turistička tura nije spremljena.", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSpremiTuru_Click_1(object sender, EventArgs e)
        {
            btnSpremiTuru_Click(sender, e);
        }
    }
}