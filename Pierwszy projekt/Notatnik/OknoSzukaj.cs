using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class OknoSzukaj : Form
    {
        public string SzukanyTekst
        {
            get
            {
                return textBoxSzukaj.Text;
            }
            set
            {
                textBoxSzukaj.Text = value;
            }
        }

        public OknoSzukaj()
        {
            InitializeComponent();
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
