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

namespace GizdulićMauroParkingGaraža
{
    public partial class Izlaz : Form
    {

        MySqlCommand cmd;
        MySqlDataReader read;
        double cijena, cijenaUnosa, razlika = 0;

        public Izlaz()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            //*************************** SPAJANJE NA BAZU *******************************
            MySqlConnection connection;
            string server = "portmap.io";
            string port = "61974";
            string database = "parking_garaza";
            string user = "test";
            string password = "123";

            string connectionString =
                "SERVER=" + server + ";" +
                "PORT=" + port + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + user + ";" +
                "PASSWORD=" + password + ";" +
                "Convert Zero DateTime=True;"
                + "Allow Zero DateTime=no;";

            connection = new MySqlConnection(connectionString);

            // ************************ ISPISIVANJE PODATAKA **************************
            connection.Open();
            String usporedba = "SELECT * FROM status WHERE ID = " + int.Parse(textBoxKod.Text);
            cmd = new MySqlCommand(usporedba, connection);
            read = cmd.ExecuteReader();


            // ********************* POCETAK METODA ZA USPOREDIVANJE VREMENA ****************** 
            TimeSpan prviSat = new TimeSpan(01, 0, 0);
            TimeSpan drugiSat = new TimeSpan(02, 0, 0);
            TimeSpan treciSat = new TimeSpan(03, 0, 0);
            TimeSpan cetvrtiSat = new TimeSpan(04, 0, 0);
            TimeSpan petiSat = new TimeSpan(05, 0, 0);
            TimeSpan sestiSat = new TimeSpan(06, 0, 0);
            TimeSpan sedmiSat = new TimeSpan(07, 0, 0);
            TimeSpan osmiSat = new TimeSpan(08, 0, 0);
            TimeSpan devetiSat = new TimeSpan(09, 0, 0);
            // ********************* ZAVRSETAK METODA ZA USPOREDIVANJE VREMENA ****************** 


            DateTime vrijemeUlaska = new DateTime();
            DateTime vrijemeSad = DateTime.Now;
            DateTime izracun = new DateTime();
            TimeSpan timeSpan = new TimeSpan();
         //   double cijena, cijenaUnosa, razlika = 0;

            if(read.Read())
            {
                vrijemeUlaska = Convert.ToDateTime(read["vrijeme_ulaska"]);
                timeSpan = vrijemeSad - vrijemeUlaska;
             /*   richTextBoxIzlaz.Text = "*************\n"
                    + "ID = " + read["ID"].ToString() + "\n"
                    + "TABLICA = " + read["tablica"].ToString() + "\n"
                    + "VRIJEME ULASKA = " + read["vrijeme_ulaska"].ToString() + "\n"
                    + "VRIJEME PROVEDENO NA PARKINGU: " + timeSpan.ToString(@"%d") + " dana, "
                    + timeSpan.ToString(@"hh\:mm\:ss") + "\n"; */

                string izlaz = "Parking garaža - Mauro\n" 
                    + "Zvonimirova 16, 51000 Rijeka\n"
                    + "Datum: " + vrijemeSad + "\n"
                    + "ID = " + read["ID"].ToString() + "\n"
                    + "TABLICA = " + read["tablica"].ToString() + "\n"
                    + "VRIJEME ULASKA = " + read["vrijeme_ulaska"].ToString() + "\n"
                    + "VRIJEME SAD = " + vrijemeSad + "\n"
                    + "VRIJEME PROVEDENO NA PARKINGU: " + timeSpan.ToString(@"%d") + " dana, "
                    + timeSpan.ToString(@"hh\:mm\:ss") + "\n";
                buttonCijena.Enabled = true;
                textBoxUnosCijene.Enabled = true;
             //   cijenaUnosa = Convert.ToDouble(textBoxUnosCijene.Text);

                if(timeSpan <= prviSat)
                {
                    cijena = 0;
                    string izlaz2 = "Proveli ste manje od sat vremena! \n" + "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if(timeSpan > prviSat && timeSpan < drugiSat)
                {
                    cijena = 5;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                    
                }

                else if (timeSpan >= drugiSat && timeSpan < treciSat)
                {
                    cijena = 10;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= treciSat && timeSpan < cetvrtiSat)
                {
                    cijena = 15;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= cetvrtiSat && timeSpan < petiSat)
                {
                    cijena = 20;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= petiSat && timeSpan < sestiSat)
                {
                    cijena = 25;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= sestiSat && timeSpan < sedmiSat)
                {
                    cijena = 30;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= sedmiSat && timeSpan < osmiSat)
                {
                    cijena = 35;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= osmiSat && timeSpan < devetiSat)
                {
                    cijena = 40;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }

                else if (timeSpan >= devetiSat)
                {
                    cijena = 60;
                    string izlaz2 = "Vaša cijena iznosi: " + cijena + " kn\n";
                    richTextBoxIzlaz.Text = izlaz + izlaz2;
                }
            }
            connection.Close();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocumentOut_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxIzlaz.Text, new Font("Arial",12, FontStyle.Regular), Brushes.Black, new Point(194,229));
        }

        private void buttonCijena_Click(object sender, EventArgs e)
        {
            cijenaUnosa = Convert.ToDouble(textBoxUnosCijene.Text);
            richTextBoxIzlaz.Text += "Cijena unosa: " + cijenaUnosa + "\n";
            razlika = cijenaUnosa - cijena;
            if(razlika >= 0)
            {
                textBoxUnosCijene.Enabled = false;
                richTextBoxIzlaz.Text += "Vraćeno: " + razlika;
                // Printanje dokumenta
                printPreviewDialogOut.Document = printDocumentOut;
                printPreviewDialogOut.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste dovoljno uplatili! Molimo vas da uplatite određeni iznos ili da koristite našu pomoć!", "Pomoć", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
