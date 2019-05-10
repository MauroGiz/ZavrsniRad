using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace GizdulićMauroParkingGaraža
{
    public partial class Ulaz : Form
    {
          string server = "portmap.io";
          string port = "61974";
          string database = "parking_garaza";
          string user = "test";
          string password = "123";
          static string connectionString =
            "SERVER=portmap.io" + ";" +
            "PORT=61974" + ";" +
            "DATABASE=parking_garaza" + ";" +
            "UID=test" + ";" +
            "PASSWORD=123" + ";" + 
            "Convert Zero DateTime=True;" +
            "Allow Zero DateTime=no;";

              MySqlConnection connection = new MySqlConnection(connectionString);
              MySqlCommand cmd;
              MySqlDataAdapter dataAdapter;
              MySqlCommandBuilder commandBuilder;

        public Ulaz()
        {
            InitializeComponent();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                UpisivanjeUBazu();
                Printanje();
                this.Close();
            }

            catch
            {
                MessageBox.Show("Nije uspjelo upisivanje!");
            }
        }

        public void Printanje()
        {
            // Printanje dokumenta
            printPreviewDialogOut.Document = printDocumentOut;
            printPreviewDialogOut.ShowDialog();
        }

        public void UpisivanjeUBazu()
        {
            Random rnd = new Random();
            int ID = rnd.Next(000000000, 999999999);
            DateTime dateTimeVariable = DateTime.Now;
            string sqlTime = string.Format(dateTimeVariable.ToString("yyyy-MM-dd HH:mm:ss"));
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO status VALUES('" + ID + "','" + textBoxTablica.Text + "','" + sqlTime + "')";
            cmd.ExecuteNonQuery();

            richTextBoxIzlaz.Text = "ID: " + ID + "\n" +
                                    "Tablica: " + textBoxTablica.Text + "\n" +
                                    "Vrijeme ulaska: " + sqlTime;

            connection.Close();
        }

        private void Ulaz_Load(object sender, EventArgs e)
        {
            timerVrijeme.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timerVrijeme_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerVrijeme.Start();
        }

        private void printDocumentOut_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxIzlaz.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(194, 229));
        }

    }
}
