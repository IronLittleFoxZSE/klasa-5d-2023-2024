using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierwsze_okno
{
    public partial class OknoGlowne : Form
    {
        Random random = new Random();
        public OknoGlowne()
        {
            InitializeComponent();
        }

        private void buttonPierwszy_Click(object sender, EventArgs e)
        {
            labelPowitanie.Text = "Hello";
            buttonPierwszy.Text = "Hello world!!!!!";
            Text = "Tekst okna glownego";
        }

        private void buttonPierwszy_MouseEnter(object sender, EventArgs e)
        {
            int x = random.Next(0, Size.Width - buttonPierwszy.Width);
            int y = random.Next(0, Size.Height - buttonPierwszy.Height); ;
            Point point = new Point(x,y);

            buttonPierwszy.Location = point;
        }

        private void buttonPokarzOknoKomunikatu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy 2+2 jest równe 4?", "Naglowek", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Gratulacje");
            }

            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Zła odpowiedź");
            }
        }

        private void buttonOknoUzytkownika_Click(object sender, EventArgs e)
        {
            Komunikat komunikat = new Komunikat();
            komunikat.ShowDialog();
        }
    }
}
