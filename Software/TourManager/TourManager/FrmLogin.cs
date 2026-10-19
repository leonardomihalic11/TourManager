using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourManager.Models;
using TourManager.Repositories;

namespace TourManager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Korisnik korisnik = KorisnikRepository.DohvatiKorisnika(txtUsername.Text);

                if (korisnik != null && korisnik.ProvjeriLozinku(txtPassword.Text))
                {
                    FrmMain frmMain = new FrmMain();
                    Hide();
                    frmMain.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Problem",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
