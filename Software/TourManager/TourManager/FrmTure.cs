using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmTure : Form
    {
        public FrmTure()
        {
            InitializeComponent();
        }

        private void FrmTure_Load(object sender, EventArgs e)
        {
            PrikaziTure();
        }

        private void PrikaziTure()
        {
            List<TuristickaTura> ture = TuraRepository.DohvatiTure();
            dgvTure.DataSource = ture;

            if (dgvTure.Columns["TuraId"] != null)
                dgvTure.Columns["TuraId"].HeaderText = "ID";

            if (dgvTure.Columns["NazivTure"] != null)
                dgvTure.Columns["NazivTure"].HeaderText = "Naziv ture";

            if (dgvTure.Columns["DatumVrijeme"] != null)
                dgvTure.Columns["DatumVrijeme"].HeaderText = "Datum i vrijeme";

            if (dgvTure.Columns["Trajanje"] != null)
                dgvTure.Columns["Trajanje"].HeaderText = "Trajanje";

            if (dgvTure.Columns["CijenaPoOsobi"] != null)
                dgvTure.Columns["CijenaPoOsobi"].HeaderText = "Cijena po osobi";

            if (dgvTure.Columns["MaksimalanBrojSudionika"] != null)
                dgvTure.Columns["MaksimalanBrojSudionika"].HeaderText = "Maks. broj sudionika";
        }
        private void dgvTure_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                PrikaziTure();
            }
            else
            {
                dgvTure.DataSource = TuraRepository.PretraziTure(txtSearch.Text);
            }
        }
        private void btnNovaTura_Click(object sender, EventArgs e)
        {
            FrmNovaTura frmNovaTura = new FrmNovaTura();

            if (frmNovaTura.ShowDialog() == DialogResult.OK)
            {
                PrikaziTure();
            }
        }

        private void btnNovaTura_Click_1(object sender, EventArgs e)
        {
            FrmNovaTura frmNovaTura = new FrmNovaTura();

            if (frmNovaTura.ShowDialog() == DialogResult.OK)
            {
                PrikaziTure();
            }
        }
        private int DohvatiOdabraniIdTure()
        {
            if (dgvTure.CurrentRow == null)
            {
                return -1;
            }

            return int.Parse(dgvTure.CurrentRow.Cells["TuraId"].Value.ToString());
        }

        private void btnObrisiTuru_Click(object sender, EventArgs e)
        {
            int turaId = DohvatiOdabraniIdTure();

            if (turaId == -1)
            {
                MessageBox.Show("Nije odabrana turistička tura!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Jeste li sigurni da želite obrisati odabranu turističku turu?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rezultat == DialogResult.Yes)
            {
                bool obrisano = TuraRepository.ObrisiTuru(turaId);

                if (obrisano)
                {
                    MessageBox.Show("Turistička tura je uspješno obrisana!", "TourManager",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PrikaziTure();
                }
                else
                {
                    MessageBox.Show("Turistička tura nije obrisana. Možda postoje rezervacije za tu turu.", "Problem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmijeniTuru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Izmjena turističke ture bit će dodana u sljedećoj doradi.", "TourManager",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}