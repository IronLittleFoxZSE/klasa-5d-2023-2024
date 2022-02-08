
namespace Pierwsze_okno
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
            this.components = new System.ComponentModel.Container();
            this.buttonPierwszy = new System.Windows.Forms.Button();
            this.labelPowitanie = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPokarzOknoKomunikatu = new System.Windows.Forms.Button();
            this.buttonOknoUzytkownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPierwszy
            // 
            this.buttonPierwszy.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPierwszy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonPierwszy.Location = new System.Drawing.Point(143, 148);
            this.buttonPierwszy.Name = "buttonPierwszy";
            this.buttonPierwszy.Size = new System.Drawing.Size(190, 120);
            this.buttonPierwszy.TabIndex = 0;
            this.buttonPierwszy.TabStop = false;
            this.buttonPierwszy.Text = "Pierwszy przycisk";
            this.buttonPierwszy.UseVisualStyleBackColor = true;
            this.buttonPierwszy.Click += new System.EventHandler(this.buttonPierwszy_Click);
            this.buttonPierwszy.MouseEnter += new System.EventHandler(this.buttonPierwszy_MouseEnter);
            // 
            // labelPowitanie
            // 
            this.labelPowitanie.AutoSize = true;
            this.labelPowitanie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPowitanie.Location = new System.Drawing.Point(262, 52);
            this.labelPowitanie.Name = "labelPowitanie";
            this.labelPowitanie.Size = new System.Drawing.Size(0, 32);
            this.labelPowitanie.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonPokarzOknoKomunikatu
            // 
            this.buttonPokarzOknoKomunikatu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPokarzOknoKomunikatu.Location = new System.Drawing.Point(461, 86);
            this.buttonPokarzOknoKomunikatu.Name = "buttonPokarzOknoKomunikatu";
            this.buttonPokarzOknoKomunikatu.Size = new System.Drawing.Size(281, 148);
            this.buttonPokarzOknoKomunikatu.TabIndex = 2;
            this.buttonPokarzOknoKomunikatu.Text = "Okno komunikatu";
            this.buttonPokarzOknoKomunikatu.UseVisualStyleBackColor = true;
            this.buttonPokarzOknoKomunikatu.Click += new System.EventHandler(this.buttonPokarzOknoKomunikatu_Click);
            // 
            // buttonOknoUzytkownika
            // 
            this.buttonOknoUzytkownika.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOknoUzytkownika.Location = new System.Drawing.Point(416, 333);
            this.buttonOknoUzytkownika.Name = "buttonOknoUzytkownika";
            this.buttonOknoUzytkownika.Size = new System.Drawing.Size(342, 152);
            this.buttonOknoUzytkownika.TabIndex = 3;
            this.buttonOknoUzytkownika.Text = "Pokaż okno";
            this.buttonOknoUzytkownika.UseVisualStyleBackColor = true;
            this.buttonOknoUzytkownika.Click += new System.EventHandler(this.buttonOknoUzytkownika_Click);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 588);
            this.Controls.Add(this.buttonOknoUzytkownika);
            this.Controls.Add(this.buttonPokarzOknoKomunikatu);
            this.Controls.Add(this.labelPowitanie);
            this.Controls.Add(this.buttonPierwszy);
            this.MinimumSize = new System.Drawing.Size(939, 627);
            this.Name = "OknoGlowne";
            this.Text = "Pierwsze okno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPierwszy;
        private System.Windows.Forms.Label labelPowitanie;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonPokarzOknoKomunikatu;
        private System.Windows.Forms.Button buttonOknoUzytkownika;
    }
}

