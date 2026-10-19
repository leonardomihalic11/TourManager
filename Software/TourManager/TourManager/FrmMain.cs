using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            FrmRezervacije frmRezervacije = new FrmRezervacije();
            frmRezervacije.ShowDialog();
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvara se statistika popunjenosti tura.", "TourManager",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTure_Click(object sender, EventArgs e)
        {
            FrmTure frmTure = new FrmTure();
            frmTure.ShowDialog();
        }

        private void btnPrihodi_Click(object sender, EventArgs e)
        {
            FrmIzvjestajPrihoda frmIzvjestajPrihoda = new FrmIzvjestajPrihoda();
            frmIzvjestajPrihoda.ShowDialog();

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
