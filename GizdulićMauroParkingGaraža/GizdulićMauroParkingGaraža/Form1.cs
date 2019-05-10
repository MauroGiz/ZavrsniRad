using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GizdulićMauroParkingGaraža.OGarazi;
using GizdulićMauroParkingGaraža.Informacije;

namespace GizdulićMauroParkingGaraža
{
    public partial class FormParkingGaraza : Form
    {
        public FormParkingGaraza()
        {
            InitializeComponent();
        }

        private void buttonUlaz_Click(object sender, EventArgs e)
        {

             // Otvaranje nove forme Ulaz
             Ulaz ulaz = new Ulaz();
             ulaz.ShowDialog();
        }

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            // Otvaranje nove forme Izlaz
            Izlaz izlaz = new Izlaz();
            izlaz.ShowDialog();
        }

        private void FormParkingGaraza_Load(object sender, EventArgs e)
        {
            // Mijenjanje izgleda forme pomocu koda
            timerVrijeme.Start();
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void labelNaslov_Click(object sender, EventArgs e)
        {
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otvaranje forme samo za Administratora
            PotvrdaAdministratora potvrda = new PotvrdaAdministratora();
            potvrda.ShowDialog();
        }

        private void timerVrijeme_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerVrijeme.Start();
        }

        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ONama oNama = new ONama();
            oNama.ShowDialog();
        }

        private void uvjetiPružanjaUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UPU upu = new UPU();
            upu.ShowDialog();
        }

        private void radnoVrijemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadnoVrijeme radnoVrijeme = new RadnoVrijeme();
            radnoVrijeme.ShowDialog();
        }

        private void izgledMapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzgledMape izgledMape = new IzgledMape();
            izgledMape.ShowDialog();
        }

        private void cijeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cijene cijene = new Cijene();
            cijene.ShowDialog();
        }
    }
}
