using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pierwsze_okno
{
    public partial class Komunikat : Form
    {
        public Komunikat()
        {
            InitializeComponent();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
