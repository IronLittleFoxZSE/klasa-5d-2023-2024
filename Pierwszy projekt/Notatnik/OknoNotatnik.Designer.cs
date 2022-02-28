
namespace Notatnik
{
    partial class OknoNotatnik
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMenuGlowne = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.znajdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znajdzNastępnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.godzinaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaznaczWszystkoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zawijanieWierszyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powiększenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powiększToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmniejszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wartośćDomyślnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasekStanuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatnikInformacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripPasekDolny = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPowiekszenie = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxNotatnik = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabelAktualnaGodzina = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerGodzina = new System.Windows.Forms.Timer(this.components);
            this.menuStripMenuGlowne.SuspendLayout();
            this.statusStripPasekDolny.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenuGlowne
            // 
            this.menuStripMenuGlowne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStripMenuGlowne.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenuGlowne.Name = "menuStripMenuGlowne";
            this.menuStripMenuGlowne.Size = new System.Drawing.Size(656, 24);
            this.menuStripMenuGlowne.TabIndex = 0;
            this.menuStripMenuGlowne.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.nowyToolStripMenuItem.Text = "&Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.otwórzToolStripMenuItem.Text = "&Otwórz...";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.zapiszToolStripMenuItem.Text = "Zapi&sz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Z&apisz jako...";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.zakończToolStripMenuItem.Text = "Zakoń&cz";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cofnijToolStripMenuItem,
            this.toolStripMenuItem2,
            this.wytnijToolStripMenuItem,
            this.kopiujToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.toolStripMenuItem3,
            this.znajdźToolStripMenuItem,
            this.znajdzNastępnyToolStripMenuItem,
            this.toolStripMenuItem4,
            this.zaznaczWszystkoToolStripMenuItem,
            this.godzinaDataToolStripMenuItem,
            this.zaznaczWszystkoToolStripMenuItem1});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.wytnijToolStripMenuItem_Click);
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.kopiujToolStripMenuItem_Click);
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            this.wklejToolStripMenuItem.Click += new System.EventHandler(this.wklejToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // znajdźToolStripMenuItem
            // 
            this.znajdźToolStripMenuItem.Name = "znajdźToolStripMenuItem";
            this.znajdźToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.znajdźToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.znajdźToolStripMenuItem.Text = "Znajdź";
            this.znajdźToolStripMenuItem.Click += new System.EventHandler(this.znajdźToolStripMenuItem_Click);
            // 
            // znajdzNastępnyToolStripMenuItem
            // 
            this.znajdzNastępnyToolStripMenuItem.Name = "znajdzNastępnyToolStripMenuItem";
            this.znajdzNastępnyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.znajdzNastępnyToolStripMenuItem.Text = "Znajdz następny";
            this.znajdzNastępnyToolStripMenuItem.Click += new System.EventHandler(this.znajdzNastępnyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(205, 6);
            // 
            // zaznaczWszystkoToolStripMenuItem
            // 
            this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
            this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
            this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.zaznaczWszystkoToolStripMenuItem_Click);
            // 
            // godzinaDataToolStripMenuItem
            // 
            this.godzinaDataToolStripMenuItem.Name = "godzinaDataToolStripMenuItem";
            this.godzinaDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.godzinaDataToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.godzinaDataToolStripMenuItem.Text = "Godzina/Data";
            this.godzinaDataToolStripMenuItem.Click += new System.EventHandler(this.godzinaDataToolStripMenuItem_Click);
            // 
            // zaznaczWszystkoToolStripMenuItem1
            // 
            this.zaznaczWszystkoToolStripMenuItem1.Name = "zaznaczWszystkoToolStripMenuItem1";
            this.zaznaczWszystkoToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.zaznaczWszystkoToolStripMenuItem1.Text = "Zaznacz wszystko";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zawijanieWierszyToolStripMenuItem,
            this.czcionkaToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "For&mat";
            // 
            // zawijanieWierszyToolStripMenuItem
            // 
            this.zawijanieWierszyToolStripMenuItem.Name = "zawijanieWierszyToolStripMenuItem";
            this.zawijanieWierszyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zawijanieWierszyToolStripMenuItem.Text = "Zawijanie wierszy";
            this.zawijanieWierszyToolStripMenuItem.Click += new System.EventHandler(this.zawijanieWierszyToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powiększenieToolStripMenuItem,
            this.pasekStanuToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "&Widok";
            // 
            // powiększenieToolStripMenuItem
            // 
            this.powiększenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powiększToolStripMenuItem,
            this.zmniejszToolStripMenuItem,
            this.wartośćDomyślnaToolStripMenuItem});
            this.powiększenieToolStripMenuItem.Name = "powiększenieToolStripMenuItem";
            this.powiększenieToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.powiększenieToolStripMenuItem.Text = "Powiększenie";
            // 
            // powiększToolStripMenuItem
            // 
            this.powiększToolStripMenuItem.Name = "powiększToolStripMenuItem";
            this.powiększToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.powiększToolStripMenuItem.Tag = "4";
            this.powiększToolStripMenuItem.Text = "Powiększ";
            this.powiększToolStripMenuItem.Click += new System.EventHandler(this.powiekszPomniejszToolStripMenuItem_Click);
            // 
            // zmniejszToolStripMenuItem
            // 
            this.zmniejszToolStripMenuItem.Name = "zmniejszToolStripMenuItem";
            this.zmniejszToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.zmniejszToolStripMenuItem.Tag = "-4";
            this.zmniejszToolStripMenuItem.Text = "Zmniejsz";
            this.zmniejszToolStripMenuItem.Click += new System.EventHandler(this.powiekszPomniejszToolStripMenuItem_Click);
            // 
            // wartośćDomyślnaToolStripMenuItem
            // 
            this.wartośćDomyślnaToolStripMenuItem.Name = "wartośćDomyślnaToolStripMenuItem";
            this.wartośćDomyślnaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.wartośćDomyślnaToolStripMenuItem.Text = "Wartość domyślna";
            this.wartośćDomyślnaToolStripMenuItem.Click += new System.EventHandler(this.wartośćDomyślnaToolStripMenuItem_Click);
            // 
            // pasekStanuToolStripMenuItem
            // 
            this.pasekStanuToolStripMenuItem.Checked = true;
            this.pasekStanuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pasekStanuToolStripMenuItem.Name = "pasekStanuToolStripMenuItem";
            this.pasekStanuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasekStanuToolStripMenuItem.Text = "Pasek stanu";
            this.pasekStanuToolStripMenuItem.Click += new System.EventHandler(this.pasekStanuToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notatnikInformacjeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomo&c";
            // 
            // notatnikInformacjeToolStripMenuItem
            // 
            this.notatnikInformacjeToolStripMenuItem.Name = "notatnikInformacjeToolStripMenuItem";
            this.notatnikInformacjeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.notatnikInformacjeToolStripMenuItem.Text = "Notatnik - informacje";
            this.notatnikInformacjeToolStripMenuItem.Click += new System.EventHandler(this.notatnikInformacjeToolStripMenuItem_Click);
            // 
            // statusStripPasekDolny
            // 
            this.statusStripPasekDolny.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPowiekszenie,
            this.toolStripStatusLabelAktualnaGodzina});
            this.statusStripPasekDolny.Location = new System.Drawing.Point(0, 484);
            this.statusStripPasekDolny.Name = "statusStripPasekDolny";
            this.statusStripPasekDolny.Size = new System.Drawing.Size(656, 22);
            this.statusStripPasekDolny.TabIndex = 1;
            this.statusStripPasekDolny.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPowiekszenie
            // 
            this.toolStripStatusLabelPowiekszenie.Name = "toolStripStatusLabelPowiekszenie";
            this.toolStripStatusLabelPowiekszenie.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabelPowiekszenie.Text = "Powiększenie: 100%";
            // 
            // textBoxNotatnik
            // 
            this.textBoxNotatnik.AllowDrop = true;
            this.textBoxNotatnik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNotatnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotatnik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNotatnik.Location = new System.Drawing.Point(0, 24);
            this.textBoxNotatnik.Multiline = true;
            this.textBoxNotatnik.Name = "textBoxNotatnik";
            this.textBoxNotatnik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxNotatnik.Size = new System.Drawing.Size(656, 460);
            this.textBoxNotatnik.TabIndex = 2;
            this.textBoxNotatnik.WordWrap = false;
            this.textBoxNotatnik.FontChanged += new System.EventHandler(this.textBoxNotatnik_FontChanged);
            this.textBoxNotatnik.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxNotatnik_DragDrop);
            this.textBoxNotatnik.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxNotatnik_DragEnter);
            this.textBoxNotatnik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNotatnik_KeyDown);
            this.textBoxNotatnik.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNotatnik_KeyUp);
            // 
            // toolStripStatusLabelAktualnaGodzina
            // 
            this.toolStripStatusLabelAktualnaGodzina.Name = "toolStripStatusLabelAktualnaGodzina";
            this.toolStripStatusLabelAktualnaGodzina.Size = new System.Drawing.Size(0, 17);
            // 
            // timerGodzina
            // 
            this.timerGodzina.Enabled = true;
            this.timerGodzina.Interval = 1000;
            this.timerGodzina.Tick += new System.EventHandler(this.timerGodzina_Tick);
            // 
            // OknoNotatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 506);
            this.Controls.Add(this.textBoxNotatnik);
            this.Controls.Add(this.statusStripPasekDolny);
            this.Controls.Add(this.menuStripMenuGlowne);
            this.MainMenuStrip = this.menuStripMenuGlowne;
            this.Name = "OknoNotatnik";
            this.Text = "Notatnik";
            this.menuStripMenuGlowne.ResumeLayout(false);
            this.menuStripMenuGlowne.PerformLayout();
            this.statusStripPasekDolny.ResumeLayout(false);
            this.statusStripPasekDolny.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenuGlowne;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem znajdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem godzinaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zawijanieWierszyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powiększenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powiększToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmniejszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wartośćDomyślnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasekStanuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatnikInformacjeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripPasekDolny;
        private System.Windows.Forms.TextBox textBoxNotatnik;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPowiekszenie;
        private System.Windows.Forms.ToolStripMenuItem znajdzNastępnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAktualnaGodzina;
        private System.Windows.Forms.Timer timerGodzina;
    }
}

