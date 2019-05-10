using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizdulićMauroParkingGaraža.OGarazi
{
    public partial class UPU : Form
    {
        public UPU()
        {
            InitializeComponent();
        }

        private void UPU_Load(object sender, EventArgs e)
        {

        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
