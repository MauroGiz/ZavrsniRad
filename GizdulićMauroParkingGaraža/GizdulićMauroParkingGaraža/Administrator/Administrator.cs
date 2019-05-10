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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            // Prikazivanje baze podataka
            PrikazivanjeBaze();
        }

        private void buttonIzbrisi_Click(object sender, EventArgs e)
        {
            // Brisanje podataka iz baze
            IzbrisiPodatke();
        }

        public void IzbrisiPodatke()
        {
            string server = "portmap.io";
            string port = "61974";
            string database = "parking_garaza";
            string user = "test";
            string password = "123";
            string connectionString =
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

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM status";
            cmd.ExecuteNonQuery();
            connection.Close();

        } // Metoda za brisanje podataka 

        public void PrikazivanjeBaze()
        {
            string server = "portmap.io";
            string port = "61974";
            string database = "parking_garaza";
            string user = "test";
            string password = "123";
             string connectionString =
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

            dataAdapter = new MySqlDataAdapter("SELECT * FROM status", connection);
            commandBuilder = new MySqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            bindingSourcePodaci.DataSource = table;
            dataGridViewPodaci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridViewPodaci.ReadOnly = true;
            dataGridViewPodaci.DataSource = bindingSourcePodaci;
        } // Metoda za prikazivanje podataka
    }
}
