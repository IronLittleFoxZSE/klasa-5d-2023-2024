using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class OknoNotatnik : Form
    {
        private string sciezkaDoPliku = "";
        private float wartoscDomyslnaRozmiaruCzcionki;

        private int krokZmianyCzcionki = 4;

        private bool czyWcisnietyCTRL = false;

        private string szukanyTekst = "";

        public OknoNotatnik(string[] arg)
        {
            InitializeComponent();

            wartoscDomyslnaRozmiaruCzcionki = textBoxNotatnik.Font.Size;

            powiększenieToolStripMenuItem.Tag = krokZmianyCzcionki;
            zmniejszToolStripMenuItem.Tag = -krokZmianyCzcionki;

            textBoxNotatnik.MouseWheel += textBoxNotatnik_MouseWheel;

            if (arg != null && arg.Length == 1 && File.Exists(arg[0]))
            {
                sciezkaDoPliku = arg[0];
                textBoxNotatnik.Text = File.ReadAllText(sciezkaDoPliku);
            }

            toolStripStatusLabelAktualnaGodzina.Text = "Godzina " + DateTime.Now.ToString("hh:mm:ss");
        }



        #region Zdarzenia menu Plik

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Text = "";
            sciezkaDoPliku = "";
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Dokumenty tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                sciezkaDoPliku = openFileDialog.FileName;
                textBoxNotatnik.Text = File.ReadAllText(sciezkaDoPliku);
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sciezkaDoPliku == "")
            {
                zapiszJakoToolStripMenuItem_Click(null, null);
            }
            else
            {
                File.WriteAllText(sciezkaDoPliku, textBoxNotatnik.Text);
            }
        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Dokumenty tekstowe (*.txt)|*.txt|Wszystkie pliki|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                sciezkaDoPliku = saveFileDialog.FileName;
                File.WriteAllText(sciezkaDoPliku, textBoxNotatnik.Text);
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Zdarzenia menu Edycja

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Undo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.Paste();
        }
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectedText = "";
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotatnik.SelectAll();
        }

        private void godzinaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime aktualnyCzas;
            aktualnyCzas = DateTime.Now;
            string aktulnyCzasStr = aktualnyCzas.ToString(" HH:mm:ss dd.MM.yyyy");

            textBoxNotatnik.Paste(aktulnyCzasStr);
            //textBoxNotatnik.Paste(DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy"));
        }

        private void znajdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoSzukaj oknoSzukaj = new OknoSzukaj();
            oknoSzukaj.SzukanyTekst = szukanyTekst;
            if (oknoSzukaj.ShowDialog() == DialogResult.OK)
            {
                szukanyTekst = oknoSzukaj.SzukanyTekst;

                Szukaj(0);
            }
        }

        private void znajdzNastępnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Szukaj(textBoxNotatnik.SelectionStart + 1);
        }

        private void Szukaj(int start)
        {
            if (start > textBoxNotatnik.Text.Length)
            {
                MessageBox.Show("Szukanie poza zakresem");
                return;
            }

            int pozycja = textBoxNotatnik.Text.IndexOf(szukanyTekst, start, StringComparison.CurrentCultureIgnoreCase);
            if (pozycja != -1)
            {
                textBoxNotatnik.SelectionStart = pozycja;
                textBoxNotatnik.SelectionLength = szukanyTekst.Length;
            }
            else
            {
                MessageBox.Show("Brak szukanej frazy");
            }
        }


        #endregion

        #region Zdarzenia menu Format

        private void zawijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (zawijanieWierszyToolStripMenuItem.Checked == true)
                zawijanieWierszyToolStripMenuItem.Checked = false;
            else
                zawijanieWierszyToolStripMenuItem.Checked = true;*/
            zawijanieWierszyToolStripMenuItem.Checked = !zawijanieWierszyToolStripMenuItem.Checked;
            textBoxNotatnik.WordWrap = zawijanieWierszyToolStripMenuItem.Checked;
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = textBoxNotatnik.Font;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxNotatnik.Font = fontDialog.Font;
            }
        }


        #endregion

        #region Zdarzenia menu Widok

        private void powiekszPomniejszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            if (toolStripMenuItem != null)
            {
                int krokZmiany;
                if (int.TryParse(toolStripMenuItem.Tag.ToString(), out krokZmiany) /*== true*/)
                    ZmienRozmiarCzcionki(textBoxNotatnik.Font.Size + krokZmiany);
            }
        }

        private void ZmienRozmiarCzcionki(float wielkoscCzcionki)
        {
            FontFamily fontFamily = textBoxNotatnik.Font.FontFamily;
            float size = wielkoscCzcionki;
            FontStyle fontStyle = textBoxNotatnik.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            if (size > 0 && size <= 72)
                textBoxNotatnik.Font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
        }


        private void wartośćDomyślnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienRozmiarCzcionki(wartoscDomyslnaRozmiaruCzcionki);
        }

        private void textBoxNotatnik_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!czyWcisnietyCTRL)
                return;

            if (e.Delta > 0)
                ZmienRozmiarCzcionki(textBoxNotatnik.Font.Size + krokZmianyCzcionki);
            else
                ZmienRozmiarCzcionki(textBoxNotatnik.Font.Size - krokZmianyCzcionki);
        }

        private void textBoxNotatnik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                czyWcisnietyCTRL = true;
        }

        private void textBoxNotatnik_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                czyWcisnietyCTRL = false;
        }

        private void textBoxNotatnik_FontChanged(object sender, EventArgs e)
        {
            float powiekszenie = textBoxNotatnik.Font.Size / wartoscDomyslnaRozmiaruCzcionki * 100;
            toolStripStatusLabelPowiekszenie.Text = "Powiększenie: " + powiekszenie.ToString("N2") + "%";
        }

        private void pasekStanuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasekStanuToolStripMenuItem.Checked = !pasekStanuToolStripMenuItem.Checked;
            statusStripPasekDolny.Visible = pasekStanuToolStripMenuItem.Checked;
        }


        #endregion

        #region Zdarzenia menu Pomoc

        private void notatnikInformacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OknoPomoc oknoPomoc = new OknoPomoc();
            oknoPomoc.ShowDialog();
        }

        #endregion

        #region Zdarzenia Drag&Drop

        private void textBoxNotatnik_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
        }

        private void textBoxNotatnik_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] pliki = e.Data.GetData(DataFormats.FileDrop) as string[];

                sciezkaDoPliku = pliki[0];
                textBoxNotatnik.Text = File.ReadAllText(sciezkaDoPliku);
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                string text = e.Data.GetData(DataFormats.Text) as string;
                textBoxNotatnik.Paste(text);
            }
        }



        #endregion

        private void timerGodzina_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelAktualnaGodzina.Text = "Godzina " + DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
