
namespace Notatnik
{
    partial class OknoPomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoPomoc));
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelLicencja = new System.Windows.Forms.Label();
            this.pictureBoxObraz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObraz)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonZamknij.Location = new System.Drawing.Point(190, 406);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(125, 61);
            this.buttonZamknij.TabIndex = 0;
            this.buttonZamknij.Text = "Ok";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOpis.Location = new System.Drawing.Point(12, 20);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(488, 90);
            this.labelOpis.TabIndex = 1;
            this.labelOpis.Text = "Program \"Notatnik\"\r\nNapisany na zajęciach z\r\n\"Programowania strukturalnego i obie" +
    "ktowego\"";
            // 
            // labelLicencja
            // 
            this.labelLicencja.AutoSize = true;
            this.labelLicencja.Location = new System.Drawing.Point(12, 376);
            this.labelLicencja.Name = "labelLicencja";
            this.labelLicencja.Size = new System.Drawing.Size(107, 15);
            this.labelLicencja.TabIndex = 2;
            this.labelLicencja.Text = "Licencja: bezpłatna";
            // 
            // pictureBoxObraz
            // 
            this.pictureBoxObraz.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxObraz.Image")));
            this.pictureBoxObraz.Location = new System.Drawing.Point(32, 113);
            this.pictureBoxObraz.Name = "pictureBoxObraz";
            this.pictureBoxObraz.Size = new System.Drawing.Size(484, 238);
            this.pictureBoxObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObraz.TabIndex = 3;
            this.pictureBoxObraz.TabStop = false;
            // 
            // OknoPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 493);
            this.Controls.Add(this.pictureBoxObraz);
            this.Controls.Add(this.labelLicencja);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.buttonZamknij);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OknoPomoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Okono Pomocy - Informacje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelLicencja;
        private System.Windows.Forms.PictureBox pictureBoxObraz;
    }
}