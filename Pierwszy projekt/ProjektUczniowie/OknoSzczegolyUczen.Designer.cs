
namespace ProjektUczniowie
{
    partial class OknoSzczegolyUczen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.numericUpDownRok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelRok = new System.Windows.Forms.Label();
            this.labelKlasa = new System.Windows.Forms.Label();
            this.labelmie = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(117, 9);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(57, 15);
            this.labelNazwisko.TabIndex = 9;
            this.labelNazwisko.Text = "Nazwisko";
            // 
            // numericUpDownRok
            // 
            this.numericUpDownRok.Location = new System.Drawing.Point(373, 27);
            this.numericUpDownRok.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numericUpDownRok.Name = "numericUpDownRok";
            this.numericUpDownRok.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRok.TabIndex = 15;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(246, 27);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxKlasa.TabIndex = 14;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(117, 29);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(123, 23);
            this.textBoxNazwisko.TabIndex = 13;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 29);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(99, 23);
            this.textBoxImie.TabIndex = 12;
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Location = new System.Drawing.Point(373, 9);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(27, 15);
            this.labelRok.TabIndex = 11;
            this.labelRok.Text = "Rok";
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(246, 9);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(34, 15);
            this.labelKlasa.TabIndex = 10;
            this.labelKlasa.Text = "Klasa";
            // 
            // labelmie
            // 
            this.labelmie.AutoSize = true;
            this.labelmie.Location = new System.Drawing.Point(12, 9);
            this.labelmie.Name = "labelmie";
            this.labelmie.Size = new System.Drawing.Size(30, 15);
            this.labelmie.TabIndex = 8;
            this.labelmie.Text = "Imie";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(108, 99);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(298, 100);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 17;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // OknoSzczegolyUczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 158);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.numericUpDownRok);
            this.Controls.Add(this.comboBoxKlasa);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.labelKlasa);
            this.Controls.Add(this.labelmie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoSzczegolyUczen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OknoSzczegolyUczen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.NumericUpDown numericUpDownRok;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.Label labelmie;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}