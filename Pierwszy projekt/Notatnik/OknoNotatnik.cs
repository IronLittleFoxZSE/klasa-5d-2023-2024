using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class OknoNotatnik : Form
    {
        string sciezkaDoPliku = "";

        public OknoNotatnik()
        {
            InitializeComponent();
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
            string aktulnyCzasStr = aktualnyCzas.ToString("HH:mm:ss dd.MM.yyyy");

            textBoxNotatnik.Paste(aktulnyCzasStr);
            //textBoxNotatnik.Paste(DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy"));
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

        private void powiększToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontFamily fontFamily = textBoxNotatnik.Font.FontFamily;
            float size = textBoxNotatnik.Font.Size + 4;
            FontStyle fontStyle = textBoxNotatnik.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            textBoxNotatnik.Font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
        }

        private void zmniejszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontFamily fontFamily = textBoxNotatnik.Font.FontFamily;
            float size = textBoxNotatnik.Font.Size - 4;
            FontStyle fontStyle = textBoxNotatnik.Font.Style;
            GraphicsUnit graphicsUnit = textBoxNotatnik.Font.Unit;
            byte gdiCharSet = textBoxNotatnik.Font.GdiCharSet;

            if (size > 0)
                textBoxNotatnik.Font = new Font(fontFamily, size, fontStyle, graphicsUnit, gdiCharSet);
        }

        private void wartośćDomyślnaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Zdarzenia menu Pomoc

        #endregion


    }
}
