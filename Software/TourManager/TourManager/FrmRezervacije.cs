using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmRezervacije : Form
    {
        public FrmRezervacije()
        {
            InitializeComponent();
            PrikaziRezervacije();
        }

        private void FrmRezervacije_Load(object sender, EventArgs e)
        {
            PrikaziRezervacije();
        }

        private void PrikaziRezervacije()
        {
            List<Rezervacija> rezervacije = RezervacijaRepository.DohvatiRezervacije();
            dgvRezervacije.DataSource = rezervacije;

            if (dgvRezervacije.Columns["RezervacijaId"] != null)
                dgvRezervacije.Columns["RezervacijaId"].HeaderText = "ID";

            if (dgvRezervacije.Columns["TuraId"] != null)
                dgvRezervacije.Columns["TuraId"].HeaderText = "ID ture";

            if (dgvRezervacije.Columns["KlijentId"] != null)
                dgvRezervacije.Columns["KlijentId"].HeaderText = "ID klijenta";

            if (dgvRezervacije.Columns["KorisnikId"] != null)
                dgvRezervacije.Columns["KorisnikId"].HeaderText = "ID korisnika";

            if (dgvRezervacije.Columns["BrojPrijavljenihOsoba"] != null)
                dgvRezervacije.Columns["BrojPrijavljenihOsoba"].HeaderText = "Broj osoba";

            if (dgvRezervacije.Columns["DatumRezervacije"] != null)
                dgvRezervacije.Columns["DatumRezervacije"].HeaderText = "Datum rezervacije";

            if (dgvRezervacije.Columns["UkupanIznos"] != null)
                dgvRezervacije.Columns["UkupanIznos"].HeaderText = "Ukupan iznos";
        }
        private int DohvatiOdabraniIdRezervacije()
        {
            if (dgvRezervacije.CurrentRow == null)
            {
                return -1;
            }

            return int.Parse(dgvRezervacije.CurrentRow.Cells["RezervacijaId"].Value.ToString());
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            int rezervacijaId = DohvatiOdabraniIdRezervacije();

            if (rezervacijaId == -1)
            {
                MessageBox.Show("Nije odabrana rezervacija!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBrojOsoba.Text, out int brojOsoba))
            {
                MessageBox.Show("Broj osoba mora biti broj!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (brojOsoba <= 0)
            {
                MessageBox.Show("Broj osoba mora biti veći od 0!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int turaId = int.Parse(dgvRezervacije.CurrentRow.Cells["TuraId"].Value.ToString());

            var tura = TuraRepository.DohvatiTuru(turaId);
            decimal ukupanIznos = brojOsoba * tura.CijenaPoOsobi;

            bool uspjesno = RezervacijaRepository.AzurirajRezervaciju(rezervacijaId, brojOsoba, ukupanIznos);

            if (uspjesno)
            {
                MessageBox.Show("Rezervacija je uspješno ažurirana!", "TourManager",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBrojOsoba.Clear();
                PrikaziRezervacije();
            }
            else
            {
                MessageBox.Show("Rezervacija nije ažurirana.", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int rezervacijaId = DohvatiOdabraniIdRezervacije();

            if (rezervacijaId == -1)
            {
                MessageBox.Show("Nije odabrana rezervacija!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Jeste li sigurni da želite obrisati odabranu rezervaciju?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                bool obrisano = RezervacijaRepository.ObrisiRezervaciju(rezervacijaId);

                if (obrisano)
                {
                    MessageBox.Show("Rezervacija je uspješno obrisana!", "TourManager",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBrojOsoba.Clear();
                    PrikaziRezervacije();
                }
                else
                {
                    MessageBox.Show("Rezervacija nije obrisana.", "Problem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            FrmUnosRezervacije frmUnosRezervacije = new FrmUnosRezervacije();
            frmUnosRezervacije.ShowDialog();

            PrikaziRezervacije();
        }
    }
}