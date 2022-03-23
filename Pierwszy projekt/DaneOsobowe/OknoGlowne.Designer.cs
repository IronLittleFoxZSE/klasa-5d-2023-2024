
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
            this.groupBoxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).BeginInit();
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
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 617);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "OknoGlowne";
            this.Text = "Form1";
            this.groupBoxCreate.ResumeLayout(false);
            this.groupBoxCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWiek)).EndInit();
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
    }
}

