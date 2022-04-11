
namespace DaneOsobowe
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
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.numericUpDownWiek = new System.Windows.Forms.NumericUpDown();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelImie = new System.Windows.Forms.Label();
            this.groupBoxRead = new System.Windows.Forms.GroupBox();
            this.buttonSzukajPelnoletnie = new System.Windows.Forms.Button();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.comboBoxWynik = new System.Windows.Forms.ComboBox();
            this.buttonSzukajWiek = new System.Windows.Forms.Button();
            this.numericUpDownSzukajWiek = new System.Windows.Forms.NumericUpDown();
            this.labelSzukajWieku = new System.Windows.Forms.Label();
            this.numericUpDownSzukajId = new System.Windows.Forms.NumericUpDown();
            this.buttonOdczytajWiersz = new System.Windows.Forms.Button();
            this.numericUpDownWiekRead = new System.Windows.Forms.NumericUpDown();
            this.labelWiekRead = new System.Windows.Forms.Label();
            this.textBoxNazwiskoRead = new System.Windows.Forms.TextBox();
            this.labelNazwiskoRead = new System.Windows.Forms.Label();
            this.textBoxImieRead = new System.Windows.Forms.TextBox();
            this.labelImieRead = new System.Windows.Forms.Label();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.labelNazwiskoUpdate = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.textBoxNazwiskoUpdate = new System.Windows.Forms.TextBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.numericUpDownDeleteId = new System.Windows.Forms.NumericUpDown();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.ColumnImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWiek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCzyPelnoletnia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnMiasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUlica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).BeginInit();
            this.groupBoxRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzukajWiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzukajId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiekRead)).BeginInit();
            this.groupBoxUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            this.groupBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.buttonDodaj);
            this.groupBoxCreate.Controls.Add(this.numericUpDownWiek);
            this.groupBoxCreate.Controls.Add(this.labelWiek);
            this.groupBoxCreate.Controls.Add(this.textBoxNazwisko);
            this.groupBoxCreate.Controls.Add(this.labelNazwisko);
            this.groupBoxCreate.Controls.Add(this.textBoxImie);
            this.groupBoxCreate.Controls.Add(this.labelImie);
            this.groupBoxCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCreate.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(1029, 124);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(461, 29);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(163, 57);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj do bazy";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // numericUpDownWiek
            // 
            this.numericUpDownWiek.Location = new System.Drawing.Point(256, 59);
            this.numericUpDownWiek.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownWiek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWiek.Name = "numericUpDownWiek";
            this.numericUpDownWiek.ReadOnly = true;
            this.numericUpDownWiek.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWiek.TabIndex = 5;
            this.numericUpDownWiek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(256, 29);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(36, 15);
            this.labelWiek.TabIndex = 4;
            this.labelWiek.Text = "Wiek:";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(132, 58);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwisko.TabIndex = 3;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(132, 29);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(60, 15);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 58);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 23);
            this.textBoxImie.TabIndex = 1;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 29);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(33, 15);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imie:";
            // 
            // groupBoxRead
            // 
            this.groupBoxRead.Controls.Add(this.buttonSzukajPelnoletnie);
            this.groupBoxRead.Controls.Add(this.buttonSzukaj);
            this.groupBoxRead.Controls.Add(this.dataGridViewLista);
            this.groupBoxRead.Controls.Add(this.comboBoxWynik);
            this.groupBoxRead.Controls.Add(this.buttonSzukajWiek);
            this.groupBoxRead.Controls.Add(this.numericUpDownSzukajWiek);
            this.groupBoxRead.Controls.Add(this.labelSzukajWieku);
            this.groupBoxRead.Controls.Add(this.numericUpDownSzukajId);
            this.groupBoxRead.Controls.Add(this.buttonOdczytajWiersz);
            this.groupBoxRead.Controls.Add(this.numericUpDownWiekRead);
            this.groupBoxRead.Controls.Add(this.labelWiekRead);
            this.groupBoxRead.Controls.Add(this.textBoxNazwiskoRead);
            this.groupBoxRead.Controls.Add(this.labelNazwiskoRead);
            this.groupBoxRead.Controls.Add(this.textBoxImieRead);
            this.groupBoxRead.Controls.Add(this.labelImieRead);
            this.groupBoxRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxRead.Location = new System.Drawing.Point(0, 124);
            this.groupBoxRead.Name = "groupBoxRead";
            this.groupBoxRead.Size = new System.Drawing.Size(1029, 368);
            this.groupBoxRead.TabIndex = 1;
            this.groupBoxRead.TabStop = false;
            this.groupBoxRead.Text = "Read";
            // 
            // buttonSzukajPelnoletnie
            // 
            this.buttonSzukajPelnoletnie.Location = new System.Drawing.Point(757, 281);
            this.buttonSzukajPelnoletnie.Name = "buttonSzukajPelnoletnie";
            this.buttonSzukajPelnoletnie.Size = new System.Drawing.Size(219, 64);
            this.buttonSzukajPelnoletnie.TabIndex = 21;
            this.buttonSzukajPelnoletnie.Text = "Szukaj pelnoletnie";
            this.buttonSzukajPelnoletnie.UseVisualStyleBackColor = true;
            this.buttonSzukajPelnoletnie.Click += new System.EventHandler(this.buttonSzukajPelnoletnie_Click);
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(825, 167);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(107, 58);
            this.buttonSzukaj.TabIndex = 20;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImie,
            this.ColumnNazwisko,
            this.ColumnWiek,
            this.ColumnCzyPelnoletnia,
            this.ColumnMiasto,
            this.ColumnUlica});
            this.dataGridViewLista.Location = new System.Drawing.Point(6, 195);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.RowTemplate.Height = 25;
            this.dataGridViewLista.Size = new System.Drawing.Size(684, 150);
            this.dataGridViewLista.TabIndex = 19;
            // 
            // comboBoxWynik
            // 
            this.comboBoxWynik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWynik.FormattingEnabled = true;
            this.comboBoxWynik.Location = new System.Drawing.Point(358, 121);
            this.comboBoxWynik.Name = "comboBoxWynik";
            this.comboBoxWynik.Size = new System.Drawing.Size(193, 23);
            this.comboBoxWynik.TabIndex = 18;
            // 
            // buttonSzukajWiek
            // 
            this.buttonSzukajWiek.Location = new System.Drawing.Point(165, 114);
            this.buttonSzukajWiek.Name = "buttonSzukajWiek";
            this.buttonSzukajWiek.Size = new System.Drawing.Size(137, 35);
            this.buttonSzukajWiek.TabIndex = 17;
            this.buttonSzukajWiek.Text = "Wszukaj wiek";
            this.buttonSzukajWiek.UseVisualStyleBackColor = true;
            this.buttonSzukajWiek.Click += new System.EventHandler(this.buttonSzukajWiek_Click);
            // 
            // numericUpDownSzukajWiek
            // 
            this.numericUpDownSzukajWiek.Location = new System.Drawing.Point(12, 126);
            this.numericUpDownSzukajWiek.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownSzukajWiek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSzukajWiek.Name = "numericUpDownSzukajWiek";
            this.numericUpDownSzukajWiek.ReadOnly = true;
            this.numericUpDownSzukajWiek.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSzukajWiek.TabIndex = 16;
            this.numericUpDownSzukajWiek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSzukajWieku
            // 
            this.labelSzukajWieku.AutoSize = true;
            this.labelSzukajWieku.Location = new System.Drawing.Point(12, 96);
            this.labelSzukajWieku.Name = "labelSzukajWieku";
            this.labelSzukajWieku.Size = new System.Drawing.Size(67, 15);
            this.labelSzukajWieku.TabIndex = 15;
            this.labelSzukajWieku.Text = "Podaj wiek:";
            // 
            // numericUpDownSzukajId
            // 
            this.numericUpDownSzukajId.Location = new System.Drawing.Point(643, 49);
            this.numericUpDownSzukajId.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownSzukajId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSzukajId.Name = "numericUpDownSzukajId";
            this.numericUpDownSzukajId.ReadOnly = true;
            this.numericUpDownSzukajId.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownSzukajId.TabIndex = 13;
            this.numericUpDownSzukajId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOdczytajWiersz
            // 
            this.buttonOdczytajWiersz.Location = new System.Drawing.Point(434, 39);
            this.buttonOdczytajWiersz.Name = "buttonOdczytajWiersz";
            this.buttonOdczytajWiersz.Size = new System.Drawing.Size(176, 39);
            this.buttonOdczytajWiersz.TabIndex = 12;
            this.buttonOdczytajWiersz.Text = "Jeden wiersz";
            this.buttonOdczytajWiersz.UseVisualStyleBackColor = true;
            this.buttonOdczytajWiersz.Click += new System.EventHandler(this.buttonOdczytajWiersz_Click);
            // 
            // numericUpDownWiekRead
            // 
            this.numericUpDownWiekRead.Location = new System.Drawing.Point(256, 56);
            this.numericUpDownWiekRead.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownWiekRead.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWiekRead.Name = "numericUpDownWiekRead";
            this.numericUpDownWiekRead.ReadOnly = true;
            this.numericUpDownWiekRead.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownWiekRead.TabIndex = 11;
            this.numericUpDownWiekRead.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelWiekRead
            // 
            this.labelWiekRead.AutoSize = true;
            this.labelWiekRead.Location = new System.Drawing.Point(256, 26);
            this.labelWiekRead.Name = "labelWiekRead";
            this.labelWiekRead.Size = new System.Drawing.Size(36, 15);
            this.labelWiekRead.TabIndex = 10;
            this.labelWiekRead.Text = "Wiek:";
            // 
            // textBoxNazwiskoRead
            // 
            this.textBoxNazwiskoRead.Location = new System.Drawing.Point(132, 55);
            this.textBoxNazwiskoRead.Name = "textBoxNazwiskoRead";
            this.textBoxNazwiskoRead.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwiskoRead.TabIndex = 9;
            // 
            // labelNazwiskoRead
            // 
            this.labelNazwiskoRead.AutoSize = true;
            this.labelNazwiskoRead.Location = new System.Drawing.Point(132, 26);
            this.labelNazwiskoRead.Name = "labelNazwiskoRead";
            this.labelNazwiskoRead.Size = new System.Drawing.Size(60, 15);
            this.labelNazwiskoRead.TabIndex = 8;
            this.labelNazwiskoRead.Text = "Nazwisko:";
            // 
            // textBoxImieRead
            // 
            this.textBoxImieRead.Location = new System.Drawing.Point(12, 55);
            this.textBoxImieRead.Name = "textBoxImieRead";
            this.textBoxImieRead.Size = new System.Drawing.Size(100, 23);
            this.textBoxImieRead.TabIndex = 7;
            // 
            // labelImieRead
            // 
            this.labelImieRead.AutoSize = true;
            this.labelImieRead.Location = new System.Drawing.Point(12, 26);
            this.labelImieRead.Name = "labelImieRead";
            this.labelImieRead.Size = new System.Drawing.Size(33, 15);
            this.labelImieRead.TabIndex = 6;
            this.labelImieRead.Text = "Imie:";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.labelNazwiskoUpdate);
            this.groupBoxUpdate.Controls.Add(this.labelId);
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.numericUpDownId);
            this.groupBoxUpdate.Controls.Add(this.textBoxNazwiskoUpdate);
            this.groupBoxUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUpdate.Location = new System.Drawing.Point(0, 492);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(1029, 102);
            this.groupBoxUpdate.TabIndex = 2;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update";
            // 
            // labelNazwiskoUpdate
            // 
            this.labelNazwiskoUpdate.AutoSize = true;
            this.labelNazwiskoUpdate.Location = new System.Drawing.Point(140, 19);
            this.labelNazwiskoUpdate.Name = "labelNazwiskoUpdate";
            this.labelNazwiskoUpdate.Size = new System.Drawing.Size(92, 15);
            this.labelNazwiskoUpdate.TabIndex = 4;
            this.labelNazwiskoUpdate.Text = "Nowe nazwisko:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 19);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Id";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(256, 13);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(166, 69);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(12, 37);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownId.TabIndex = 1;
            // 
            // textBoxNazwiskoUpdate
            // 
            this.textBoxNazwiskoUpdate.Location = new System.Drawing.Point(138, 37);
            this.textBoxNazwiskoUpdate.Name = "textBoxNazwiskoUpdate";
            this.textBoxNazwiskoUpdate.Size = new System.Drawing.Size(100, 23);
            this.textBoxNazwiskoUpdate.TabIndex = 0;
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.labelDelete);
            this.groupBoxDelete.Controls.Add(this.numericUpDownDeleteId);
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDelete.Location = new System.Drawing.Point(0, 594);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(1029, 135);
            this.groupBoxDelete.TabIndex = 3;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(12, 32);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(20, 15);
            this.labelDelete.TabIndex = 2;
            this.labelDelete.Text = "Id:";
            // 
            // numericUpDownDeleteId
            // 
            this.numericUpDownDeleteId.Location = new System.Drawing.Point(12, 57);
            this.numericUpDownDeleteId.Name = "numericUpDownDeleteId";
            this.numericUpDownDeleteId.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDeleteId.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(165, 32);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 63);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Skasuj";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // ColumnWiek
            // 
            this.ColumnWiek.DataPropertyName = "Wiek";
            this.ColumnWiek.HeaderText = "Wiek osoby";
            this.ColumnWiek.Name = "ColumnWiek";
            this.ColumnWiek.ReadOnly = true;
            // 
            // ColumnCzyPelnoletnia
            // 
            this.ColumnCzyPelnoletnia.DataPropertyName = "Pelnoletnosc";
            this.ColumnCzyPelnoletnia.HeaderText = "Pełnoletność";
            this.ColumnCzyPelnoletnia.Name = "ColumnCzyPelnoletnia";
            this.ColumnCzyPelnoletnia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCzyPelnoletnia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnMiasto
            // 
            this.ColumnMiasto.DataPropertyName = "Miasto";
            this.ColumnMiasto.HeaderText = "Miasto";
            this.ColumnMiasto.Name = "ColumnMiasto";
            // 
            // ColumnUlica
            // 
            this.ColumnUlica.DataPropertyName = "Ulica";
            this.ColumnUlica.HeaderText = "Ulica";
            this.ColumnUlica.Name = "ColumnUlica";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 729);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxRead);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "OknoGlowne";
            this.Text = "Form1";
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).EndInit();
            this.groupBoxRead.ResumeLayout(false);
            this.groupBoxRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzukajWiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSzukajId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiekRead)).EndInit();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeleteId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.NumericUpDown numericUpDownWiek;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.GroupBox groupBoxRead;
        private System.Windows.Forms.Button buttonOdczytajWiersz;
        private System.Windows.Forms.NumericUpDown numericUpDownWiekRead;
        private System.Windows.Forms.Label labelWiekRead;
        private System.Windows.Forms.TextBox textBoxNazwiskoRead;
        private System.Windows.Forms.Label labelNazwiskoRead;
        private System.Windows.Forms.TextBox textBoxImieRead;
        private System.Windows.Forms.Label labelImieRead;
        private System.Windows.Forms.NumericUpDown numericUpDownSzukajId;
        private System.Windows.Forms.Label labelSzukajWieku;
        private System.Windows.Forms.NumericUpDown numericUpDownSzukajWiek;
        private System.Windows.Forms.ComboBox comboBoxWynik;
        private System.Windows.Forms.Button buttonSzukajWiek;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button buttonSzukajPelnoletnie;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Label labelNazwiskoUpdate;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.TextBox textBoxNazwiskoUpdate;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownDeleteId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWiek;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCzyPelnoletnia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMiasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUlica;
    }
}

