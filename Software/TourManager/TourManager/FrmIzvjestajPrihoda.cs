using System;
using System.Windows.Forms;
using System.Collections.Generic;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmIzvjestajPrihoda : Form
    {
        public FrmIzvjestajPrihoda()
        {
            InitializeComponent();
        }

        private void FrmIzvjestajPrihoda_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerirajIzvjestaj_Click(object sender, EventArgs e)
        {
            if (dtpPocetniDatum.Value.Date > dtpZavrsniDatum.Value.Date)
            {
                MessageBox.Show("Početni datum ne smije biti nakon završnog datuma!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Rezervacija> rezervacije = RezervacijaRepository.DohvatiRezervacijePoRazdoblju(
                dtpPocetniDatum.Value.Date,
                dtpZavrsniDatum.Value.Date
            );

            dgvIzvjestaj.DataSource = rezervacije;

            decimal ukupanPrihod = 0;

            foreach (Rezervacija rezervacija in rezervacije)
            {
                ukupanPrihod += rezervacija.UkupanIznos;
            }

            lblUkupanPrihod.Text = "Ukupan prihod: " + ukupanPrihod.ToString("0.00") + " €";

            if (rezervacije.Count == 0)
            {
                MessageBox.Show("Za odabrano razdoblje nema evidentiranih rezervacija.", "Obavijest",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerirajIzvjestaj_Click_1(object sender, EventArgs e)
        {
            btnGenerirajIzvjestaj_Click(sender, e);
        }
    }
}