using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmUnosRezervacije : Form
    {
        private TuristickaTura odabranaTura;

        public FrmUnosRezervacije()
        {
            InitializeComponent();
            UcitajTure();
        }

        private void FrmUnosRezervacije_Load(object sender, EventArgs e)
        {
            UcitajTure();
        }

        private void UcitajTure()
        {
            List<TuristickaTura> ture = TuraRepository.DohvatiTure();

            cmbTure.DataSource = ture;
            cmbTure.DisplayMember = "NazivTure";
            cmbTure.ValueMember = "TuraId";
            cmbTure.SelectedIndex = -1;
        }

        private void cmbTure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTure.SelectedValue != null && int.TryParse(cmbTure.SelectedValue.ToString(), out int turaId))
            {
                odabranaTura = TuraRepository.DohvatiTuru(turaId);

                if (odabranaTura != null)
                {
                    int brojSlobodnihMjesta = RezervacijaRepository.IzracunajBrojSlobodnihMjesta(
                        odabranaTura.TuraId,
                        odabranaTura.MaksimalanBrojSudionika
                    );

                    txtSlobodnaMjesta.Text = brojSlobodnihMjesta.ToString();
                }
            }
            else
            {
                txtSlobodnaMjesta.Text = "";
            }
        }

        private void btnSpremiRezervaciju_Click(object sender, EventArgs e)
        {
            if (cmbTure.SelectedIndex == -1 || odabranaTura == null)
            {
                MessageBox.Show("Nije odabrana turistička tura!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtImePrezime.Text == "" || txtKontakt.Text == "" || txtBrojOsoba.Text == "")
            {
                MessageBox.Show("Svi podaci o rezervaciji moraju biti uneseni!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBrojOsoba.Text, out int brojOsoba))
            {
                MessageBox.Show("Broj prijavljenih osoba mora biti broj!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (brojOsoba <= 0)
            {
                MessageBox.Show("Broj prijavljenih osoba mora biti veći od 0!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int brojSlobodnihMjesta = int.Parse(txtSlobodnaMjesta.Text);

            if (brojOsoba > brojSlobodnihMjesta)
            {
                MessageBox.Show("Broj prijavljenih osoba veći je od broja slobodnih mjesta!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int klijentId = KlijentRepository.SpremiKlijenta(txtImePrezime.Text, txtKontakt.Text);
            decimal ukupanIznos = brojOsoba * odabranaTura.CijenaPoOsobi;

            // Privremeno koristim korisnika s ID-em 2 jer je to zaposlenik iz testnih podataka.
            int korisnikId = 2;

            bool spremljeno = RezervacijaRepository.SpremiRezervaciju(
                odabranaTura.TuraId,
                klijentId,
                korisnikId,
                brojOsoba,
                ukupanIznos
            );

            if (spremljeno)
            {
                MessageBox.Show("Rezervacija je uspješno spremljena!", "TourManager",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtImePrezime.Clear();
                txtKontakt.Clear();
                txtBrojOsoba.Clear();

                int noviBrojSlobodnihMjesta = RezervacijaRepository.IzracunajBrojSlobodnihMjesta(
                    odabranaTura.TuraId,
                    odabranaTura.MaksimalanBrojSudionika
                );

                txtSlobodnaMjesta.Text = noviBrojSlobodnihMjesta.ToString();
            }
            else
            {
                MessageBox.Show("Rezervacija nije spremljena.", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremiRezervaciju_Click_1(object sender, EventArgs e)
        {
            btnSpremiRezervaciju_Click(sender, e);
        }
    }
}