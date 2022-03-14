using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeselForms.Model;

namespace PeselForms
{
    public partial class OknoGlowne : Form
    {
        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {
            try
            {
                Pesel pesel = new Pesel(textBoxPesel.Text);

                labelPlec.Text = @"Płeć: " + pesel.Plec;
                labelData.Text = "Data: " + pesel.Dzien.ToString("00")
                                          + "." + pesel.Miesiac.ToString("00")
                                          + "." + pesel.Rok.ToString("0000");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Błąd");
            }
        }

        private void textBoxPesel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buttonSprawdz_Click(null, null);
                //buttonSprawdz_Click(buttonSprawdz, null);
                //buttonSprawdz_Click(null, new EventArgs());
                //buttonSprawdz_Click(buttonSprawdz, new EventArgs());
                buttonSprawdz.PerformClick();
            }
        }
    }
}
