
namespace ProjektUczniowie
{
    partial class OknoGlowne
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
            this.groupBoxFiltry = new System.Windows.Forms.GroupBox();
            this.buttonFiltrySzukaj = new System.Windows.Forms.Button();
            this.labelFiltryNazwisko = new System.Windows.Forms.Label();
            this.numericUpDownFiltryRok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFiltryKlasa = new System.Windows.Forms.ComboBox();
            this.textBoxFiltryNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxFiltryImie = new System.Windows.Forms.TextBox();
            this.labelFiltryRok = new System.Windows.Forms.Label();
            this.labelFiltryKlasa = new System.Windows.Forms.Label();
            this.labelFiltryImie = new System.Windows.Forms.Label();
            this.groupBoxOperacje = new System.Windows.Forms.GroupBox();
            this.buttonOperacjeDodajKlase = new System.Windows.Forms.Button();
            this.buttonOperacjeUsun = new System.Windows.Forms.Button();
            this.buttonOperacjeEdytuj = new System.Windows.Forms.Button();
            this.buttonOperacjeDodaj = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.ColumnImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKlasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRokUrodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFiltry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltryRok)).BeginInit();
            this.groupBoxOperacje.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltry
            // 
            this.groupBoxFiltry.Controls.Add(this.buttonFiltrySzukaj);
            this.groupBoxFiltry.Controls.Add(this.labelFiltryNazwisko);
            this.groupBoxFiltry.Controls.Add(this.numericUpDownFiltryRok);
            this.groupBoxFiltry.Controls.Add(this.comboBoxFiltryKlasa);
            this.groupBoxFiltry.Controls.Add(this.textBoxFiltryNazwisko);
            this.groupBoxFiltry.Controls.Add(this.textBoxFiltryImie);
            this.groupBoxFiltry.Controls.Add(this.labelFiltryRok);
            this.groupBoxFiltry.Controls.Add(this.labelFiltryKlasa);
            this.groupBoxFiltry.Controls.Add(this.labelFiltryImie);
            this.groupBoxFiltry.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFiltry.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltry.Name = "groupBoxFiltry";
            this.groupBoxFiltry.Size = new System.Drawing.Size(624, 95);
            this.groupBoxFiltry.TabIndex = 0;
            this.groupBoxFiltry.TabStop = false;
            this.groupBoxFiltry.Text = "Filtr:";
            // 
            // buttonFiltrySzukaj
            // 
            this.buttonFiltrySzukaj.Location = new System.Drawing.Point(511, 18);
            this.buttonFiltrySzukaj.Name = "buttonFiltrySzukaj";
            this.buttonFiltrySzukaj.Size = new System.Drawing.Size(97, 59);
            this.buttonFiltrySzukaj.TabIndex = 8;
            this.buttonFiltrySzukaj.Text = "Szukaj";
            this.buttonFiltrySzukaj.UseVisualStyleBackColor = true;
            this.buttonFiltrySzukaj.Click += new System.EventHandler(this.buttonFiltrySzukaj_Click);
            // 
            // labelFiltryNazwisko
            // 
            this.labelFiltryNazwisko.AutoSize = true;
            this.labelFiltryNazwisko.Location = new System.Drawing.Point(117, 19);
            this.labelFiltryNazwisko.Name = "labelFiltryNazwisko";
            this.labelFiltryNazwisko.Size = new System.Drawing.Size(57, 15);
            this.labelFiltryNazwisko.TabIndex = 1;
            this.labelFiltryNazwisko.Text = "Nazwisko";
            // 
            // numericUpDownFiltryRok
            // 
            this.numericUpDownFiltryRok.Location = new System.Drawing.Point(373, 37);
            this.numericUpDownFiltryRok.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numericUpDownFiltryRok.Name = "numericUpDownFiltryRok";
            this.numericUpDownFiltryRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownFiltryRok.TabIndex = 7;
            // 
            // comboBoxFiltryKlasa
            // 
            this.comboBoxFiltryKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltryKlasa.FormattingEnabled = true;
            this.comboBoxFiltryKlasa.Location = new System.Drawing.Point(246, 37);
            this.comboBoxFiltryKlasa.Name = "comboBoxFiltryKlasa";
            this.comboBoxFiltryKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFiltryKlasa.TabIndex = 6;
            // 
            // textBoxFiltryNazwisko
            // 
            this.textBoxFiltryNazwisko.Location = new System.Drawing.Point(117, 39);
            this.textBoxFiltryNazwisko.Name = "textBoxFiltryNazwisko";
            this.textBoxFiltryNazwisko.Size = new System.Drawing.Size(123, 23);
            this.textBoxFiltryNazwisko.TabIndex = 5;
            // 
            // textBoxFiltryImie
            // 
            this.textBoxFiltryImie.Location = new System.Drawing.Point(12, 39);
            this.textBoxFiltryImie.Name = "textBoxFiltryImie";
            this.textBoxFiltryImie.Size = new System.Drawing.Size(99, 23);
            this.textBoxFiltryImie.TabIndex = 4;
            // 
            // labelFiltryRok
            // 
            this.labelFiltryRok.AutoSize = true;
            this.labelFiltryRok.Location = new System.Drawing.Point(373, 19);
            this.labelFiltryRok.Name = "labelFiltryRok";
            this.labelFiltryRok.Size = new System.Drawing.Size(27, 15);
            this.labelFiltryRok.TabIndex = 3;
            this.labelFiltryRok.Text = "Rok";
            // 
            // labelFiltryKlasa
            // 
            this.labelFiltryKlasa.AutoSize = true;
            this.labelFiltryKlasa.Location = new System.Drawing.Point(246, 19);
            this.labelFiltryKlasa.Name = "labelFiltryKlasa";
            this.labelFiltryKlasa.Size = new System.Drawing.Size(34, 15);
            this.labelFiltryKlasa.TabIndex = 2;
            this.labelFiltryKlasa.Text = "Klasa";
            // 
            // labelFiltryImie
            // 
            this.labelFiltryImie.AutoSize = true;
            this.labelFiltryImie.Location = new System.Drawing.Point(12, 19);
            this.labelFiltryImie.Name = "labelFiltryImie";
            this.labelFiltryImie.Size = new System.Drawing.Size(30, 15);
            this.labelFiltryImie.TabIndex = 0;
            this.labelFiltryImie.Text = "Imie";
            // 
            // groupBoxOperacje
            // 
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeDodajKlase);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeUsun);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeEdytuj);
            this.groupBoxOperacje.Controls.Add(this.buttonOperacjeDodaj);
            this.groupBoxOperacje.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOperacje.Location = new System.Drawing.Point(535, 95);
            this.groupBoxOperacje.Name = "groupBoxOperacje";
            this.groupBoxOperacje.Size = new System.Drawing.Size(89, 360);
            this.groupBoxOperacje.TabIndex = 1;
            this.groupBoxOperacje.TabStop = false;
            this.groupBoxOperacje.Text = "Operacje";
            // 
            // buttonOperacjeDodajKlase
            // 
            this.buttonOperacjeDodajKlase.Location = new System.Drawing.Point(6, 144);
            this.buttonOperacjeDodajKlase.Name = "buttonOperacjeDodajKlase";
            this.buttonOperacjeDodajKlase.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeDodajKlase.TabIndex = 3;
            this.buttonOperacjeDodajKlase.Text = "Dodaj klasę";
            this.buttonOperacjeDodajKlase.UseVisualStyleBackColor = true;
            this.buttonOperacjeDodajKlase.Click += new System.EventHandler(this.buttonOperacjeDodajKlase_Click);
            // 
            // buttonOperacjeUsun
            // 
            this.buttonOperacjeUsun.Location = new System.Drawing.Point(6, 80);
            this.buttonOperacjeUsun.Name = "buttonOperacjeUsun";
            this.buttonOperacjeUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeUsun.TabIndex = 2;
            this.buttonOperacjeUsun.Text = "Usuń";
            this.buttonOperacjeUsun.UseVisualStyleBackColor = true;
            this.buttonOperacjeUsun.Click += new System.EventHandler(this.buttonOperacjeUsun_Click);
            // 
            // buttonOperacjeEdytuj
            // 
            this.buttonOperacjeEdytuj.Location = new System.Drawing.Point(6, 51);
            this.buttonOperacjeEdytuj.Name = "buttonOperacjeEdytuj";
            this.buttonOperacjeEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeEdytuj.TabIndex = 1;
            this.buttonOperacjeEdytuj.Text = "Edytuj";
            this.buttonOperacjeEdytuj.UseVisualStyleBackColor = true;
            this.buttonOperacjeEdytuj.Click += new System.EventHandler(this.buttonOperacjeEdytuj_Click);
            // 
            // buttonOperacjeDodaj
            // 
            this.buttonOperacjeDodaj.Location = new System.Drawing.Point(6, 22);
            this.buttonOperacjeDodaj.Name = "buttonOperacjeDodaj";
            this.buttonOperacjeDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonOperacjeDodaj.TabIndex = 0;
            this.buttonOperacjeDodaj.Text = "Dodaj";
            this.buttonOperacjeDodaj.UseVisualStyleBackColor = true;
            this.buttonOperacjeDodaj.Click += new System.EventHandler(this.buttonOperacjeDodaj_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.dataGridViewLista);
            this.groupBoxLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLista.Location = new System.Drawing.Point(0, 95);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(535, 360);
            this.groupBoxLista.TabIndex = 2;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista uczniow:";
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImie,
            this.ColumnNazwisko,
            this.ColumnKlasa,
            this.ColumnRokUrodzenia});
            this.dataGridViewLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLista.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.RowTemplate.Height = 25;
            this.dataGridViewLista.Size = new System.Drawing.Size(529, 338);
            this.dataGridViewLista.TabIndex = 0;
            // 
            // ColumnImie
            // 
            this.ColumnImie.DataPropertyName = "Imie";
            this.ColumnImie.HeaderText = "Imie";
            this.ColumnImie.Name = "ColumnImie";
            this.ColumnImie.ReadOnly = true;
            // 
            // ColumnNazwisko
            // 
            this.ColumnNazwisko.DataPropertyName = "Nazwisko";
            this.ColumnNazwisko.HeaderText = "Nazwisko";
            this.ColumnNazwisko.Name = "ColumnNazwisko";
            this.ColumnNazwisko.ReadOnly = true;
            // 
            // ColumnKlasa
            // 
            this.ColumnKlasa.DataPropertyName = "NazwaKlasy";
            this.ColumnKlasa.HeaderText = "Klasa";
            this.ColumnKlasa.Name = "ColumnKlasa";
            this.ColumnKlasa.ReadOnly = true;
            // 
            // ColumnRokUrodzenia
            // 
            this.ColumnRokUrodzenia.DataPropertyName = "RokUrodzenia";
            this.ColumnRokUrodzenia.HeaderText = "Rok urodzenia";
            this.ColumnRokUrodzenia.Name = "ColumnRokUrodzenia";
            this.ColumnRokUrodzenia.ReadOnly = true;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 455);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxOperacje);
            this.Controls.Add(this.groupBoxFiltry);
            this.MinimumSize = new System.Drawing.Size(640, 494);
            this.Name = "OknoGlowne";
            this.Text = "Lista uczniów";
            this.groupBoxFiltry.ResumeLayout(false);
            this.groupBoxFiltry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiltryRok)).EndInit();
            this.groupBoxOperacje.ResumeLayout(false);
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltry;
        private System.Windows.Forms.Button buttonFiltrySzukaj;
        private System.Windows.Forms.Label labelFiltryNazwisko;
        private System.Windows.Forms.NumericUpDown numericUpDownFiltryRok;
        private System.Windows.Forms.ComboBox comboBoxFiltryKlasa;
        private System.Windows.Forms.TextBox textBoxFiltryNazwisko;
        private System.Windows.Forms.TextBox textBoxFiltryImie;
        private System.Windows.Forms.Label labelFiltryRok;
        private System.Windows.Forms.Label labelFiltryKlasa;
        private System.Windows.Forms.Label labelFiltryImie;
        private System.Windows.Forms.GroupBox groupBoxOperacje;
        private System.Windows.Forms.Button buttonOperacjeDodajKlase;
        private System.Windows.Forms.Button buttonOperacjeUsun;
        private System.Windows.Forms.Button buttonOperacjeEdytuj;
        private System.Windows.Forms.Button buttonOperacjeDodaj;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKlasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRokUrodzenia;
    }
}

