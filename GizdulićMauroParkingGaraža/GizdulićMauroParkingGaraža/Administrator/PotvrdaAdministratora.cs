using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizdulićMauroParkingGaraža
{
    public partial class PotvrdaAdministratora : Form
    {
        public PotvrdaAdministratora()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            string administrator = "MauroGiz";
            string sifra = "parking123";

            if(textBoxAdministrator.Text == administrator && textBoxSifra.Text == sifra)
            {
                // Otvaranje administratora
                Administrator admin = new Administrator();  
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                textBoxAdministrator.ResetText();
                textBoxSifra.ResetText();
                MessageBox.Show("Krivo ste upisali korisničko ime ili lozinku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void buttonIzadi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
